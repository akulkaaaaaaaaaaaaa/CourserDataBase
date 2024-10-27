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
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void pharmacyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.courseDataSet.Pharmacy);

        }

        private void SortPharmacy_Click(object sender, EventArgs e)
        {
            string sortField = GetPharmacySortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Pharmacy, sortField, sortDirection);
            pharmacyBindingSource.DataSource = sortedData; // Використовуйте pharmacyBindingSource для таблиці Pharmacy
        }
        private string GetPharmacySortField()
        {
            if (radioButtonPharmacyID.Checked) return "pharmacy_id"; // Поле pharmacy_id для сортування
            if (radioButtonName.Checked) return "name"; // Поле name для сортування
            if (radioButtonLocation.Checked) return "location"; // Поле location для сортування
            if (radioButtonNumberOfEmployees.Checked) return "number_of_employees"; // Поле number_of_employees для сортування
            if (radioButtonSalesArea.Checked) return "sales_area"; // Поле sales_area для сортування
            return null;
        }
        private string GetSortDirection()
        {
            return radioButtonAscPharmacy.Checked ? "ASC" : "DESC"; // Перевірка на напрямок сортування
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
            // Calculate average, max, and min for the number of employees in pharmacies
            if (pharmacyBindingSource.Count > 0) // Замініть на ваше джерело даних для аптек
            {
                DataTable pharmacyTable = courseDataSet.Pharmacy; // Замініть на вашу таблицю

                decimal total = 0;
                decimal max = decimal.MinValue;
                decimal min = decimal.MaxValue;
                int count = 0;

                foreach (DataRow row in pharmacyTable.Rows)
                {
                    if (row["number_of_employees"] != DBNull.Value)
                    {
                        decimal numberOfEmployees = Convert.ToDecimal(row["number_of_employees"]);
                        total += numberOfEmployees;
                        count++;

                        if (numberOfEmployees > max)
                            max = numberOfEmployees;

                        if (numberOfEmployees < min)
                            min = numberOfEmployees;
                    }
                }

                decimal average = count > 0 ? total / count : 0;

                // Create a new DataTable for results
                DataTable resultsTable = new DataTable();
                resultsTable.Columns.Add("Середнє", typeof(decimal));
                resultsTable.Columns.Add("Максимум", typeof(decimal));
                resultsTable.Columns.Add("Мінімум", typeof(decimal));

                // Add a row with the calculated values
                resultsTable.Rows.Add(average, max, min);

                // Set the results table as the DataSource for dataGridView2
                dataGridViewPharmacy1.DataSource = resultsTable;
            }
            else
            {
                MessageBox.Show("Таблиця пуста.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minValueText = textBoxMinPharmacy.Text.Trim(); // Поле для мінімального значення
            string maxValueText = textBoxMaxPharmacy.Text.Trim(); // Поле для максимального значення
            string searchValueText = textBoxSearchValue.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Pharmacy] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minValue = 0;
            int maxValue = 0;
            decimal minSalesArea = 0;
            decimal maxSalesArea = 0;
            int minEmployees = 0;
            int maxEmployees = 0;

            // Параметри для умов пошуку
            bool hasConditions = false;

            // Перевірка наявності умов для pharmacy_id
            if (!string.IsNullOrEmpty(minValueText))
            {
                if (int.TryParse(minValueText, out minValue))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND pharmacy_id = @MinValue");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxValue))
                    {
                        queryBuilder.Append(" AND pharmacy_id BETWEEN @MinValue AND @MaxValue");
                        hasConditions = true;
                    }
                }
                else if (decimal.TryParse(minValueText, out minSalesArea))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND sales_area = @MinSalesArea");
                        hasConditions = true;
                    }
                    else if (decimal.TryParse(maxValueText, out maxSalesArea))
                    {
                        queryBuilder.Append(" AND sales_area BETWEEN @MinSalesArea AND @MaxSalesArea");
                        hasConditions = true;
                    }
                }
                else if (int.TryParse(minValueText, out minEmployees))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND number_of_employees = @MinEmployees");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxEmployees))
                    {
                        queryBuilder.Append(" AND number_of_employees BETWEEN @MinEmployees AND @MaxEmployees");
                        hasConditions = true;
                    }
                }
            }

            // Додаємо умови для пошуку текстових атрибутів
            if (!string.IsNullOrEmpty(searchValueText))
            {
                queryBuilder.Append(" AND (name LIKE @SearchValue OR location LIKE @SearchValue)");
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
                    if (int.TryParse(minValueText, out minValue))
                    {
                        command.Parameters.AddWithValue("@MinValue", minValue);
                    }

                    if (int.TryParse(maxValueText, out maxValue))
                    {
                        command.Parameters.AddWithValue("@MaxValue", maxValue);
                    }

                    if (decimal.TryParse(minValueText, out minSalesArea))
                    {
                        command.Parameters.AddWithValue("@MinSalesArea", minSalesArea);
                    }

                    if (decimal.TryParse(maxValueText, out maxSalesArea))
                    {
                        command.Parameters.AddWithValue("@MaxSalesArea", maxSalesArea);
                    }

                    if (int.TryParse(minValueText, out minEmployees))
                    {
                        command.Parameters.AddWithValue("@MinEmployees", minEmployees);
                    }

                    if (int.TryParse(maxValueText, out maxEmployees))
                    {
                        command.Parameters.AddWithValue("@MaxEmployees", maxEmployees);
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
                        dataGridViewPharmacy2.DataSource = resultsTable; // Замініть на ваше dataGridView для аптек
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання значень з текстових полів
            string minValueText = textBoxMinValue.Text.Trim();
            string maxValueText = textBoxMaxValue.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Pharmacy] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            
            decimal minSalesArea = 0;
            decimal maxSalesArea = 0;
            

            // Параметри для умов фільтрації
            bool hasConditions = false;

           

            // Перевірка наявності умов для sales_area
            if (!string.IsNullOrEmpty(minValueText) && decimal.TryParse(minValueText, out minSalesArea))
            {
                queryBuilder.Append(" AND sales_area >= @MinSalesArea");
                hasConditions = true;
            }
            if (!string.IsNullOrEmpty(maxValueText) && decimal.TryParse(maxValueText, out maxSalesArea))
            {
                queryBuilder.Append(" AND sales_area <= @MaxSalesArea");
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
                    
                    if (decimal.TryParse(minValueText, out minSalesArea))
                    {
                        command.Parameters.AddWithValue("@MinSalesArea", minSalesArea);
                    }
                    if (decimal.TryParse(maxValueText, out maxSalesArea))
                    {
                        command.Parameters.AddWithValue("@MaxSalesArea", maxSalesArea);
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
                        dataGridViewPharmacy1.DataSource = resultsTable; // Замініть на ваше dataGridView для аптек
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
            Pharmacy.pharmacy_id, 
            Pharmacy.name AS PharmacyName,
            Stock_Inventory.stock_id, 
            Stock_Inventory.product_id, 
            Stock_Inventory.quantity
        FROM 
            Pharmacy
        INNER JOIN 
            Stock_Inventory ON Pharmacy.pharmacy_id = Stock_Inventory.pharmacy_id";

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
                        dataGridViewPharmacy1.DataSource = resultsTable; // Замініть на ваше dataGridView
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
    }

}
