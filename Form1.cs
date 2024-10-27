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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;"; // Вставте ваш рядок підключення
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.courseDataSet.Order);
            // TODO: This line of code loads data into the 'courseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.courseDataSet.Customer);

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            string pharmacyId = textBoxPharmacyId.Text;

            // Перевіряємо, чи введено значення ID аптеки
            if (int.TryParse(pharmacyId, out int id))
            {
                string query = "SELECT ph.name AS PharmacyName, p.name AS ProductName, si.quantity " +
                               "FROM Stock_Inventory si " +
                               "JOIN Product p ON si.product_id = p.product_id " +
                               "JOIN Pharmacy ph ON si.pharmacy_id = ph.pharmacy_id " +
                               "WHERE si.pharmacy_id = @pharmacyId;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@pharmacyId", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищаємо попередні результати перед новим запитом
                    listBoxResults.Items.Clear();

                    while (reader.Read())
                    {
                        string pharmacyName = reader["PharmacyName"].ToString();
                        string productName = reader["ProductName"].ToString();
                        string quantity = reader["quantity"].ToString();

                        string result = $"Аптека: {pharmacyName}, Товар: {productName}, Кількість: {quantity}";
                        listBoxResults.Items.Add(result);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильний ID аптеки.");
            }
        }

        private void buttonCheckExpiration_Click(object sender, EventArgs e)
        {
            // Отримуємо ID товару з TextBox
            string productID = textBoxProductID.Text;

            // Перевіряємо, чи введений ID товару
            if (string.IsNullOrWhiteSpace(productID))
            {
                MessageBox.Show("Будь ласка, введіть ID товару.");
                return;
            }

            // SQL-запит для вибору товару за введеним ID і його терміну придатності
            string query = "SELECT name, expiration_date FROM Product WHERE product_id = @ProductID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Очищаємо попередні результати перед новим запитом
                listBoxResults.Items.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string productName = reader["name"].ToString();
                        DateTime expirationDate = (DateTime)reader["expiration_date"];
                        string productInfo = $"{productName}, Термін придатності: {expirationDate.ToShortDateString()}";
                        listBoxResults.Items.Add(productInfo);
                    }
                }
                else
                {
                    listBoxResults.Items.Add("Товар з таким ID не знайдено.");
                }
            }
        }

        private void buttonCheckPendingOrders_Click(object sender, EventArgs e)
        {
            // SQL-запит для вибору незавершених замовлень з інформацією про клієнтів
            string query = @"
        SELECT 
            o.[order_id], 
            o.[customer_id], 
            c.[full_name], 
            o.[status] 
        FROM 
            [Order] o
        JOIN 
            [Customer] c ON o.[customer_id] = c.[customer_id] 
        WHERE 
            o.[status] IN ('В обробці', 'Скасоване');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Очищаємо попередні результати перед новим запитом
                listBoxResults.Items.Clear();

                while (reader.Read())
                {
                    string orderId = reader["order_id"].ToString();
                    string customerName = reader["customer_id"].ToString();
                    string fullName = reader["full_name"].ToString(); // Отримуємо повне ім'я з таблиці Customer
                    string status = reader["status"].ToString();
                    string orderInfo = $"Замовлення ID: {orderId}, Клієнт: {customerName}, Повне ім'я: {fullName}, Статус: {status}";
                    listBoxResults.Items.Add(orderInfo);
                }

                // Якщо не знайдено жодного замовлення, можна додати повідомлення
                if (listBoxResults.Items.Count == 0)
                {
                    listBoxResults.Items.Add("Не знайдено незавершених замовлень.");
                }
            }
        }

        private void buttonCountEmployees_Click(object sender, EventArgs e)
        {
            // SQL-запит для підрахунку кількості співробітників у кожній аптеці
            string query = @"
        SELECT 
            p.name AS PharmacyName,
            COUNT(e.employee_id) AS EmployeeCount
        FROM 
            Pharmacy p
        LEFT JOIN 
            Employee e ON p.pharmacy_id = e.pharmacy_id
        GROUP BY 
            p.name;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Відображення даних у DataGridView
                    dataGridViewSales.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка: " + ex.Message);
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowSales_Click(object sender, EventArgs e)
        {
            // Отримання вибраних дат із DateTimePicker
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            // SQL-запит для підрахунку загальної кількості проданих товарів за певний період
            string query = @"
        SELECT 
            p.name AS ProductName,
            SUM(sh.quantity) AS TotalQuantitySold
        FROM 
            Sales_History sh
        JOIN 
            Product p ON sh.product_id = p.product_id
        WHERE 
            sh.sale_date BETWEEN @StartDate AND @EndDate
        GROUP BY 
            p.name;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Відображення даних у DataGridView
                    dataGridViewSales.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка: " + ex.Message);
                }
            }
        }


        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_History purchase_History = new Purchase_History();
            purchase_History.Show();
        }

        private void stockInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Inventory stock_Inventory = new Stock_Inventory();
            stock_Inventory.Show();
        }

        private void pharmacySupplierProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pharmacy_Supplier_Product pharmacy_Supplier_ = new Pharmacy_Supplier_Product();
            pharmacy_Supplier_.Show();
        }

        private void pharmacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Show();
        }

        private void salesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_History sales_History = new Sales_History();
            sales_History.Show();
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
