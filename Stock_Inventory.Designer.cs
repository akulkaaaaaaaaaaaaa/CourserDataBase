namespace Course
{
    partial class Stock_Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Inventory));
            this.courseDataSet = new Course.courseDataSet();
            this.stock_InventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_InventoryTableAdapter = new Course.courseDataSetTableAdapters.Stock_InventoryTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.stock_InventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stock_InventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stock_InventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.radioButtonStockID = new System.Windows.Forms.RadioButton();
            this.radioButtonPharmacyID = new System.Windows.Forms.RadioButton();
            this.radioButtonProductID = new System.Windows.Forms.RadioButton();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.btnSort_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMaxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxMinQuantity = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateReliabilityRating = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxQuantityRange = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxStockRange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryBindingNavigator)).BeginInit();
            this.stock_InventoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataGridView)).BeginInit();
            this.groupBoxField.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stock_InventoryBindingSource
            // 
            this.stock_InventoryBindingSource.DataMember = "Stock_Inventory";
            this.stock_InventoryBindingSource.DataSource = this.courseDataSet;
            // 
            // stock_InventoryTableAdapter
            // 
            this.stock_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Supplier_ProductTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Purchase_HistoryTableAdapter = null;
            this.tableAdapterManager.Sales_HistoryTableAdapter = null;
            this.tableAdapterManager.Stock_InventoryTableAdapter = this.stock_InventoryTableAdapter;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stock_InventoryBindingNavigator
            // 
            this.stock_InventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stock_InventoryBindingNavigator.BindingSource = this.stock_InventoryBindingSource;
            this.stock_InventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stock_InventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stock_InventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stock_InventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stock_InventoryBindingNavigatorSaveItem});
            this.stock_InventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stock_InventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stock_InventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stock_InventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stock_InventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stock_InventoryBindingNavigator.Name = "stock_InventoryBindingNavigator";
            this.stock_InventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stock_InventoryBindingNavigator.Size = new System.Drawing.Size(1285, 27);
            this.stock_InventoryBindingNavigator.TabIndex = 0;
            this.stock_InventoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // stock_InventoryBindingNavigatorSaveItem
            // 
            this.stock_InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stock_InventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stock_InventoryBindingNavigatorSaveItem.Image")));
            this.stock_InventoryBindingNavigatorSaveItem.Name = "stock_InventoryBindingNavigatorSaveItem";
            this.stock_InventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.stock_InventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.stock_InventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.stock_InventoryBindingNavigatorSaveItem_Click);
            // 
            // stock_InventoryDataGridView
            // 
            this.stock_InventoryDataGridView.AutoGenerateColumns = false;
            this.stock_InventoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.stock_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_InventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.stock_InventoryDataGridView.DataSource = this.stock_InventoryBindingSource;
            this.stock_InventoryDataGridView.Location = new System.Drawing.Point(0, 30);
            this.stock_InventoryDataGridView.Name = "stock_InventoryDataGridView";
            this.stock_InventoryDataGridView.RowHeadersWidth = 51;
            this.stock_InventoryDataGridView.RowTemplate.Height = 24;
            this.stock_InventoryDataGridView.Size = new System.Drawing.Size(630, 154);
            this.stock_InventoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stock_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "stock_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pharmacy_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "pharmacy_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // groupBoxField
            // 
            this.groupBoxField.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxField.Controls.Add(this.radioButtonStockID);
            this.groupBoxField.Controls.Add(this.radioButtonPharmacyID);
            this.groupBoxField.Controls.Add(this.radioButtonProductID);
            this.groupBoxField.Controls.Add(this.radioButtonQuantity);
            this.groupBoxField.Location = new System.Drawing.Point(18, 212);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.Size = new System.Drawing.Size(200, 150);
            this.groupBoxField.TabIndex = 67;
            this.groupBoxField.TabStop = false;
            this.groupBoxField.Text = "Вибір для сортування";
            // 
            // radioButtonStockID
            // 
            this.radioButtonStockID.AutoSize = true;
            this.radioButtonStockID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonStockID.Name = "radioButtonStockID";
            this.radioButtonStockID.Size = new System.Drawing.Size(91, 20);
            this.radioButtonStockID.TabIndex = 2;
            this.radioButtonStockID.TabStop = true;
            this.radioButtonStockID.Text = "ID запасу";
            this.radioButtonStockID.UseVisualStyleBackColor = true;
            // 
            // radioButtonPharmacyID
            // 
            this.radioButtonPharmacyID.AutoSize = true;
            this.radioButtonPharmacyID.Location = new System.Drawing.Point(6, 47);
            this.radioButtonPharmacyID.Name = "radioButtonPharmacyID";
            this.radioButtonPharmacyID.Size = new System.Drawing.Size(90, 20);
            this.radioButtonPharmacyID.TabIndex = 3;
            this.radioButtonPharmacyID.TabStop = true;
            this.radioButtonPharmacyID.Text = "ID аптеки";
            this.radioButtonPharmacyID.UseVisualStyleBackColor = true;
            // 
            // radioButtonProductID
            // 
            this.radioButtonProductID.AutoSize = true;
            this.radioButtonProductID.Location = new System.Drawing.Point(6, 73);
            this.radioButtonProductID.Name = "radioButtonProductID";
            this.radioButtonProductID.Size = new System.Drawing.Size(106, 20);
            this.radioButtonProductID.TabIndex = 4;
            this.radioButtonProductID.TabStop = true;
            this.radioButtonProductID.Text = "ID продукту";
            this.radioButtonProductID.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Location = new System.Drawing.Point(6, 99);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(85, 20);
            this.radioButtonQuantity.TabIndex = 5;
            this.radioButtonQuantity.TabStop = true;
            this.radioButtonQuantity.Text = "Кількість";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOrder.Controls.Add(this.radioButtonAsc);
            this.groupBoxOrder.Controls.Add(this.radioButtonDesc);
            this.groupBoxOrder.Location = new System.Drawing.Point(252, 212);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(200, 150);
            this.groupBoxOrder.TabIndex = 66;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Порядок сортування";
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(121, 20);
            this.radioButtonAsc.TabIndex = 6;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "По зростанню";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(6, 57);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDesc.TabIndex = 7;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "По спаданню";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // btnSort_Click
            // 
            this.btnSort_Click.Location = new System.Drawing.Point(156, 390);
            this.btnSort_Click.Name = "btnSort_Click";
            this.btnSort_Click.Size = new System.Drawing.Size(153, 50);
            this.btnSort_Click.TabIndex = 65;
            this.btnSort_Click.Text = "Сортувати";
            this.btnSort_Click.UseVisualStyleBackColor = true;
            this.btnSort_Click.Click += new System.EventHandler(this.btnSort_Click_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(663, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 78;
            this.button2.Text = "Показати Запаси";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMaxQuantity
            // 
            this.textBoxMaxQuantity.Location = new System.Drawing.Point(749, 30);
            this.textBoxMaxQuantity.Name = "textBoxMaxQuantity";
            this.textBoxMaxQuantity.Size = new System.Drawing.Size(78, 22);
            this.textBoxMaxQuantity.TabIndex = 77;
            // 
            // textBoxMinQuantity
            // 
            this.textBoxMinQuantity.Location = new System.Drawing.Point(648, 30);
            this.textBoxMinQuantity.Name = "textBoxMinQuantity";
            this.textBoxMinQuantity.Size = new System.Drawing.Size(83, 22);
            this.textBoxMinQuantity.TabIndex = 76;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFilter.Location = new System.Drawing.Point(663, 66);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(152, 57);
            this.buttonFilter.TabIndex = 75;
            this.buttonFilter.Text = "Фільтрація площини аптеки";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(495, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Введіть через кому мін і макс число для ID";
            // 
            // btnCalculateReliabilityRating
            // 
            this.btnCalculateReliabilityRating.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalculateReliabilityRating.Location = new System.Drawing.Point(663, 129);
            this.btnCalculateReliabilityRating.Name = "btnCalculateReliabilityRating";
            this.btnCalculateReliabilityRating.Size = new System.Drawing.Size(152, 57);
            this.btnCalculateReliabilityRating.TabIndex = 72;
            this.btnCalculateReliabilityRating.Text = "Обчислення кількості запасів";
            this.btnCalculateReliabilityRating.UseVisualStyleBackColor = false;
            this.btnCalculateReliabilityRating.Click += new System.EventHandler(this.btnCalculateReliabilityRating_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(843, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 238);
            this.dataGridView1.TabIndex = 71;
            // 
            // textBoxQuantityRange
            // 
            this.textBoxQuantityRange.Location = new System.Drawing.Point(557, 340);
            this.textBoxQuantityRange.Name = "textBoxQuantityRange";
            this.textBoxQuantityRange.Size = new System.Drawing.Size(164, 22);
            this.textBoxQuantityRange.TabIndex = 70;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(557, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 48);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.Text = "Пошук за умовою";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(843, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(442, 216);
            this.dataGridView2.TabIndex = 68;
            // 
            // textBoxStockRange
            // 
            this.textBoxStockRange.Location = new System.Drawing.Point(557, 292);
            this.textBoxStockRange.Name = "textBoxStockRange";
            this.textBoxStockRange.Size = new System.Drawing.Size(164, 22);
            this.textBoxStockRange.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(458, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Введіть через кому мін і макс число для кількості запасів";
            // 
            // Stock_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1285, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStockRange);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMaxQuantity);
            this.Controls.Add(this.textBoxMinQuantity);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateReliabilityRating);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxQuantityRange);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBoxField);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.btnSort_Click);
            this.Controls.Add(this.stock_InventoryDataGridView);
            this.Controls.Add(this.stock_InventoryBindingNavigator);
            this.Name = "Stock_Inventory";
            this.Text = "Stock_Inventory";
            this.Load += new System.EventHandler(this.Stock_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryBindingNavigator)).EndInit();
            this.stock_InventoryBindingNavigator.ResumeLayout(false);
            this.stock_InventoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataGridView)).EndInit();
            this.groupBoxField.ResumeLayout(false);
            this.groupBoxField.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource stock_InventoryBindingSource;
        private courseDataSetTableAdapters.Stock_InventoryTableAdapter stock_InventoryTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stock_InventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stock_InventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stock_InventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.RadioButton radioButtonStockID;
        private System.Windows.Forms.RadioButton radioButtonPharmacyID;
        private System.Windows.Forms.RadioButton radioButtonProductID;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.Button btnSort_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMaxQuantity;
        private System.Windows.Forms.TextBox textBoxMinQuantity;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateReliabilityRating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxQuantityRange;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxStockRange;
        private System.Windows.Forms.Label label2;
    }
}