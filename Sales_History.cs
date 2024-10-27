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
    public partial class Sales_History : Form
    {
        public Sales_History()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";

        private void sales_HistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sales_HistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Sales_History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Sales_History' table. You can move, or remove it, as needed.
            this.sales_HistoryTableAdapter.Fill(this.courseDataSet.Sales_History);

        }

        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            SortSalesData();
        }
        private void SortSalesData()
        {
            string sortField = GetSalesSortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Sales_History, sortField, sortDirection);
            sales_HistoryBindingSource.DataSource = sortedData; // Використовуйте salesBindingSource для таблиці Sales_History
        }

        private string GetSalesSortField()
        {
            if (radioButtonSalesId.Checked) return "sales_id"; // Поле sales_id для сортування
            if (radioButtonOrderId.Checked) return "order_id"; // Поле order_id для сортування
            if (radioButtonProductId.Checked) return "product_id"; // Поле product_id для сортування
            if (radioButtonSaleDate.Checked) return "sale_date"; // Поле sale_date для сортування
            if (radioButtonQuantity.Checked) return "quantity"; // Поле quantity для сортування
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
            // Отримання дат з текстових полів
            string minValueText = txtMinValue.Text.Trim();
            string maxValueText = txtMaxValue.Text.Trim();

            // Перевірка наявності коректних дат
            if (DateTime.TryParse(minValueText, out DateTime minValue) && DateTime.TryParse(maxValueText, out DateTime maxValue))
            {
                // Фільтрація даних за датою
                var filteredSales = courseDataSet.Sales_History
                    .AsEnumerable()
                    .Where(row => row.Field<DateTime>("sale_date") >= minValue && row.Field<DateTime>("sale_date") <= maxValue)
                    .CopyToDataTable();

                // Перевірка наявності відфільтрованих даних
                if (filteredSales.Rows.Count > 0)
                {
                    // Відображення відфільтрованих даних у dataGridView2
                    dataGridView2.DataSource = filteredSales;
                }
                else
                {
                    MessageBox.Show("Не знайдено жодного продажу за вказаними датами.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні дати для фільтрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalSales();
        }
        private void CalculateTotalSales()
        {
            // Перевірка, чи є дані у таблиці Sales_History
            if (courseDataSet.Sales_History.Rows.Count == 0)
            {
                MessageBox.Show("Таблиця продажів порожня.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Підрахунок загальної кількості, максимального, мінімального та середнього значення продажів
            int totalQuantity = courseDataSet.Sales_History.AsEnumerable().Sum(row => row.Field<int>("quantity"));
            int maxQuantity = courseDataSet.Sales_History.AsEnumerable().Max(row => row.Field<int>("quantity"));
            int minQuantity = courseDataSet.Sales_History.AsEnumerable().Min(row => row.Field<int>("quantity"));
            double averageQuantity = courseDataSet.Sales_History.AsEnumerable().Average(row => row.Field<int>("quantity"));

            // Відображення результатів
            MessageBox.Show($"Загальна кількість продажів: {totalQuantity}\nМаксимальна кількість: {maxQuantity}\nМінімальна кількість: {minQuantity}\nСередня кількість: {averageQuantity:F2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Створення DataTable для відображення результатів у dataGridView2
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("Показник", typeof(string));
            resultsTable.Columns.Add("Значення", typeof(double));

            // Додавання рядків з результатами
            resultsTable.Rows.Add("Загальна кількість продажів", totalQuantity);
            resultsTable.Rows.Add("Максимальна кількість продажів", maxQuantity);
            resultsTable.Rows.Add("Мінімальна кількість продажів", minQuantity);
            resultsTable.Rows.Add("Середня кількість продажів", averageQuantity);

            // Відображення результатів у dataGridView2
            dataGridView2.DataSource = resultsTable;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів для таблиці Sales_History
            string minValueText = textBoxMinValue.Text.Trim();
            string maxValueText = textBoxMaxValue.Text.Trim();

            // Формування базового SQL-запиту для таблиці Sales_History
            StringBuilder queryBuilderSales = new StringBuilder("SELECT * FROM [Sales_History] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minSalesId = 0;
            int maxSalesId = 0;
            int minQuantity = 0;
            int maxQuantity = 0;
            DateTime? minSaleDate = null; // Nullable type
            DateTime? maxSaleDate = null; // Nullable type

            // Перевірка наявності умов для таблиці Sales_History
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Перевірка на числове значення для sales_id
                if (int.TryParse(minValueText, out minSalesId))
                {
                    if (int.TryParse(maxValueText, out maxSalesId))
                    {
                        queryBuilderSales.Append(" AND sales_id BETWEEN @MinSalesId AND @MaxSalesId");
                    }
                    else
                    {
                        queryBuilderSales.Append(" AND sales_id = @MinSalesId");
                    }
                }
                // Перевірка на числове значення для quantity
                else if (int.TryParse(minValueText, out minQuantity))
                {
                    if (int.TryParse(maxValueText, out maxQuantity))
                    {
                        queryBuilderSales.Append(" AND quantity BETWEEN @MinQuantity AND @MaxQuantity");
                    }
                    else
                    {
                        queryBuilderSales.Append(" AND quantity = @MinQuantity");
                    }
                }
                // Перевірка на дати для sale_date
                else if (DateTime.TryParse(minValueText, out DateTime parsedMinSaleDate))
                {
                    minSaleDate = parsedMinSaleDate; // Присвоєння розібраної дати
                    if (DateTime.TryParse(maxValueText, out DateTime parsedMaxSaleDate))
                    {
                        maxSaleDate = parsedMaxSaleDate; // Присвоєння розібраної дати
                        queryBuilderSales.Append(" AND sale_date BETWEEN @MinSaleDate AND @MaxSaleDate");
                    }
                    else
                    {
                        queryBuilderSales.Append(" AND sale_date = @MinSaleDate");
                    }
                }
                else
                {
                    // Якщо minValueText - текст, додаємо умову для order_id
                    queryBuilderSales.Append(" AND order_id = @OrderId");
                }
            }

            // Виводимо сформований запит для налагодження
            string finalQuerySales = queryBuilderSales.ToString();
            Console.WriteLine(finalQuerySales);

            // Виконання запиту для таблиці Sales_History
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandSales = new SqlCommand(finalQuerySales, connection);

                // Додаємо параметри для безпеки
                if (minSalesId > 0)
                {
                    commandSales.Parameters.AddWithValue("@MinSalesId", minSalesId);
                }
                if (maxSalesId > 0)
                {
                    commandSales.Parameters.AddWithValue("@MaxSalesId", maxSalesId);
                }
                if (minQuantity > 0)
                {
                    commandSales.Parameters.AddWithValue("@MinQuantity", minQuantity);
                }
                if (maxQuantity > 0)
                {
                    commandSales.Parameters.AddWithValue("@MaxQuantity", maxQuantity);
                }
                if (minSaleDate.HasValue)
                {
                    commandSales.Parameters.AddWithValue("@MinSaleDate", minSaleDate.Value);
                }
                if (maxSaleDate.HasValue)
                {
                    commandSales.Parameters.AddWithValue("@MaxSaleDate", maxSaleDate.Value);
                }

                SqlDataAdapter adapterSales = new SqlDataAdapter(commandSales);
                DataTable resultsTableSales = new DataTable();

                try
                {
                    connection.Open();
                    adapterSales.Fill(resultsTableSales);

                    // Відображення результатів у dataGridView
                    if (resultsTableSales.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = resultsTableSales;
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

        private void btnJoinTables1_Click(object sender, EventArgs e)
        {
            // SQL-запит для внутрішнього об'єднання таблиць
            string query = @"
        SELECT sh.*, p.name
        FROM Sales_History sh
        INNER JOIN Product p ON sh.product_id = p.product_id";

            // Виконання запиту та заповнення DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridView2
                    dataGridView2.DataSource = resultsTable;

                    // Перевірка наявності даних
                    if (resultsTable.Rows.Count == 0)
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
    }
}

