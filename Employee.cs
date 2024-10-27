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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.courseDataSet.Employee);

        }

        private void SortEmployeeData()
        {
            string sortField = GetEmployeeSortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Employee, sortField, sortDirection);
            employeeBindingSource.DataSource = sortedData; // Використовуйте employeeBindingSource для таблиці Employee
        }

        private string GetEmployeeSortField()
        {
            if (radioButtonEmployeeID.Checked) return "employee_id"; // Поле employee_id для сортування
            if (radioButtonFullName.Checked) return "pharmacy_id"; // Поле pharmacy_id для сортування
            if (radioButtonFullName.Checked) return "full_name"; // Поле full_name для сортування
            if (radioButtonPosition.Checked) return "position"; // Поле position для сортування
            if (radioButtonSalary.Checked) return "salary"; // Поле salary для сортування
            if (radioButtonContactInfo.Checked) return "contact_info"; // Поле contact_info для сортування
            return null;
        }

        private string GetSortDirection()
        {
            return radioButtonAscEmployee.Checked ? "ASC" : "DESC";
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

       
        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            SortEmployeeData();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataTable employeeTable = courseDataSet.Employee;

            if (employeeTable.Rows.Count == 0)
            {
                MessageBox.Show("Таблиця співробітників пуста.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var salaries = employeeTable.AsEnumerable()
                .Select(row => row.Field<decimal>("salary"))
                .ToList();

            decimal maxSalary = salaries.Max();
            decimal minSalary = salaries.Min();
            decimal averageSalary = salaries.Average();

            string message = $"Максимальна зарплата: {maxSalary}\n" +
                             $"Мінімальна зарплата: {minSalary}\n" +
                             $"Середня зарплата: {averageSalary:F2}";

            MessageBox.Show(message, "Статистика зарплат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minValueText = textBoxMinEmployee.Text.Trim();
            string maxValueText = textBoxMaxEmployee.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Employee] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minEmployeeId = 0;
            int maxEmployeeId = 0;
            decimal minSalary = 0;
            decimal maxSalary = 0;

            // Параметри для умов пошуку
            bool hasConditions = false;

            // Перевірка наявності умов
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Пошук за employee_id
                if (int.TryParse(minValueText, out minEmployeeId))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND employee_id = @MinEmployeeId");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxEmployeeId))
                    {
                        queryBuilder.Append(" AND employee_id BETWEEN @MinEmployeeId AND @MaxEmployeeId");
                        hasConditions = true;
                    }
                }
                // Пошук за salary
                else if (decimal.TryParse(minValueText, out minSalary))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND salary = @MinSalary");
                        hasConditions = true;
                    }
                    else if (decimal.TryParse(maxValueText, out maxSalary))
                    {
                        queryBuilder.Append(" AND salary BETWEEN @MinSalary AND @MaxSalary");
                        hasConditions = true;
                    }
                }
                // Пошук за символьними атрибутами (full_name, position, contact_info)
                else
                {
                    queryBuilder.Append(" AND (full_name LIKE @SearchValue OR position LIKE @SearchValue OR contact_info LIKE @SearchValue)");
                    hasConditions = true;
                }
            }

            // Якщо maxValueText не порожнє, додаємо умови для нього
            if (!string.IsNullOrEmpty(maxValueText))
            {
                // Додаємо умови для employee_id
                if (int.TryParse(maxValueText, out maxEmployeeId))
                {
                    queryBuilder.Append(" OR employee_id = @MaxEmployeeId");
                }
                // Додаємо умови для salary
                else if (decimal.TryParse(maxValueText, out maxSalary))
                {
                    queryBuilder.Append(" OR salary = @MaxSalary");
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
                    if (int.TryParse(minValueText, out minEmployeeId))
                    {
                        command.Parameters.AddWithValue("@MinEmployeeId", minEmployeeId);
                    }

                    if (int.TryParse(maxValueText, out maxEmployeeId))
                    {
                        command.Parameters.AddWithValue("@MaxEmployeeId", maxEmployeeId);
                    }

                    if (decimal.TryParse(minValueText, out minSalary))
                    {
                        command.Parameters.AddWithValue("@MinSalary", minSalary);
                    }

                    if (decimal.TryParse(maxValueText, out maxSalary))
                    {
                        command.Parameters.AddWithValue("@MaxSalary", maxSalary);
                    }

                    // Для символьних атрибутів
                    string searchValue = $"%{minValueText}%";
                    command.Parameters.AddWithValue("@SearchValue", searchValue);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridViewEmployee2
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridViewEmployee2.DataSource = resultsTable;
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
            // SQL-запит для отримання списку співробітників з прив'язаними аптеками
            string query = @"SELECT E.full_name AS [Співробітник], P.name AS [Аптека]
                     FROM Employee E
                     INNER JOIN Pharmacy P ON E.pharmacy_id = P.pharmacy_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridViewProduct2
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridViewEmployee2.DataSource = resultsTable;
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено жодного запису для об'єднання співробітників з аптеками.",
                                        "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilterByPosition_Click(object sender, EventArgs e)
        {
            // Отримання значення для фільтрації
            string position = textBoxPositionFilter.Text.Trim(); // поле для введення посади

            // Перевірка, чи введена посада
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Будь ласка, введіть посаду для фільтрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL-запит для фільтрації за позицією
            string query = "SELECT * FROM Employee WHERE position LIKE @Position";

            // Виконання запиту
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Додаємо параметр для запобігання SQL-ін’єкціям
                command.Parameters.AddWithValue("@Position", "%" + position + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(resultsTable);

                    // Відображення результатів у dataGridViewProduct2
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridViewEmployee1.DataSource = resultsTable;
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено записів для вказаної посади.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
