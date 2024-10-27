namespace Course
{
    partial class Pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacy));
            this.courseDataSet = new Course.courseDataSet();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyTableAdapter = new Course.courseDataSetTableAdapters.PharmacyTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.pharmacyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.btnCalculateReliabilityRating = new System.Windows.Forms.Button();
            this.dataGridViewPharmacy1 = new System.Windows.Forms.DataGridView();
            this.textBoxMaxPharmacy = new System.Windows.Forms.TextBox();
            this.textBoxMinPharmacy = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewPharmacy2 = new System.Windows.Forms.DataGridView();
            this.groupBoxSupplier = new System.Windows.Forms.GroupBox();
            this.radioButtonAscPharmacy = new System.Windows.Forms.RadioButton();
            this.radioButtonDescPharmacy = new System.Windows.Forms.RadioButton();
            this.groupBoxFieldSupplier = new System.Windows.Forms.GroupBox();
            this.radioButtonSalesArea = new System.Windows.Forms.RadioButton();
            this.radioButtonPharmacyID = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonNumberOfEmployees = new System.Windows.Forms.RadioButton();
            this.SortPharmacy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).BeginInit();
            this.pharmacyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacy2)).BeginInit();
            this.groupBoxSupplier.SuspendLayout();
            this.groupBoxFieldSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.courseDataSet;
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Supplier_ProductTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = this.pharmacyTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Purchase_HistoryTableAdapter = null;
            this.tableAdapterManager.Sales_HistoryTableAdapter = null;
            this.tableAdapterManager.Stock_InventoryTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacyBindingNavigator
            // 
            this.pharmacyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacyBindingNavigator.BindingSource = this.pharmacyBindingSource;
            this.pharmacyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacyBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pharmacyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacyBindingNavigatorSaveItem});
            this.pharmacyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacyBindingNavigator.Name = "pharmacyBindingNavigator";
            this.pharmacyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacyBindingNavigator.Size = new System.Drawing.Size(1363, 27);
            this.pharmacyBindingNavigator.TabIndex = 0;
            this.pharmacyBindingNavigator.Text = "bindingNavigator1";
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
            // pharmacyBindingNavigatorSaveItem
            // 
            this.pharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyBindingNavigatorSaveItem.Image")));
            this.pharmacyBindingNavigatorSaveItem.Name = "pharmacyBindingNavigatorSaveItem";
            this.pharmacyBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pharmacyBindingNavigatorSaveItem.Text = "Save Data";
            this.pharmacyBindingNavigatorSaveItem.Click += new System.EventHandler(this.pharmacyBindingNavigatorSaveItem_Click);
            // 
            // pharmacyDataGridView
            // 
            this.pharmacyDataGridView.AutoGenerateColumns = false;
            this.pharmacyDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pharmacyDataGridView.DataSource = this.pharmacyBindingSource;
            this.pharmacyDataGridView.Location = new System.Drawing.Point(22, 30);
            this.pharmacyDataGridView.Name = "pharmacyDataGridView";
            this.pharmacyDataGridView.RowHeadersWidth = 51;
            this.pharmacyDataGridView.RowTemplate.Height = 24;
            this.pharmacyDataGridView.Size = new System.Drawing.Size(679, 187);
            this.pharmacyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pharmacy_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "pharmacy_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn3.HeaderText = "location";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number_of_employees";
            this.dataGridViewTextBoxColumn4.HeaderText = "number_of_employees";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sales_area";
            this.dataGridViewTextBoxColumn5.HeaderText = "sales_area";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(567, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Для тексту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(567, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Для цифр за діапазоном";
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(570, 370);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(164, 22);
            this.textBoxSearchValue.TabIndex = 53;
            // 
            // btnCalculateReliabilityRating
            // 
            this.btnCalculateReliabilityRating.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalculateReliabilityRating.Location = new System.Drawing.Point(745, 151);
            this.btnCalculateReliabilityRating.Name = "btnCalculateReliabilityRating";
            this.btnCalculateReliabilityRating.Size = new System.Drawing.Size(152, 57);
            this.btnCalculateReliabilityRating.TabIndex = 52;
            this.btnCalculateReliabilityRating.Text = "Обчислення кількість робіників";
            this.btnCalculateReliabilityRating.UseVisualStyleBackColor = false;
            this.btnCalculateReliabilityRating.Click += new System.EventHandler(this.btnCalculateReliabilityRating_Click);
            // 
            // dataGridViewPharmacy1
            // 
            this.dataGridViewPharmacy1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPharmacy1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacy1.Location = new System.Drawing.Point(911, 31);
            this.dataGridViewPharmacy1.Name = "dataGridViewPharmacy1";
            this.dataGridViewPharmacy1.RowHeadersWidth = 51;
            this.dataGridViewPharmacy1.RowTemplate.Height = 24;
            this.dataGridViewPharmacy1.Size = new System.Drawing.Size(423, 238);
            this.dataGridViewPharmacy1.TabIndex = 51;
            // 
            // textBoxMaxPharmacy
            // 
            this.textBoxMaxPharmacy.Location = new System.Drawing.Point(666, 309);
            this.textBoxMaxPharmacy.Name = "textBoxMaxPharmacy";
            this.textBoxMaxPharmacy.Size = new System.Drawing.Size(68, 22);
            this.textBoxMaxPharmacy.TabIndex = 50;
            // 
            // textBoxMinPharmacy
            // 
            this.textBoxMinPharmacy.Location = new System.Drawing.Point(570, 309);
            this.textBoxMinPharmacy.Name = "textBoxMinPharmacy";
            this.textBoxMinPharmacy.Size = new System.Drawing.Size(79, 22);
            this.textBoxMinPharmacy.TabIndex = 49;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(570, 398);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 48);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Пошук за умовою";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewPharmacy2
            // 
            this.dataGridViewPharmacy2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPharmacy2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacy2.Location = new System.Drawing.Point(753, 290);
            this.dataGridViewPharmacy2.Name = "dataGridViewPharmacy2";
            this.dataGridViewPharmacy2.RowHeadersWidth = 51;
            this.dataGridViewPharmacy2.RowTemplate.Height = 24;
            this.dataGridViewPharmacy2.Size = new System.Drawing.Size(581, 216);
            this.dataGridViewPharmacy2.TabIndex = 47;
            // 
            // groupBoxSupplier
            // 
            this.groupBoxSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxSupplier.Controls.Add(this.radioButtonAscPharmacy);
            this.groupBoxSupplier.Controls.Add(this.radioButtonDescPharmacy);
            this.groupBoxSupplier.Location = new System.Drawing.Point(270, 223);
            this.groupBoxSupplier.Name = "groupBoxSupplier";
            this.groupBoxSupplier.Size = new System.Drawing.Size(200, 171);
            this.groupBoxSupplier.TabIndex = 46;
            this.groupBoxSupplier.TabStop = false;
            this.groupBoxSupplier.Text = "Порядок сортування";
            // 
            // radioButtonAscPharmacy
            // 
            this.radioButtonAscPharmacy.AutoSize = true;
            this.radioButtonAscPharmacy.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAscPharmacy.Name = "radioButtonAscPharmacy";
            this.radioButtonAscPharmacy.Size = new System.Drawing.Size(121, 20);
            this.radioButtonAscPharmacy.TabIndex = 6;
            this.radioButtonAscPharmacy.TabStop = true;
            this.radioButtonAscPharmacy.Text = "По зростанню";
            this.radioButtonAscPharmacy.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescPharmacy
            // 
            this.radioButtonDescPharmacy.AutoSize = true;
            this.radioButtonDescPharmacy.Location = new System.Drawing.Point(6, 52);
            this.radioButtonDescPharmacy.Name = "radioButtonDescPharmacy";
            this.radioButtonDescPharmacy.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDescPharmacy.TabIndex = 7;
            this.radioButtonDescPharmacy.TabStop = true;
            this.radioButtonDescPharmacy.Text = "По спаданню";
            this.radioButtonDescPharmacy.UseVisualStyleBackColor = true;
            // 
            // groupBoxFieldSupplier
            // 
            this.groupBoxFieldSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonSalesArea);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonPharmacyID);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonName);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonLocation);
            this.groupBoxFieldSupplier.Controls.Add(this.radioButtonNumberOfEmployees);
            this.groupBoxFieldSupplier.Location = new System.Drawing.Point(47, 223);
            this.groupBoxFieldSupplier.Name = "groupBoxFieldSupplier";
            this.groupBoxFieldSupplier.Size = new System.Drawing.Size(200, 171);
            this.groupBoxFieldSupplier.TabIndex = 45;
            this.groupBoxFieldSupplier.TabStop = false;
            this.groupBoxFieldSupplier.Text = "Вибір для сортування";
            // 
            // radioButtonSalesArea
            // 
            this.radioButtonSalesArea.AutoSize = true;
            this.radioButtonSalesArea.Location = new System.Drawing.Point(6, 125);
            this.radioButtonSalesArea.Name = "radioButtonSalesArea";
            this.radioButtonSalesArea.Size = new System.Drawing.Size(127, 20);
            this.radioButtonSalesArea.TabIndex = 6;
            this.radioButtonSalesArea.TabStop = true;
            this.radioButtonSalesArea.Text = "Торгова площа";
            this.radioButtonSalesArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonPharmacyID
            // 
            this.radioButtonPharmacyID.AutoSize = true;
            this.radioButtonPharmacyID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonPharmacyID.Name = "radioButtonPharmacyID";
            this.radioButtonPharmacyID.Size = new System.Drawing.Size(90, 20);
            this.radioButtonPharmacyID.TabIndex = 2;
            this.radioButtonPharmacyID.TabStop = true;
            this.radioButtonPharmacyID.Text = "ID аптеки";
            this.radioButtonPharmacyID.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(6, 47);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(119, 20);
            this.radioButtonName.TabIndex = 3;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Назва аптеки";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonLocation
            // 
            this.radioButtonLocation.AutoSize = true;
            this.radioButtonLocation.Location = new System.Drawing.Point(6, 73);
            this.radioButtonLocation.Name = "radioButtonLocation";
            this.radioButtonLocation.Size = new System.Drawing.Size(124, 20);
            this.radioButtonLocation.TabIndex = 4;
            this.radioButtonLocation.TabStop = true;
            this.radioButtonLocation.Text = "Розташування";
            this.radioButtonLocation.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumberOfEmployees
            // 
            this.radioButtonNumberOfEmployees.AutoSize = true;
            this.radioButtonNumberOfEmployees.Location = new System.Drawing.Point(6, 99);
            this.radioButtonNumberOfEmployees.Name = "radioButtonNumberOfEmployees";
            this.radioButtonNumberOfEmployees.Size = new System.Drawing.Size(179, 20);
            this.radioButtonNumberOfEmployees.TabIndex = 5;
            this.radioButtonNumberOfEmployees.TabStop = true;
            this.radioButtonNumberOfEmployees.Text = "Кількість співробітнкив";
            this.radioButtonNumberOfEmployees.UseVisualStyleBackColor = true;
            // 
            // SortPharmacy
            // 
            this.SortPharmacy.BackColor = System.Drawing.SystemColors.Window;
            this.SortPharmacy.Location = new System.Drawing.Point(178, 411);
            this.SortPharmacy.Name = "SortPharmacy";
            this.SortPharmacy.Size = new System.Drawing.Size(187, 48);
            this.SortPharmacy.TabIndex = 44;
            this.SortPharmacy.Text = "Сортувати";
            this.SortPharmacy.UseVisualStyleBackColor = false;
            this.SortPharmacy.Click += new System.EventHandler(this.SortPharmacy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(745, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 56;
            this.button1.Text = "Фільтрація площини аптеки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(730, 51);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(83, 22);
            this.textBoxMinValue.TabIndex = 57;
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(819, 51);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(78, 22);
            this.textBoxMaxValue.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(745, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 59;
            this.button2.Text = "Показати Запаси";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1363, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.btnCalculateReliabilityRating);
            this.Controls.Add(this.dataGridViewPharmacy1);
            this.Controls.Add(this.textBoxMaxPharmacy);
            this.Controls.Add(this.textBoxMinPharmacy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewPharmacy2);
            this.Controls.Add(this.groupBoxSupplier);
            this.Controls.Add(this.groupBoxFieldSupplier);
            this.Controls.Add(this.SortPharmacy);
            this.Controls.Add(this.pharmacyDataGridView);
            this.Controls.Add(this.pharmacyBindingNavigator);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).EndInit();
            this.pharmacyBindingNavigator.ResumeLayout(false);
            this.pharmacyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacy2)).EndInit();
            this.groupBoxSupplier.ResumeLayout(false);
            this.groupBoxSupplier.PerformLayout();
            this.groupBoxFieldSupplier.ResumeLayout(false);
            this.groupBoxFieldSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private courseDataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pharmacyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Button btnCalculateReliabilityRating;
        private System.Windows.Forms.DataGridView dataGridViewPharmacy1;
        private System.Windows.Forms.TextBox textBoxMaxPharmacy;
        private System.Windows.Forms.TextBox textBoxMinPharmacy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewPharmacy2;
        private System.Windows.Forms.GroupBox groupBoxSupplier;
        private System.Windows.Forms.RadioButton radioButtonAscPharmacy;
        private System.Windows.Forms.RadioButton radioButtonDescPharmacy;
        private System.Windows.Forms.GroupBox groupBoxFieldSupplier;
        private System.Windows.Forms.RadioButton radioButtonSalesArea;
        private System.Windows.Forms.RadioButton radioButtonPharmacyID;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonLocation;
        private System.Windows.Forms.RadioButton radioButtonNumberOfEmployees;
        private System.Windows.Forms.Button SortPharmacy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.Button button2;
    }
}