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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=AKULA\\MSSQLSERVER1;Initial Catalog=course;Integrated Security=True;";
        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDataSet);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.courseDataSet.Product);

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

            if (courseDataSet.Product.Rows.Count == 0)
            {
                MessageBox.Show("Немає доступних даних для сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortedData = SortDataTable(courseDataSet.Product, sortField, sortDirection);

            productBindingSource.DataSource = null; // Скидаємо джерело даних
            productBindingSource.DataSource = sortedData; // Призначаємо нові дані
        }

        private string GetSortField()
        {
            if (radioButtonProductID.Checked) return "product_id";
            if (radioButtonName.Checked) return "name";
            if (radioButtonDescription.Checked) return "description";
            if (radioButtonPrice.Checked) return "price";
            if (radioButtonCategory.Checked) return "category";
            if (radioButtonManufacturer.Checked) return "manufacturer";
            if (radioButtonStockQuantity.Checked) return "stock_quantity";
            if (radioButtonExpirationDate.Checked) return "expiration_date";
            return null;
        }

        private string GetSortDirection()
        {
            return radioButtonProductAsc.Checked ? "ASC" : "DESC";
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
                // Calculate average, max, and min for the ticket price
                if (productBindingSource.Count > 0)
                {
                    DataTable productsTable = courseDataSet.Product;

                    decimal total = 0;
                    decimal max = decimal.MinValue;
                    decimal min = decimal.MaxValue;
                    int count = 0;

                    foreach (DataRow row in productsTable.Rows)
                    {
                        if (row["price"] != DBNull.Value)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
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
                    dataGridViewProduct2.DataSource = resultsTable;
                }
                else
                {
                    MessageBox.Show("Таблиця пуста.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }


        private void btnFilterProduct_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date; // Отримуємо початкову дату
            DateTime endDate = dateTimePickerEnd.Value.Date; // Отримуємо кінцеву дату

            if (endDate < startDate)
            {
                MessageBox.Show("Кінцева дата не може бути меншою за початкову дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримуємо таблицю продуктів
            DataTable productsTable = courseDataSet.Product; // Припустимо, що у вас є DataTable для продуктів
           
            // Фільтруємо дані
            var filteredRows = productsTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("expiration_date") >= startDate && row.Field<DateTime>("expiration_date") <= endDate)
                .CopyToDataTable(); // Копіюємо відфільтровані рядки в нову DataTable

            // Перевіряємо, чи є відфільтровані дані
            if (filteredRows.Rows.Count > 0)
            {
                productBindingSource.DataSource = filteredRows; // Встановлюємо нову таблицю як DataSource
                dataGridViewProduct1.DataSource = productBindingSource; // Встановлюємо dataGridViewProduct1 як джерело даних
            }
            else
            {
                MessageBox.Show("Немає продуктів у вказаному діапазоні дат.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productBindingSource.DataSource = null; // Очищуємо DataSource
                dataGridViewProduct1.DataSource = null; // Очищуємо dataGridViewProduct1
            }
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Отримання умов пошуку з текстових полів
            string minValueText = textBoxMinProduct.Text.Trim();
            string maxValueText = textBoxMaxProduct.Text.Trim();

            // Формування базового SQL-запиту
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [Product] WHERE 1=1");

            // Змінні для зберігання перетворених значень
            int minProductId = 0;
            int maxProductId = 0;
            decimal minPrice = 0;
            decimal maxPrice = 0;
            int minStockQuantity = 0;
            int maxStockQuantity = 0;
            DateTime expirationDate;

            // Параметри для умов пошуку
            bool hasConditions = false;

            // Перевірка наявності умов
            if (!string.IsNullOrEmpty(minValueText))
            {
                // Пошук за product_id
                if (int.TryParse(minValueText, out minProductId))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND product_id = @MinProductId");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxProductId))
                    {
                        queryBuilder.Append(" AND product_id BETWEEN @MinProductId AND @MaxProductId");
                        hasConditions = true;
                    }
                }
                // Пошук за price
                else if (decimal.TryParse(minValueText, out minPrice))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND price = @MinPrice");
                        hasConditions = true;
                    }
                    else if (decimal.TryParse(maxValueText, out maxPrice))
                    {
                        queryBuilder.Append(" AND price BETWEEN @MinPrice AND @MaxPrice");
                        hasConditions = true;
                    }
                }
                // Пошук за stock_quantity
                else if (int.TryParse(minValueText, out minStockQuantity))
                {
                    if (string.IsNullOrEmpty(maxValueText))
                    {
                        queryBuilder.Append(" AND stock_quantity = @MinStockQuantity");
                        hasConditions = true;
                    }
                    else if (int.TryParse(maxValueText, out maxStockQuantity))
                    {
                        queryBuilder.Append(" AND stock_quantity BETWEEN @MinStockQuantity AND @MaxStockQuantity");
                        hasConditions = true;
                    }
                }
                // Пошук за expiration_date
                else if (DateTime.TryParse(minValueText, out expirationDate))
                {
                    queryBuilder.Append(" AND expiration_date = @ExpirationDate");
                    hasConditions = true;
                }
                else
                {
                    // Пошук за символьними атрибутами (name, description, category, manufacturer)
                    queryBuilder.Append(" AND (name LIKE @SearchValue OR description LIKE @SearchValue OR category LIKE @SearchValue OR manufacturer LIKE @SearchValue)");
                    hasConditions = true;
                }
            }

            // Якщо maxValueText не порожнє, додаємо умови для нього
            if (!string.IsNullOrEmpty(maxValueText))
            {
                // Додаємо умови для product_id
                if (int.TryParse(maxValueText, out maxProductId))
                {
                    queryBuilder.Append(" OR product_id = @MaxProductId");
                }
                // Додаємо умови для price
                else if (decimal.TryParse(maxValueText, out maxPrice))
                {
                    queryBuilder.Append(" OR price = @MaxPrice");
                }
                // Додаємо умови для stock_quantity
                else if (int.TryParse(maxValueText, out maxStockQuantity))
                {
                    queryBuilder.Append(" OR stock_quantity = @MaxStockQuantity");
                }
                // Додаємо умови для expiration_date
                else if (DateTime.TryParse(maxValueText, out expirationDate))
                {
                    queryBuilder.Append(" OR expiration_date = @MaxExpirationDate");
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
                    if (int.TryParse(minValueText, out minProductId))
                    {
                        command.Parameters.AddWithValue("@MinProductId", minProductId);
                    }

                    if (int.TryParse(maxValueText, out maxProductId))
                    {
                        command.Parameters.AddWithValue("@MaxProductId", maxProductId);
                    }

                    if (decimal.TryParse(minValueText, out minPrice))
                    {
                        command.Parameters.AddWithValue("@MinPrice", minPrice);
                    }

                    if (decimal.TryParse(maxValueText, out maxPrice))
                    {
                        command.Parameters.AddWithValue("@MaxPrice", maxPrice);
                    }

                    if (int.TryParse(minValueText, out minStockQuantity))
                    {
                        command.Parameters.AddWithValue("@MinStockQuantity", minStockQuantity);
                    }

                    if (int.TryParse(maxValueText, out maxStockQuantity))
                    {
                        command.Parameters.AddWithValue("@MaxStockQuantity", maxStockQuantity);
                    }

                    if (DateTime.TryParse(minValueText, out expirationDate))
                    {
                        command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
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

                    // Відображення результатів у dataGridView
                    if (resultsTable.Rows.Count > 0)
                    {
                        dataGridViewProduct2.DataSource = resultsTable;
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
            string query = @"
        SELECT Product.product_id, Product.name, Product.price, Sales_History.sale_date, Sales_History.quantity
        FROM Product
        INNER JOIN Sales_History ON Product.product_id = Sales_History.product_id";
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
                        dataGridViewProduct2.DataSource = resultsTable;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            Product.product_id, 
            Product.name, 
            Product.price, 
            Stock_Inventory.stock_id, 
            Stock_Inventory.pharmacy_id, 
            Stock_Inventory.quantity
        FROM 
            Product
        INNER JOIN 
            Stock_Inventory ON Product.product_id = Stock_Inventory.product_id";

            ExecuteJoinQuery(query);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            Product.product_id, 
            Product.name, 
            Product.price, 
            Pharmacy_Supplier_Product.pharmacy_id, 
            Pharmacy_Supplier_Product.supplier_id
        FROM 
            Product
        INNER JOIN 
            Pharmacy_Supplier_Product ON Product.product_id = Pharmacy_Supplier_Product.product_id";

            ExecuteJoinQuery(query);
        }
    }
}
