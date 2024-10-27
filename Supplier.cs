using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Course
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.courseDataSet.Supplier);

        }
      

        private void SortSupplierData()
        {
            string sortField = GetSupplierSortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Supplier, sortField, sortDirection);
            supplierBindingSource.DataSource = sortedData; // Використовуйте supplierBindingSource для таблиці Supplier
        }

        private string GetSupplierSortField()
        {
            if (radioButtonSupplierID.Checked) return "supplier_id"; // Поле supplier_id для сортування
            if (radioButtonCompanyName.Checked) return "company_name"; // Поле company_name для сортування
            if (radioButtonContactInfo.Checked) return "contact_info"; // Поле contact_info для сортування
            if (radioButtonDeliveryTerms.Checked) return "delivery_terms"; // Поле delivery_terms для сортування
            if (radioButtonReliabilityRating.Checked) return "reliability_rating"; // Поле reliability_rating для сортування
            return null;
        }

        private string GetSortDirection()
        {
            return radioButtonAscSupplier.Checked ? "ASC" : "DESC";
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

        private void btnSortSupplier_Click_1(object sender, EventArgs e)
        {
            SortSupplierData();
        }

        private void btnCalculateReliabilityRating_Click(object sender, EventArgs e)
        {
            CalculateReliabilityRating();
        }
        private void CalculateReliabilityRating()
        {
            // Перевірка, чи є дані в таблиці Supplier
            if (courseDataSet.Supplier.Rows.Count == 0)
            {
                MessageBox.Show("Таблиця постачальників пуста.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримання значень рейтингу надійності
            var ratings = courseDataSet.Supplier.AsEnumerable()
                .Select(row => row.Field<decimal>("reliability_rating")) // Замініть тип на правильний (наприклад, decimal)
                .ToList();

            if (ratings.Count == 0)
            {
                MessageBox.Show("Немає рейтингів надійності для обчислення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Обчислення середнього, мінімального та максимального значення
            decimal averageRating = ratings.Average();
            decimal minRating = ratings.Min();
            decimal maxRating = ratings.Max();

            // Створення нового DataTable для результатів
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("Statistic", typeof(string));
            resultsTable.Columns.Add("Value", typeof(decimal));

            // Додавання результатів до таблиці
            resultsTable.Rows.Add("Середній рейтинг", averageRating);
            resultsTable.Rows.Add("Мінімальний рейтинг", minRating);
            resultsTable.Rows.Add("Максимальний рейтинг", maxRating);

            // Виведення результатів в dataGridViewSupplier1
            dataGridViewSupplier1.DataSource = resultsTable;
        }

        private void btnFilterSupplier_Click(object sender, EventArgs e)
        {
            // Замінюємо кому на крапку для правильного форматування
            string minSupplierInput = txtMinSupplier.Text.Replace(',', '.');
            string maxSupplierInput = txtMaxSupplier.Text.Replace(',', '.');

            // Спроба перетворення значень з текстових полів
            if (decimal.TryParse(minSupplierInput, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal minRating) &&
                decimal.TryParse(maxSupplierInput, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal maxRating))
            {
                // Фільтрація постачальників на основі рейтингу надійності
                var filteredSuppliers = courseDataSet.Supplier.AsEnumerable()
                    .Where(row =>
                        row.Field<decimal>("reliability_rating") >= minRating &&
                        row.Field<decimal>("reliability_rating") <= maxRating
                    );

                // Перевірка наявності рядків, що відповідають фільтру
                if (filteredSuppliers.Any())
                {
                    // Створення нового DataTable та встановлення його як джерело даних
                    DataTable resultTable = filteredSuppliers.CopyToDataTable();
                    dataGridViewSupplier1.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("Не знайдено постачників за вказаними критеріями.", "Результати фільтрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewSupplier1.DataSource = null; // Очищення data grid, якщо немає результатів
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для рейтингу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonJoinTables_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT 
        Supplier.supplier_id, 
        Supplier.company_name, 
        Product.product_id, 
        Product.name, 
        Product.price
    FROM 
        Supplier
    INNER JOIN 
        Product ON Supplier.supplier_id = Product.supplier_id"; // Зв'язок між таблицями
            ExecuteJoinQuery(query);

        }
        // Загальний метод для виконання запиту об'єднання та відображення результатів
        private void ExecuteJoinQuery(string query)
        {
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
                        dataGridViewSupplier1.DataSource = resultsTable;
                    }
                    else
                    {
                        MessageBox.Show("Жодних записів не знайдено.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string minValueText = textBoxMinSupplier.Text.Trim();
            string maxValueText = textBoxMaxSupplier.Text.Trim();
            string searchValueText = textBoxSearchValue.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Supplier] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minSupplierId = 0;
            int maxSupplierId = 0;
            decimal minReliabilityRating = 0;
            decimal maxReliabilityRating = 0;

            // Параметри для умов пошуку
            bool hasConditions = false;

            // Перевірка наявності умов
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Пошук за supplier_id
                if (int.TryParse(minValueText, out minSupplierId))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND supplier_id = @MinSupplierId");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxSupplierId))
                    {
                        queryBuilder.Append(" AND supplier_id BETWEEN @MinSupplierId AND @MaxSupplierId");
                        hasConditions = true;
                    }
                }
                // Пошук за reliability_rating
                else if (decimal.TryParse(minValueText, out minReliabilityRating))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND reliability_rating = @MinReliabilityRating");
                        hasConditions = true;
                    }
                    else if (decimal.TryParse(maxValueText, out maxReliabilityRating))
                    {
                        queryBuilder.Append(" AND reliability_rating BETWEEN @MinReliabilityRating AND @MaxReliabilityRating");
                        hasConditions = true;
                    }
                }
            }

            // Додаємо умови для пошуку текстових атрибутів
            if (!string.IsNullOrEmpty(searchValueText))
            {
                queryBuilder.Append(" AND (company_name LIKE @SearchValue OR contact_info LIKE @SearchValue OR delivery_terms LIKE @SearchValue)");
                hasConditions = true;
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
                    if (int.TryParse(minValueText, out minSupplierId))
                    {
                        command.Parameters.AddWithValue("@MinSupplierId", minSupplierId);
                    }

                    if (int.TryParse(maxValueText, out maxSupplierId))
                    {
                        command.Parameters.AddWithValue("@MaxSupplierId", maxSupplierId);
                    }

                    if (decimal.TryParse(minValueText, out minReliabilityRating))
                    {
                        command.Parameters.AddWithValue("@MinReliabilityRating", minReliabilityRating);
                    }

                    if (decimal.TryParse(maxValueText, out maxReliabilityRating))
                    {
                        command.Parameters.AddWithValue("@MaxReliabilityRating", maxReliabilityRating);
                    }

                    // Для текстових атрибутів
                    string searchValue = $"%{searchValueText}%";
                    command.Parameters.AddWithValue("@SearchValue", searchValue);
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
                        dataGridViewSupplier2.DataSource = resultsTable;
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
