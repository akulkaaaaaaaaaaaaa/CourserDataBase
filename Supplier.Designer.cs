namespace Course
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.courseDataSet = new Course.courseDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Course.courseDataSetTableAdapters.SupplierTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxMaxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxMinSupplier = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewSupplier2 = new System.Windows.Forms.DataGridView();
            this.buttonJoinTables = new System.Windows.Forms.Button();
            this.groupBoxSupplier = new System.Windows.Forms.GroupBox();
            this.radioButtonAscSupplier = new System.Windows.Forms.RadioButton();
            this.radioButtonDescSupplier = new System.Windows.Forms.RadioButton();
            this.groupBoxFieldSupplier = new System.Windows.Forms.GroupBox();
            this.radioButtonReliabilityRating = new System.Windows.Forms.RadioButton();
            this.radioButtonSupplierID = new System.Windows.Forms.RadioButton();
            this.radioButtonCompanyName = new System.Windows.Forms.RadioButton();
            this.radioButtonContactInfo = new System.Windows.Forms.RadioButton();
            this.radioButtonDeliveryTerms = new System.Windows.Forms.RadioButton();
            this.btnSortSupplier = new System.Windows.Forms.Button();
            this.dataGridViewSupplier1 = new System.Windows.Forms.DataGridView();
            this.txtMinSupplier = new System.Windows.Forms.TextBox();
            this.btnFilterSupplier = new System.Windows.Forms.Button();
            this.btnCalculateReliabilityRating = new System.Windows.Forms.Button();
            this.txtMaxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).BeginInit();
            this.supplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier2)).BeginInit();
            this.groupBoxSupplier.SuspendLayout();
            this.groupBoxFieldSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.courseDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Stock_InventoryTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplierBindingNavigator
            // 
            this.supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplierBindingNavigator.BindingSource = this.supplierBindingSource;
            this.supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplierBindingNavigatorSaveItem});
            this.supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplierBindingNavigator.Name = "supplierBindingNavigator";
            this.supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplierBindingNavigator.Size = new System.Drawing.Size(1277, 27);
            this.supplierBindingNavigator.TabIndex = 0;
            this.supplierBindingNavigator.Text = "bindingNavigator1";
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
            // supplierBindingNavigatorSaveItem
            // 
            this.supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierBindingNavigatorSaveItem.Image")));
            this.supplierBindingNavigatorSaveItem.Name = "supplierBindingNavigatorSaveItem";
            this.supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplierBindingNavigatorSaveItem_Click);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(0, 30);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.RowHeadersWidth = 51;
            this.supplierDataGridView.RowTemplate.Height = 24;
            this.supplierDataGridView.Size = new System.Drawing.Size(656, 200);
            this.supplierDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "supplier_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "supplier_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "company_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "company_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "contact_info";
            this.dataGridViewTextBoxColumn3.HeaderText = "contact_info";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "delivery_terms";
            this.dataGridViewTextBoxColumn4.HeaderText = "delivery_terms";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "reliability_rating";
            this.dataGridViewTextBoxColumn5.HeaderText = "reliability_rating";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // textBoxMaxSupplier
            // 
            this.textBoxMaxSupplier.Location = new System.Drawing.Point(596, 337);
            this.textBoxMaxSupplier.Name = "textBoxMaxSupplier";
            this.textBoxMaxSupplier.Size = new System.Drawing.Size(68, 22);
            this.textBoxMaxSupplier.TabIndex = 35;
            // 
            // textBoxMinSupplier
            // 
            this.textBoxMinSupplier.Location = new System.Drawing.Point(500, 337);
            this.textBoxMinSupplier.Name = "textBoxMinSupplier";
            this.textBoxMinSupplier.Size = new System.Drawing.Size(79, 22);
            this.textBoxMinSupplier.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(500, 426);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 48);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Пошук за умовою";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewSupplier2
            // 
            this.dataGridViewSupplier2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSupplier2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier2.Location = new System.Drawing.Point(686, 304);
            this.dataGridViewSupplier2.Name = "dataGridViewSupplier2";
            this.dataGridViewSupplier2.RowHeadersWidth = 51;
            this.dataGridViewSupplier2.RowTemplate.Height = 24;
            this.dataGridViewSupplier2.Size = new System.Drawing.Size(581, 184);
            this.dataGridViewSupplier2.TabIndex = 32;
            // 
            // buttonJoinTables
            // 
            this.buttonJoinTables.BackColor = System.Drawing.SystemColors.Window;
            this.buttonJoinTables.Location = new System.Drawing.Point(710, 156);
            this.buttonJoinTables.Name = "buttonJoinTables";
            this.buttonJoinTables.Size = new System.Drawing.Size(152, 54);
            this.buttonJoinTables.TabIndex = 31;
            this.buttonJoinTables.Text = "Показати постачальників з продуктами";
            this.buttonJoinTables.UseVisualStyleBackColor = false;
            this.buttonJoinTables.Click += new System.EventHandler(this.buttonJoinTables_Click);
            // 
            // groupBoxSupplier
            // 
            this.groupBoxSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxSupplier.Controls.Add(this.radioButtonAscSupplier);
            this.groupBoxSupplier.Controls.Add(this.radioButtonDescSupplier);
            this.groupBoxSupplier.Location = new System.Drawing.Point(240, 252);
            this.groupBoxSupplier.Name = "groupBoxSupplier";
            this.groupBoxSupplier.Size = new System.Drawing.Size(200, 171);
            this.groupBoxSupplier.TabIndex = 29;
            this.groupBoxSupplier.TabStop = false;
            this.groupBoxSupplier.Text = "Порядок сортування";
            // 
            // radioButtonAscSupplier
            // 
            this.radioButtonAscSupplier.AutoSize = true;
            this.radioButtonAscSupplier.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAscSupplier.Name = "radioButtonAscSupplier";
            this.radioButtonAscSupplier.Size = new System.Drawing.Size(121, 20);
            this.radioButtonAscSupplier.TabIndex = 6;
            this.radioButtonAscSupplier.TabStop = true;
            this.radioButtonAscSupplier.Text = "По зростанню";
            this.radioButtonAscSupplier.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescSupplier
            // 
            this.radioButtonDescSupplier.AutoSize = true;
            this.radioButtonDescSupplier.Location = new System.Drawing.Point(6, 52);
            this.radioButtonDescSupplier.Name = "radioButtonDescSupplier";
            this.radioButtonDescSupplier.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDescSupplier.TabIndex = 7;
            this.radioButtonDescSupplier.TabStop = true;
            this.radioButtonDescSupplier.Text = "По спаданню";
            this.radioButtonDescSupplier.UseVisualStyleBackColor = true;
            // 
            // groupBoxFieldSupplier
            // 
            this.groupBoxFieldSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonReliabilityRating);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonSupplierID);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonCompanyName);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonContactInfo);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonDeliveryTerms);
            this.groupBoxFieldSupplier.Location = new System.Drawing.Point(17, 252);
            this.groupBoxFieldSupplier.Name = "groupBoxFieldSupplier";
            this.groupBoxFieldSupplier.Size = new System.Drawing.Size(200, 171);
            this.groupBoxFieldSupplier.TabIndex = 28;
            this.groupBoxFieldSupplier.TabStop = false;
            this.groupBoxFieldSupplier.Text = "Вибір для сортування";
            // 
            // radioButtonReliabilityRating
            // 
            this.radioButtonReliabilityRating.AutoSize = true;
            this.radioButtonReliabilityRating.Location = new System.Drawing.Point(6, 125);
            this.radioButtonReliabilityRating.Name = "radioButtonReliabilityRating";
            this.radioButtonReliabilityRating.Size = new System.Drawing.Size(153, 20);
            this.radioButtonReliabilityRating.TabIndex = 6;
            this.radioButtonReliabilityRating.TabStop = true;
            this.radioButtonReliabilityRating.Text = "Рейтинг надійності";
            this.radioButtonReliabilityRating.UseVisualStyleBackColor = true;
            // 
            // radioButtonSupplierID
            // 
            this.radioButtonSupplierID.AutoSize = true;
            this.radioButtonSupplierID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSupplierID.Name = "radioButtonSupplierID";
            this.radioButtonSupplierID.Size = new System.Drawing.Size(144, 20);
            this.radioButtonSupplierID.TabIndex = 2;
            this.radioButtonSupplierID.TabStop = true;
            this.radioButtonSupplierID.Text = "ID постачальника";
            this.radioButtonSupplierID.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompanyName
            // 
            this.radioButtonCompanyName.AutoSize = true;
            this.radioButtonCompanyName.Location = new System.Drawing.Point(6, 47);
            this.radioButtonCompanyName.Name = "radioButtonCompanyName";
            this.radioButtonCompanyName.Size = new System.Drawing.Size(127, 20);
            this.radioButtonCompanyName.TabIndex = 3;
            this.radioButtonCompanyName.TabStop = true;
            this.radioButtonCompanyName.Text = "Назва компанії";
            this.radioButtonCompanyName.UseVisualStyleBackColor = true;
            // 
            // radioButtonContactInfo
            // 
            this.radioButtonContactInfo.AutoSize = true;
            this.radioButtonContactInfo.Location = new System.Drawing.Point(6, 73);
            this.radioButtonContactInfo.Name = "radioButtonContactInfo";
            this.radioButtonContactInfo.Size = new System.Drawing.Size(173, 20);
            this.radioButtonContactInfo.TabIndex = 4;
            this.radioButtonContactInfo.TabStop = true;
            this.radioButtonContactInfo.Text = "Контактна інформація";
            this.radioButtonContactInfo.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeliveryTerms
            // 
            this.radioButtonDeliveryTerms.AutoSize = true;
            this.radioButtonDeliveryTerms.Location = new System.Drawing.Point(6, 99);
            this.radioButtonDeliveryTerms.Name = "radioButtonDeliveryTerms";
            this.radioButtonDeliveryTerms.Size = new System.Drawing.Size(134, 20);
            this.radioButtonDeliveryTerms.TabIndex = 5;
            this.radioButtonDeliveryTerms.TabStop = true;
            this.radioButtonDeliveryTerms.Text = "Умови доставки";
            this.radioButtonDeliveryTerms.UseVisualStyleBackColor = true;
            // 
            // btnSortSupplier
            // 
            this.btnSortSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.btnSortSupplier.Location = new System.Drawing.Point(148, 440);
            this.btnSortSupplier.Name = "btnSortSupplier";
            this.btnSortSupplier.Size = new System.Drawing.Size(187, 48);
            this.btnSortSupplier.TabIndex = 27;
            this.btnSortSupplier.Text = "Сортувати";
            this.btnSortSupplier.UseVisualStyleBackColor = false;
            this.btnSortSupplier.Click += new System.EventHandler(this.btnSortSupplier_Click_1);
            // 
            // dataGridViewSupplier1
            // 
            this.dataGridViewSupplier1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSupplier1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier1.Location = new System.Drawing.Point(885, 42);
            this.dataGridViewSupplier1.Name = "dataGridViewSupplier1";
            this.dataGridViewSupplier1.RowHeadersWidth = 51;
            this.dataGridViewSupplier1.RowTemplate.Height = 24;
            this.dataGridViewSupplier1.Size = new System.Drawing.Size(382, 238);
            this.dataGridViewSupplier1.TabIndex = 38;
            // 
            // txtMinSupplier
            // 
            this.txtMinSupplier.Location = new System.Drawing.Point(725, 30);
            this.txtMinSupplier.Name = "txtMinSupplier";
            this.txtMinSupplier.Size = new System.Drawing.Size(124, 22);
            this.txtMinSupplier.TabIndex = 37;
            // 
            // btnFilterSupplier
            // 
            this.btnFilterSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.btnFilterSupplier.Location = new System.Drawing.Point(710, 86);
            this.btnFilterSupplier.Name = "btnFilterSupplier";
            this.btnFilterSupplier.Size = new System.Drawing.Size(152, 54);
            this.btnFilterSupplier.TabIndex = 36;
            this.btnFilterSupplier.Text = "Фільтрація рейтингу";
            this.btnFilterSupplier.UseVisualStyleBackColor = false;
            this.btnFilterSupplier.Click += new System.EventHandler(this.btnFilterSupplier_Click);
            // 
            // btnCalculateReliabilityRating
            // 
            this.btnCalculateReliabilityRating.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalculateReliabilityRating.Location = new System.Drawing.Point(710, 223);
            this.btnCalculateReliabilityRating.Name = "btnCalculateReliabilityRating";
            this.btnCalculateReliabilityRating.Size = new System.Drawing.Size(152, 57);
            this.btnCalculateReliabilityRating.TabIndex = 39;
            this.btnCalculateReliabilityRating.Text = "Обчислення рейтингу";
            this.btnCalculateReliabilityRating.UseVisualStyleBackColor = false;
            this.btnCalculateReliabilityRating.Click += new System.EventHandler(this.btnCalculateReliabilityRating_Click);
            // 
            // txtMaxSupplier
            // 
            this.txtMaxSupplier.Location = new System.Drawing.Point(725, 58);
            this.txtMaxSupplier.Name = "txtMaxSupplier";
            this.txtMaxSupplier.Size = new System.Drawing.Size(124, 22);
            this.txtMaxSupplier.TabIndex = 40;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(500, 398);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(164, 22);
            this.textBoxSearchValue.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(497, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Для цифр за діапазоном";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(497, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Для тексту";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1277, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.txtMaxSupplier);
            this.Controls.Add(this.btnCalculateReliabilityRating);
            this.Controls.Add(this.dataGridViewSupplier1);
            this.Controls.Add(this.txtMinSupplier);
            this.Controls.Add(this.btnFilterSupplier);
            this.Controls.Add(this.textBoxMaxSupplier);
            this.Controls.Add(this.textBoxMinSupplier);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewSupplier2);
            this.Controls.Add(this.buttonJoinTables);
            this.Controls.Add(this.groupBoxSupplier);
            this.Controls.Add(this.groupBoxFieldSupplier);
            this.Controls.Add(this.btnSortSupplier);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(this.supplierBindingNavigator);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).EndInit();
            this.supplierBindingNavigator.ResumeLayout(false);
            this.supplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier2)).EndInit();
            this.groupBoxSupplier.ResumeLayout(false);
            this.groupBoxSupplier.PerformLayout();
            this.groupBoxFieldSupplier.ResumeLayout(false);
            this.groupBoxFieldSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private courseDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplierBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBoxMaxSupplier;
        private System.Windows.Forms.TextBox textBoxMinSupplier;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewSupplier2;
        private System.Windows.Forms.Button buttonJoinTables;
        private System.Windows.Forms.GroupBox groupBoxSupplier;
        private System.Windows.Forms.RadioButton radioButtonAscSupplier;
        private System.Windows.Forms.RadioButton radioButtonDescSupplier;
        private System.Windows.Forms.GroupBox groupBoxFieldSupplier;
        private System.Windows.Forms.RadioButton radioButtonSupplierID;
        private System.Windows.Forms.RadioButton radioButtonCompanyName;
        private System.Windows.Forms.RadioButton radioButtonContactInfo;
        private System.Windows.Forms.RadioButton radioButtonDeliveryTerms;
        private System.Windows.Forms.Button btnSortSupplier;
        private System.Windows.Forms.DataGridView dataGridViewSupplier1;
        private System.Windows.Forms.TextBox txtMinSupplier;
        private System.Windows.Forms.Button btnFilterSupplier;
        private System.Windows.Forms.RadioButton radioButtonReliabilityRating;
        private System.Windows.Forms.Button btnCalculateReliabilityRating;
        private System.Windows.Forms.TextBox txtMaxSupplier;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}