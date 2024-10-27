using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Course
{
    public partial class Order : Form
    {

        public Order()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.courseDataSet.Order);

        }

        private void btnSort_Click_Click(object sender, EventArgs e)
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

            var sortedData = SortDataTable(courseDataSet.Order, sortField, sortDirection);
            orderBindingSource.DataSource = sortedData;
        }

        private string GetSortField()
        {
            if (radioButtonID.Checked) return "order_id";
            if (radioButtonIDCustomer.Checked) return "customer_id";
            if (radioButtonOrderDate.Checked) return "order_date";
            if (radioButtonTotalAmount.Checked) return "total_amount";
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



        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            // Calculate average, max, and min for the ticket price
            if (orderBindingSource.Count > 0)
            {
                DataTable ordersTable = courseDataSet.Order;

                decimal total = 0;
                decimal max = decimal.MinValue;
                decimal min = decimal.MaxValue;
                int count = 0;

                foreach (DataRow row in ordersTable.Rows)
                {
                    if (row["total_amount"] != DBNull.Value)
                    {
                        decimal price = Convert.ToDecimal(row["total_amount"]);
                        total += price;
                        count++;

                        if (price > max)
                            max = price;

                        if (price < min)
                            min = price;
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
                dataGridView2.DataSource = resultsTable;
            }
            else
            {
                MessageBox.Show("Таблиця пуста.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private List<courseDataSet.OrderRow> filteredOrders;
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtMinValue.Text, out DateTime minValue) && DateTime.TryParse(txtMaxValue.Text, out DateTime maxValue))
            {
                filteredOrders = courseDataSet.Order
                    .Where(row => row.order_date >= minValue && row.order_date <= maxValue)
                    .ToList();

                if (filteredOrders.Any())
                {
                    dataGridView1.DataSource = filteredOrders;
                }
                else
                {
                    MessageBox.Show("Не знайдено жодного заказу за вказаними датами.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні дати для фільтрації.");
            }
        }

        private void btnJoinTables1_Click(object sender, EventArgs e)
        {
            // SQL-запит для вибору order_id та full_name
            string query = @"SELECT O.order_id, C.full_name 
                         FROM [Order] O
                         INNER JOIN Customer C ON O.customer_id = C.customer_id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable); // Заповнення DataTable результатами запиту
                    dataGridView2.DataSource = dataTable; // Відображення результатів у DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка виконання запиту: {ex.Message}");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minValueText = textBoxMinOrderId.Text.Trim();
            string maxValueText = textBoxMaxOrderId.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Order] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minOrderId = 0;
            int maxOrderId = 0;
            decimal minTotalAmount = 0;
            decimal maxTotalAmount = 0;
            DateTime orderDate;
            string status = null;
            string paymentMethod = null;

            // Перевірка наявності умов
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Пошук за payment_method
                paymentMethod = minValueText;
                queryBuilder.Append(" AND payment_method = @PaymentMethod");

                // Пошук за order_id
                if (int.TryParse(minValueText, out minOrderId))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        // Якщо maxValueText порожнє, шукаємо лише за minOrderId
                        queryBuilder.Append(" OR order_id = @MinOrderId");
                    }
                    else
                    {
                        // Якщо maxValueText заповнене, шукаємо в діапазоні
                        queryBuilder.Append(" OR order_id BETWEEN @MinOrderId AND @MaxOrderId");
                    }
                }
                // Пошук за total_amount
                else if (decimal.TryParse(minValueText, out minTotalAmount))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        // Якщо maxValueText порожнє, шукаємо лише за minTotalAmount
                        queryBuilder.Append(" OR total_amount = @MinTotalAmount");
                    }
                    else
                    {
                        // Якщо maxValueText заповнене, шукаємо в діапазоні
                        queryBuilder.Append(" OR total_amount BETWEEN @MinTotalAmount AND @MaxTotalAmount");
                    }
                }
                // Пошук за order_date
                else if (DateTime.TryParse(minValueText, out orderDate))
                {
                    queryBuilder.Append(" OR order_date = @OrderDate");
                }
                else
                {
                    // Пошук за status
                    status = minValueText;
                    queryBuilder.Append(" OR status = @Status");
                }
            }

            if (!string.IsNullOrEmpty(maxValueText))
            {
                // Додаємо умови для order_id
                if (int.TryParse(maxValueText, out maxOrderId))
                {
                    queryBuilder.Append(" OR order_id = @MaxOrderId");
                }
                // Додаємо умови для total_amount
                else if (decimal.TryParse(maxValueText, out maxTotalAmount))
                {
                    queryBuilder.Append(" OR total_amount = @MaxTotalAmount");
                }
                // Пошук за payment_method
                else
                {
                    paymentMethod = maxValueText;
                    queryBuilder.Append(" OR payment_method = @PaymentMethod");
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
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                if (!string.IsNullOrEmpty(minValueText))
                {
                    if (int.TryParse(minValueText, out minOrderId))
                    {
                        command.Parameters.AddWithValue("@MinOrderId", minOrderId);
                    }
                    else if (decimal.TryParse(minValueText, out minTotalAmount))
                    {
                        command.Parameters.AddWithValue("@MinTotalAmount", minTotalAmount);
                    }
                    else if (DateTime.TryParse(minValueText, out orderDate))
                    {
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Status", status);
                    }
                }

                if (!string.IsNullOrEmpty(maxValueText))
                {
                    if (int.TryParse(maxValueText, out maxOrderId))
                    {
                        command.Parameters.AddWithValue("@MaxOrderId", maxOrderId);
                    }
                    else if (decimal.TryParse(maxValueText, out maxTotalAmount))
                    {
                        command.Parameters.AddWithValue("@MaxTotalAmount", maxTotalAmount);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
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
                        dataGridView2.DataSource = resultsTable;
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




        ////private void txtMaxValue_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtMinValue_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void textBoxMinOrderId_TextChanged(object sender, EventArgs e)
        //{


        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBoxMaxOrderId_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }

}

