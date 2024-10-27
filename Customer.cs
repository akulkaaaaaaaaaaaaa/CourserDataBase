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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.courseDataSet.Customer);

        }

        private void btnSortCustomer_Click(object sender, EventArgs e)
        {
            SortData();
        }
        private void SortData()
        {
            string sortField = GetSortField();
            string sortDirection = GetSortDirection();

            if (string.IsNullOrEmpty(sortField))
            {
                MessageBox.Show("Виберіть поле для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Customer, sortField, sortDirection);
            customerBindingSource.DataSource = sortedData; // Змініть orderBindingSource на customerBindingSource
        }
        private string GetSortField()
        {
            if (radioButtonID.Checked) return "customer_id"; // Змінено на customer_id
            if (radioButtonFullName.Checked) return "full_name"; // Додайте поле full_name для сортування
            if (radioButtonContactInfo.Checked) return "contact_info"; // Додайте поле email для сортування
            if (radioButtonLoyatyCard.Checked) return "loyalty_card_number"; // Додайте поле phone для сортування
            return null;
        }
        private string GetSortDirection()
        {
            return radioButtonAscCustomer.Checked ? "ASC" : "DESC";
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
        private List<courseDataSet.CustomerRow> filteredOrders;
        private void btnFilterCustomer_Click(object sender, EventArgs e)
        {
            // Отримання введеного імені клієнта
            string fullNameInput = txtFullName.Text;

            if (!string.IsNullOrWhiteSpace(fullNameInput))
            {
                filteredOrders = courseDataSet.Customer
                    .Where(row => row.full_name.Contains(fullNameInput))
                    .ToList();

                if (filteredOrders.Any())
                {
                    dataGridViewCustomer1.DataSource = filteredOrders;
                }
                else
                {
                    MessageBox.Show("Не знайдено жодного клієнта за вказаним іменем.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне ім'я клієнта.");
            }
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minValueText = textBoxMinCustomerId.Text.Trim();
            string maxValueText = textBoxMaxCustomerId.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Customer WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minCustomerId;
            int maxCustomerId;
            string fullName = null;
            string contactInfo = null;
            string loyaltyCardNumber = null;

            // Перевірка умов у minValueText
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Якщо minValueText — число, використовується для діапазону customer_id
                if (int.TryParse(minValueText, out minCustomerId))
                {
                    queryBuilder.Append(" AND customer_id >= @MinCustomerId");
                }
                else
                {
                    // Використання інших атрибутів для пошуку, якщо minValueText не є числом
                    fullName = minValueText;
                    contactInfo = minValueText;
                    loyaltyCardNumber = minValueText;

                    queryBuilder.Append(" AND (full_name LIKE '%' + @FullName + '%' ");
                    queryBuilder.Append("OR contact_info LIKE '%' + @ContactInfo + '%' ");
                    queryBuilder.Append("OR loyalty_card_number LIKE '%' + @LoyaltyCardNumber + '%')");
                }
            }

            // Перевірка умов у maxValueText
            if (!string.IsNullOrEmpty(maxValueText) && int.TryParse(maxValueText, out maxCustomerId))
            {
                // Якщо maxValueText — число, використовуємо для верхньої межі customer_id
                queryBuilder.Append(" AND customer_id <= @MaxCustomerId");
            }

            // Виводимо сформований запит для налагодження
            string finalQuery = queryBuilder.ToString();
            Console.WriteLine(finalQuery);

            // Виконання запиту
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(finalQuery, connection);

                // Додаємо параметри для запиту
                if (!string.IsNullOrEmpty(minValueText))
                {
                    if (int.TryParse(minValueText, out minCustomerId))
                    {
                        command.Parameters.AddWithValue("@MinCustomerId", minCustomerId);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                        command.Parameters.AddWithValue("@LoyaltyCardNumber", loyaltyCardNumber);
                    }
                }

                if (!string.IsNullOrEmpty(maxValueText) && int.TryParse(maxValueText, out maxCustomerId))
                {
                    command.Parameters.AddWithValue("@MaxCustomerId", maxCustomerId);
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
                        dataGridViewCustomer.DataSource = resultsTable;
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


        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonJoinTables_Click(object sender, EventArgs e)
        {
            // SQL-запит для об’єднання таблиць Customer і Order
            string query = @"
        SELECT Customer.customer_id, Customer.full_name, Customer.contact_info, 
               [Order].order_id, [Order].order_date, [Order].total_amount
        FROM Customer
        INNER JOIN [Order] ON Customer.customer_id = [Order].customer_id";

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
                        dataGridViewCustomer1.DataSource = resultsTable;
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено жодних записів для об'єднання.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void groupBoxOrderCustomer_Enter(object sender, EventArgs e)
        {

        }
    }
}
