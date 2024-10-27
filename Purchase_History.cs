using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Purchase_History : Form
    {
        public Purchase_History()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void purchase_HistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_HistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Purchase_History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Purchase_History' table. You can move, or remove it, as needed.
            this.purchase_HistoryTableAdapter.Fill(this.courseDataSet.Purchase_History);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchase_HistoryBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            SortPurchaseHistoryData();
        }
        private void SortPurchaseHistoryData()
        {
            string sortField = GetPurchaseHistorySortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Purchase_History, sortField, sortDirection);
            purchase_HistoryBindingSource.DataSource = sortedData;
        }

        private string GetPurchaseHistorySortField()
        {
            if (radioButtonPurchaseID.Checked) return "purchase_id";
            if (radioButtonCustomerID.Checked) return "customer_id";
            if (radioButtonProductID.Checked) return "product_id";
            if (radioButtonPurchaseDate.Checked) return "purchase_date";
            return null;
        }

        private string GetSortDirection()
        {
            return radioButtonAsc.Checked ? "ASC" : "DESC";
        }

        private DataTable SortDataTable(DataTable table, string sortField, string sortDirection)
        {
            var sortedRows = table.AsEnumerable()
                .OrderBy(row => row.Field<object>(sortField))
                .ToList();

            if (sortDirection == "DESC")
                sortedRows.Reverse();

            DataTable sortedTable = table.Clone();
            foreach (var row in sortedRows)
            {
                sortedTable.ImportRow(row);
            }

            return sortedTable;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Спробувати перетворити значення з текстових полів у дати
            if (DateTime.TryParse(txtMinValue.Text, out DateTime minValue) && DateTime.TryParse(txtMaxValue.Text, out DateTime maxValue))
            {
                // Фільтрація покупки за датами
                var filteredPurchases = courseDataSet.Purchase_History
                    .Where(row => row.purchase_date >= minValue && row.purchase_date <= maxValue)
                    .ToList();

                // Якщо знайдені записи, оновлюємо dataGridView
                if (filteredPurchases.Any())
                {
                    dataGridView1.DataSource = filteredPurchases;
                }
                else
                {
                    MessageBox.Show("Не знайдено жодної покупки за вказаними датами.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні дати для фільтрації.");
            }
        }

        private void btnJoinTables1_Click(object sender, EventArgs e)
        {   // Сформуйте SQL-запит для об'єднання
            string query = @"
        SELECT 
            C.full_name, 
            P.name, 
            PH.purchase_date 
        FROM 
            Purchase_History PH 
        INNER JOIN 
            Customer C ON PH.customer_id = C.customer_id 
        INNER JOIN 
            Product P ON PH.product_id = P.product_id;";

            // Виконайте запит і отримайте результати
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridView
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = resultsTable;
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено жодних записів.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minPurchaseIdText = textBoxMinPurchaseId.Text.Trim(); // Поле для мінімального purchase_id
            string maxPurchaseIdText = textBoxMaxPurchaseId.Text.Trim(); // Поле для максимального purchase_id
            string purchaseDateText = textBoxPurchaseDate.Text.Trim(); // Поле для purchase_date

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Purchase_History] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minPurchaseId = 0;
            int maxPurchaseId = 0;
            DateTime purchaseDate;

            // Параметри для умов пошуку
            bool hasConditions = false;

            // Перевірка наявності умов для purchase_id
            if (!string.IsNullOrEmpty(minPurchaseIdText))
            {
                if (int.TryParse(minPurchaseIdText, out minPurchaseId))
                {
                    if (string.IsNullOrEmpty(maxPurchaseIdText))
                    {
                        queryBuilder.Append(" AND purchase_id = @MinPurchaseId");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxPurchaseIdText, out maxPurchaseId))
                    {
                        queryBuilder.Append(" AND purchase_id BETWEEN @MinPurchaseId AND @MaxPurchaseId");
                        hasConditions = true;
                    }
                }
            }

            // Додаємо умови для purchase_date
            if (!string.IsNullOrEmpty(purchaseDateText))
            {
                if (DateTime.TryParse(purchaseDateText, out purchaseDate))
                {
                    queryBuilder.Append(" AND purchase_date = @PurchaseDate");
                    hasConditions = true;
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть коректну дату для purchase_date (формат: yyyy-MM-dd).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Вихід з методу, якщо дата некоректна
                }
            }

            // Виводимо сформований запит для налагодження
            string finalQuery = queryBuilder.ToString();
            Console.WriteLine(finalQuery);

            // Виконання запиту
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(finalQuery, connection);

                // Додаємо параметри для безпеки
                if (hasConditions)
                {
                    if (int.TryParse(minPurchaseIdText, out minPurchaseId))
                    {
                        command.Parameters.AddWithValue("@MinPurchaseId", minPurchaseId);
                    }

                    if (int.TryParse(maxPurchaseIdText, out maxPurchaseId))
                    {
                        command.Parameters.AddWithValue("@MaxPurchaseId", maxPurchaseId);
                    }

                    // Для purchase_date
                    if (DateTime.TryParse(purchaseDateText, out purchaseDate))
                    {
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridView
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = resultsTable; // Замініть на ваше dataGridView для історії покупок
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено жодних записів для вказаного діапазону.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
