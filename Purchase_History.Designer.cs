namespace Course
{
    partial class Purchase_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_History));
            this.courseDataSet = new Course.courseDataSet();
            this.purchase_HistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_HistoryTableAdapter = new Course.courseDataSetTableAdapters.Purchase_HistoryTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.purchase_HistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchase_HistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchase_HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxMaxPurchaseId = new System.Windows.Forms.TextBox();
            this.textBoxMinPurchaseId = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnJoinTables1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.btnSort_Click = new System.Windows.Forms.Button();
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.radioButtonPurchaseID = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerID = new System.Windows.Forms.RadioButton();
            this.radioButtonProductID = new System.Windows.Forms.RadioButton();
            this.radioButtonPurchaseDate = new System.Windows.Forms.RadioButton();
            this.textBoxPurchaseDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryBindingNavigator)).BeginInit();
            this.purchase_HistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxField.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_HistoryBindingSource
            // 
            this.purchase_HistoryBindingSource.DataMember = "Purchase_History";
            this.purchase_HistoryBindingSource.DataSource = this.courseDataSet;
            // 
            // purchase_HistoryTableAdapter
            // 
            this.purchase_HistoryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Purchase_HistoryTableAdapter = this.purchase_HistoryTableAdapter;
            this.tableAdapterManager.Sales_HistoryTableAdapter = null;
            this.tableAdapterManager.Stock_InventoryTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchase_HistoryBindingNavigator
            // 
            this.purchase_HistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchase_HistoryBindingNavigator.BindingSource = this.purchase_HistoryBindingSource;
            this.purchase_HistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchase_HistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchase_HistoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchase_HistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchase_HistoryBindingNavigatorSaveItem});
            this.purchase_HistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchase_HistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchase_HistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchase_HistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchase_HistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchase_HistoryBindingNavigator.Name = "purchase_HistoryBindingNavigator";
            this.purchase_HistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchase_HistoryBindingNavigator.Size = new System.Drawing.Size(1285, 27);
            this.purchase_HistoryBindingNavigator.TabIndex = 0;
            this.purchase_HistoryBindingNavigator.Text = "bindingNavigator1";
            this.purchase_HistoryBindingNavigator.RefreshItems += new System.EventHandler(this.purchase_HistoryBindingNavigator_RefreshItems);
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
            // purchase_HistoryBindingNavigatorSaveItem
            // 
            this.purchase_HistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchase_HistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchase_HistoryBindingNavigatorSaveItem.Image")));
            this.purchase_HistoryBindingNavigatorSaveItem.Name = "purchase_HistoryBindingNavigatorSaveItem";
            this.purchase_HistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.purchase_HistoryBindingNavigatorSaveItem.Text = "Save Data";
            this.purchase_HistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchase_HistoryBindingNavigatorSaveItem_Click);
            // 
            // purchase_HistoryDataGridView
            // 
            this.purchase_HistoryDataGridView.AutoGenerateColumns = false;
            this.purchase_HistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.purchase_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_HistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.purchase_HistoryDataGridView.DataSource = this.purchase_HistoryBindingSource;
            this.purchase_HistoryDataGridView.Location = new System.Drawing.Point(0, 22);
            this.purchase_HistoryDataGridView.Name = "purchase_HistoryDataGridView";
            this.purchase_HistoryDataGridView.RowHeadersWidth = 51;
            this.purchase_HistoryDataGridView.RowTemplate.Height = 24;
            this.purchase_HistoryDataGridView.Size = new System.Drawing.Size(552, 162);
            this.purchase_HistoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "purchase_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "purchase_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "customer_id";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "purchase_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "purchase_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // textBoxMaxPurchaseId
            // 
            this.textBoxMaxPurchaseId.Location = new System.Drawing.Point(668, 306);
            this.textBoxMaxPurchaseId.Name = "textBoxMaxPurchaseId";
            this.textBoxMaxPurchaseId.Size = new System.Drawing.Size(76, 22);
            this.textBoxMaxPurchaseId.TabIndex = 60;
            // 
            // textBoxMinPurchaseId
            // 
            this.textBoxMinPurchaseId.Location = new System.Drawing.Point(577, 306);
            this.textBoxMinPurchaseId.Name = "textBoxMinPurchaseId";
            this.textBoxMinPurchaseId.Size = new System.Drawing.Size(76, 22);
            this.textBoxMinPurchaseId.TabIndex = 59;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(592, 390);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(143, 48);
            this.buttonSearch.TabIndex = 58;
            this.buttonSearch.Text = "Пошук за умовою";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(774, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 166);
            this.dataGridView2.TabIndex = 57;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnJoinTables1
            // 
            this.btnJoinTables1.Location = new System.Drawing.Point(955, 212);
            this.btnJoinTables1.Name = "btnJoinTables1";
            this.btnJoinTables1.Size = new System.Drawing.Size(152, 45);
            this.btnJoinTables1.TabIndex = 56;
            this.btnJoinTables1.Text = "Показати Замовлення";
            this.btnJoinTables1.UseVisualStyleBackColor = true;
            this.btnJoinTables1.Click += new System.EventHandler(this.btnJoinTables1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 55;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(774, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 154);
            this.dataGridView1.TabIndex = 54;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(592, 80);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(152, 22);
            this.txtMaxValue.TabIndex = 53;
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(592, 40);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(152, 22);
            this.txtMinValue.TabIndex = 52;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(592, 118);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(152, 54);
            this.btnFilter.TabIndex = 51;
            this.btnFilter.Text = "Фільтрація по даті замовлення";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOrder.Controls.Add(this.radioButtonAsc);
            this.groupBoxOrder.Controls.Add(this.radioButtonDesc);
            this.groupBoxOrder.Location = new System.Drawing.Point(246, 212);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(200, 150);
            this.groupBoxOrder.TabIndex = 49;
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
            this.btnSort_Click.Location = new System.Drawing.Point(150, 390);
            this.btnSort_Click.Name = "btnSort_Click";
            this.btnSort_Click.Size = new System.Drawing.Size(153, 50);
            this.btnSort_Click.TabIndex = 47;
            this.btnSort_Click.Text = "Сортувати";
            this.btnSort_Click.UseVisualStyleBackColor = true;
            this.btnSort_Click.Click += new System.EventHandler(this.btnSort_Click_Click);
            // 
            // groupBoxField
            // 
            this.groupBoxField.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxField.Controls.Add(this.radioButtonPurchaseID);
            this.groupBoxField.Controls.Add(this.radioButtonCustomerID);
            this.groupBoxField.Controls.Add(this.radioButtonProductID);
            this.groupBoxField.Controls.Add(this.radioButtonPurchaseDate);
            this.groupBoxField.Location = new System.Drawing.Point(12, 212);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.Size = new System.Drawing.Size(200, 150);
            this.groupBoxField.TabIndex = 64;
            this.groupBoxField.TabStop = false;
            this.groupBoxField.Text = "Вибір для сортування";
            // 
            // radioButtonPurchaseID
            // 
            this.radioButtonPurchaseID.AutoSize = true;
            this.radioButtonPurchaseID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonPurchaseID.Name = "radioButtonPurchaseID";
            this.radioButtonPurchaseID.Size = new System.Drawing.Size(98, 20);
            this.radioButtonPurchaseID.TabIndex = 2;
            this.radioButtonPurchaseID.TabStop = true;
            this.radioButtonPurchaseID.Text = "ID покупки";
            this.radioButtonPurchaseID.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerID
            // 
            this.radioButtonCustomerID.AutoSize = true;
            this.radioButtonCustomerID.Location = new System.Drawing.Point(6, 47);
            this.radioButtonCustomerID.Name = "radioButtonCustomerID";
            this.radioButtonCustomerID.Size = new System.Drawing.Size(98, 20);
            this.radioButtonCustomerID.TabIndex = 3;
            this.radioButtonCustomerID.TabStop = true;
            this.radioButtonCustomerID.Text = "ID покупця";
            this.radioButtonCustomerID.UseVisualStyleBackColor = true;
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
            // radioButtonPurchaseDate
            // 
            this.radioButtonPurchaseDate.AutoSize = true;
            this.radioButtonPurchaseDate.Location = new System.Drawing.Point(6, 99);
            this.radioButtonPurchaseDate.Name = "radioButtonPurchaseDate";
            this.radioButtonPurchaseDate.Size = new System.Drawing.Size(117, 20);
            this.radioButtonPurchaseDate.TabIndex = 5;
            this.radioButtonPurchaseDate.TabStop = true;
            this.radioButtonPurchaseDate.Text = "Дата покупки";
            this.radioButtonPurchaseDate.UseVisualStyleBackColor = true;
            // 
            // textBoxPurchaseDate
            // 
            this.textBoxPurchaseDate.Location = new System.Drawing.Point(577, 352);
            this.textBoxPurchaseDate.Name = "textBoxPurchaseDate";
            this.textBoxPurchaseDate.Size = new System.Drawing.Size(167, 22);
            this.textBoxPurchaseDate.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Для ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = " Для дати";
            // 
            // Purchase_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1285, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPurchaseDate);
            this.Controls.Add(this.groupBoxField);
            this.Controls.Add(this.textBoxMaxPurchaseId);
            this.Controls.Add(this.textBoxMinPurchaseId);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnJoinTables1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.btnSort_Click);
            this.Controls.Add(this.purchase_HistoryDataGridView);
            this.Controls.Add(this.purchase_HistoryBindingNavigator);
            this.Name = "Purchase_History";
            this.Text = "Purchase_History";
            this.Load += new System.EventHandler(this.Purchase_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryBindingNavigator)).EndInit();
            this.purchase_HistoryBindingNavigator.ResumeLayout(false);
            this.purchase_HistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_HistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxField.ResumeLayout(false);
            this.groupBoxField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource purchase_HistoryBindingSource;
        private courseDataSetTableAdapters.Purchase_HistoryTableAdapter purchase_HistoryTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchase_HistoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchase_HistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView purchase_HistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxMaxPurchaseId;
        private System.Windows.Forms.TextBox textBoxMinPurchaseId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnJoinTables1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.Button btnSort_Click;
        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.RadioButton radioButtonPurchaseID;
        private System.Windows.Forms.RadioButton radioButtonCustomerID;
        private System.Windows.Forms.RadioButton radioButtonProductID;
        private System.Windows.Forms.RadioButton radioButtonPurchaseDate;
        private System.Windows.Forms.TextBox textBoxPurchaseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}