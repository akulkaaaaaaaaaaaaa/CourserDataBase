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
    public partial class Stock_Inventory : Form
    {
        public Stock_Inventory()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";

        private void stock_InventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_InventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Stock_Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Stock_Inventory' table. You can move, or remove it, as needed.
            this.stock_InventoryTableAdapter.Fill(this.courseDataSet.Stock_Inventory);

        }

        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            SortStockInventoryData();
        }
        private void SortStockInventoryData()
        {
            string sortField = GetStockInventorySortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Stock_Inventory, sortField, sortDirection);
            stock_InventoryBindingSource.DataSource = sortedData;
        }
        private string GetSortDirection()
        {
            return radioButtonAsc.Checked ? "ASC" : "DESC";
        }
        private string GetStockInventorySortField()
        {
            if (radioButtonStockID.Checked) return "stock_id";
            if (radioButtonPharmacyID.Checked) return "pharmacy_id";
            if (radioButtonProductID.Checked) return "product_id";
            if (radioButtonQuantity.Checked) return "quantity";
            return null;
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

        private void btnCalculateReliabilityRating_Click(object sender, EventArgs e)
        {
            CalculateStatistics();

        }
        private void CalculateStatistics()
        {
            // Переконайтесь, що у вас є дані в DataSet
            if (courseDataSet.Stock_Inventory.Rows.Count == 0)
            {
                MessageBox.Show("Немає доступних даних для обчислення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримуємо кількість з таблиці
            var quantities = courseDataSet.Stock_Inventory.AsEnumerable()
                .Select(row => row.Field<int>("quantity"))
                .ToList();

            if (quantities.Count == 0)
            {
                MessageBox.Show("Кількість не знайдена.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Обчислюємо максимальне, мінімальне та середнє значення
            int maxQuantity = quantities.Max();
            int minQuantity = quantities.Min();
            double averageQuantity = quantities.Average();

            // Створення таблиці для відображення результатів
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("Максимум", typeof(int));
            resultsTable.Columns.Add("Мінімум", typeof(int));
            resultsTable.Columns.Add("Середнє", typeof(double));

            // Додаємо рядок з обчисленими значеннями
            resultsTable.Rows.Add(maxQuantity, minQuantity, averageQuantity);

            // Відображення результатів у DataGridView
            dataGridView1.DataSource = resultsTable;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FilterStockInventory();
        }
        private void FilterStockInventory()
        {
            // Отримання значень з полів введення
            string minQuantityText = textBoxMinQuantity.Text.Trim();
            string maxQuantityText = textBoxMaxQuantity.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Stock_Inventory] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minQuantity = 0;
            int maxQuantity = 0;

            // Додаємо умови для фільтрації
            if (!string.IsNullOrEmpty(minQuantityText) && int.TryParse(minQuantityText, out minQuantity))
            {
                queryBuilder.Append(" AND quantity >= @MinQuantity");
            }

            if (!string.IsNullOrEmpty(maxQuantityText) && int.TryParse(maxQuantityText, out maxQuantity))
            {
                queryBuilder.Append(" AND quantity <= @MaxQuantity");
            }

            // Виводимо сформований запит для налагодження
            string finalQuery = queryBuilder.ToString();
            Console.WriteLine(finalQuery);

            // Виконання запиту
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(finalQuery, connection);

                // Додаємо параметри для безпеки
                if (!string.IsNullOrEmpty(minQuantityText) && int.TryParse(minQuantityText, out minQuantity))
                {
                    command.Parameters.AddWithValue("@MinQuantity", minQuantity);
                }

                if (!string.IsNullOrEmpty(maxQuantityText) && int.TryParse(maxQuantityText, out maxQuantity))
                {
                    command.Parameters.AddWithValue("@MaxQuantity", maxQuantity);
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
                        dataGridView1.DataSource = resultsTable; // Замініть на ваше dataGridView для запасів
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Формування SQL-запиту для внутрішнього об'єднання
            string query = @"
        SELECT 
            si.stock_id, 
            si.pharmacy_id, 
            si.product_id, 
            si.quantity, 
            p.name 
        FROM 
            Stock_Inventory si 
        INNER JOIN 
            Product p ON si.product_id = p.product_id";

            // Виконання запиту
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
                        dataGridView1.DataSource = resultsTable; // Замініть на ваше DataGridView
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string stockRangeText = textBoxStockRange.Text.Trim(); // Діапазон для stock_id
            string quantityRangeText = textBoxQuantityRange.Text.Trim(); // Діапазон для quantity

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Stock_Inventory] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minStockId = 0;
            int maxStockId = 0;
            decimal minQuantity = 0;
            decimal maxQuantity = 0;
            bool hasConditions = false;

            // Перевірка діапазону stock_id
            if (!string.IsNullOrEmpty(stockRangeText))
            {
                string[] stockValues = stockRangeText.Split(',');

                if (stockValues.Length == 2 &&
                    int.TryParse(stockValues[0].Trim(), out minStockId) &&
                    int.TryParse(stockValues[1].Trim(), out maxStockId))
                {
                    queryBuilder.Append(" AND stock_id BETWEEN @MinStockId AND @MaxStockId");
                    hasConditions = true;
                }
            }

            // Перевірка діапазону quantity
            if (!string.IsNullOrEmpty(quantityRangeText))
            {
                string[] quantityValues = quantityRangeText.Split(',');

                if (quantityValues.Length == 2 &&
                    decimal.TryParse(quantityValues[0].Trim(), out minQuantity) &&
                    decimal.TryParse(quantityValues[1].Trim(), out maxQuantity))
                {
                    queryBuilder.Append(" AND quantity BETWEEN @MinQuantity AND @MaxQuantity");
                    hasConditions = true;
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
                    command.Parameters.AddWithValue("@MinStockId", minStockId);
                    command.Parameters.AddWithValue("@MaxStockId", maxStockId);
                    command.Parameters.AddWithValue("@MinQuantity", minQuantity);
                    command.Parameters.AddWithValue("@MaxQuantity", maxQuantity);
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
                        dataGridView2.DataSource = resultsTable; // Замініть на ваше DataGridView для запасів
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
    }
}
