namespace Course
{
    partial class Sales_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_History));
            this.courseDataSet = new Course.courseDataSet();
            this.sales_HistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_HistoryTableAdapter = new Course.courseDataSetTableAdapters.Sales_HistoryTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.sales_HistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sales_HistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sales_HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.radioButtonSalesId = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderId = new System.Windows.Forms.RadioButton();
            this.radioButtonProductId = new System.Windows.Forms.RadioButton();
            this.radioButtonSaleDate = new System.Windows.Forms.RadioButton();
            this.btnSort_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnJoinTables1 = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryBindingNavigator)).BeginInit();
            this.sales_HistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryDataGridView)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_HistoryBindingSource
            // 
            this.sales_HistoryBindingSource.DataMember = "Sales_History";
            this.sales_HistoryBindingSource.DataSource = this.courseDataSet;
            // 
            // sales_HistoryTableAdapter
            // 
            this.sales_HistoryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Sales_HistoryTableAdapter = this.sales_HistoryTableAdapter;
            this.tableAdapterManager.Stock_InventoryTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sales_HistoryBindingNavigator
            // 
            this.sales_HistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sales_HistoryBindingNavigator.BindingSource = this.sales_HistoryBindingSource;
            this.sales_HistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sales_HistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sales_HistoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sales_HistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sales_HistoryBindingNavigatorSaveItem});
            this.sales_HistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sales_HistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sales_HistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sales_HistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sales_HistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sales_HistoryBindingNavigator.Name = "sales_HistoryBindingNavigator";
            this.sales_HistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sales_HistoryBindingNavigator.Size = new System.Drawing.Size(1341, 27);
            this.sales_HistoryBindingNavigator.TabIndex = 0;
            this.sales_HistoryBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sales_HistoryBindingNavigatorSaveItem
            // 
            this.sales_HistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sales_HistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sales_HistoryBindingNavigatorSaveItem.Image")));
            this.sales_HistoryBindingNavigatorSaveItem.Name = "sales_HistoryBindingNavigatorSaveItem";
            this.sales_HistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sales_HistoryBindingNavigatorSaveItem.Text = "Save Data";
            this.sales_HistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.sales_HistoryBindingNavigatorSaveItem_Click);
            // 
            // sales_HistoryDataGridView
            // 
            this.sales_HistoryDataGridView.AutoGenerateColumns = false;
            this.sales_HistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sales_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_HistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sales_HistoryDataGridView.DataSource = this.sales_HistoryBindingSource;
            this.sales_HistoryDataGridView.Location = new System.Drawing.Point(12, 30);
            this.sales_HistoryDataGridView.Name = "sales_HistoryDataGridView";
            this.sales_HistoryDataGridView.RowHeadersWidth = 51;
            this.sales_HistoryDataGridView.RowTemplate.Height = 24;
            this.sales_HistoryDataGridView.Size = new System.Drawing.Size(619, 132);
            this.sales_HistoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sales_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "sales_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "order_id";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sale_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "sale_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOrder.Controls.Add(this.radioButtonAsc);
            this.groupBoxOrder.Controls.Add(this.radioButtonDesc);
            this.groupBoxOrder.Location = new System.Drawing.Point(310, 196);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(200, 150);
            this.groupBoxOrder.TabIndex = 16;
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
            this.radioButtonDesc.Location = new System.Drawing.Point(6, 52);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDesc.TabIndex = 7;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "По спаданню";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // groupBoxField
            // 
            this.groupBoxField.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxField.Controls.Add(this.radioButtonQuantity);
            this.groupBoxField.Controls.Add(this.radioButtonSalesId);
            this.groupBoxField.Controls.Add(this.radioButtonOrderId);
            this.groupBoxField.Controls.Add(this.radioButtonProductId);
            this.groupBoxField.Controls.Add(this.radioButtonSaleDate);
            this.groupBoxField.Location = new System.Drawing.Point(23, 196);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.Size = new System.Drawing.Size(200, 169);
            this.groupBoxField.TabIndex = 15;
            this.groupBoxField.TabStop = false;
            this.groupBoxField.Text = "Вибір для сортування";
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Location = new System.Drawing.Point(6, 125);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(173, 20);
            this.radioButtonQuantity.TabIndex = 6;
            this.radioButtonQuantity.TabStop = true;
            this.radioButtonQuantity.Text = "Контактна інформація";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalesId
            // 
            this.radioButtonSalesId.AutoSize = true;
            this.radioButtonSalesId.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSalesId.Name = "radioButtonSalesId";
            this.radioButtonSalesId.Size = new System.Drawing.Size(137, 20);
            this.radioButtonSalesId.TabIndex = 2;
            this.radioButtonSalesId.TabStop = true;
            this.radioButtonSalesId.Text = "ID Співробітника";
            this.radioButtonSalesId.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderId
            // 
            this.radioButtonOrderId.AutoSize = true;
            this.radioButtonOrderId.Location = new System.Drawing.Point(6, 47);
            this.radioButtonOrderId.Name = "radioButtonOrderId";
            this.radioButtonOrderId.Size = new System.Drawing.Size(91, 20);
            this.radioButtonOrderId.TabIndex = 3;
            this.radioButtonOrderId.TabStop = true;
            this.radioButtonOrderId.Text = "ID Аптеки";
            this.radioButtonOrderId.UseVisualStyleBackColor = true;
            // 
            // radioButtonProductId
            // 
            this.radioButtonProductId.AutoSize = true;
            this.radioButtonProductId.Location = new System.Drawing.Point(6, 73);
            this.radioButtonProductId.Name = "radioButtonProductId";
            this.radioButtonProductId.Size = new System.Drawing.Size(95, 20);
            this.radioButtonProductId.TabIndex = 4;
            this.radioButtonProductId.TabStop = true;
            this.radioButtonProductId.Text = "Повне ім\'я";
            this.radioButtonProductId.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaleDate
            // 
            this.radioButtonSaleDate.AutoSize = true;
            this.radioButtonSaleDate.Location = new System.Drawing.Point(6, 99);
            this.radioButtonSaleDate.Name = "radioButtonSaleDate";
            this.radioButtonSaleDate.Size = new System.Drawing.Size(92, 20);
            this.radioButtonSaleDate.TabIndex = 5;
            this.radioButtonSaleDate.TabStop = true;
            this.radioButtonSaleDate.Text = "Зарплата";
            this.radioButtonSaleDate.UseVisualStyleBackColor = true;
            // 
            // btnSort_Click
            // 
            this.btnSort_Click.Location = new System.Drawing.Point(216, 388);
            this.btnSort_Click.Name = "btnSort_Click";
            this.btnSort_Click.Size = new System.Drawing.Size(153, 50);
            this.btnSort_Click.TabIndex = 14;
            this.btnSort_Click.Text = "Сортувати";
            this.btnSort_Click.UseVisualStyleBackColor = true;
            this.btnSort_Click.Click += new System.EventHandler(this.btnSort_Click_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(814, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 154);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(637, 74);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(152, 22);
            this.txtMaxValue.TabIndex = 19;
            this.txtMaxValue.TextChanged += new System.EventHandler(this.txtMaxValue_TextChanged);
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(637, 34);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(152, 22);
            this.txtMinValue.TabIndex = 18;
            this.txtMinValue.TextChanged += new System.EventHandler(this.txtMinValue_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(637, 112);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(152, 54);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Фільтрувати продажі за датою";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(609, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Для чисел за діапазоном";
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(621, 316);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(143, 22);
            this.textBoxMaxValue.TabIndex = 51;
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(621, 269);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(143, 22);
            this.textBoxMinValue.TabIndex = 50;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(612, 355);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 48);
            this.buttonSearch.TabIndex = 49;
            this.buttonSearch.Text = "Пошук за умовою";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(830, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 166);
            this.dataGridView2.TabIndex = 48;
            // 
            // btnJoinTables1
            // 
            this.btnJoinTables1.Location = new System.Drawing.Point(830, 185);
            this.btnJoinTables1.Name = "btnJoinTables1";
            this.btnJoinTables1.Size = new System.Drawing.Size(215, 45);
            this.btnJoinTables1.TabIndex = 47;
            this.btnJoinTables1.Text = "Переглянути продажі з деталями ліків";
            this.btnJoinTables1.UseVisualStyleBackColor = true;
            this.btnJoinTables1.Click += new System.EventHandler(this.btnJoinTables1_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(1121, 185);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(152, 48);
            this.buttonCalculate.TabIndex = 46;
            this.buttonCalculate.Text = "Обчислити кількість";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(588, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "ВІд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(588, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "До";
            // 
            // Sales_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnJoinTables1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxField);
            this.Controls.Add(this.btnSort_Click);
            this.Controls.Add(this.sales_HistoryDataGridView);
            this.Controls.Add(this.sales_HistoryBindingNavigator);
            this.Name = "Sales_History";
            this.Text = "Sales_History";
            this.Load += new System.EventHandler(this.Sales_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryBindingNavigator)).EndInit();
            this.sales_HistoryBindingNavigator.ResumeLayout(false);
            this.sales_HistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_HistoryDataGridView)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxField.ResumeLayout(false);
            this.groupBoxField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource sales_HistoryBindingSource;
        private courseDataSetTableAdapters.Sales_HistoryTableAdapter sales_HistoryTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sales_HistoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sales_HistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sales_HistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.RadioButton radioButtonSalesId;
        private System.Windows.Forms.RadioButton radioButtonOrderId;
        private System.Windows.Forms.RadioButton radioButtonProductId;
        private System.Windows.Forms.RadioButton radioButtonSaleDate;
        private System.Windows.Forms.Button btnSort_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnJoinTables1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}