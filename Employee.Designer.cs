namespace Course
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.courseDataSet = new Course.courseDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Course.courseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonAscEmployee = new System.Windows.Forms.RadioButton();
            this.radioButtonDescEmployee = new System.Windows.Forms.RadioButton();
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.radioButtonContactInfo = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployeeID = new System.Windows.Forms.RadioButton();
            this.radioButtonFullName = new System.Windows.Forms.RadioButton();
            this.radioButtonPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary = new System.Windows.Forms.RadioButton();
            this.btnSort_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxEmployee = new System.Windows.Forms.TextBox();
            this.textBoxMinEmployee = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewEmployee2 = new System.Windows.Forms.DataGridView();
            this.btnJoinTables1 = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.btnFilterByPosition = new System.Windows.Forms.Button();
            this.dataGridViewEmployee1 = new System.Windows.Forms.DataGridView();
            this.textBoxPositionFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.courseDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Supplier_ProductTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Purchase_HistoryTableAdapter = null;
            this.tableAdapterManager.Sales_HistoryTableAdapter = null;
            this.tableAdapterManager.Stock_InventoryTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course.courseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(1450, 27);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 30);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(804, 209);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "employee_id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "full_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "full_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn4.HeaderText = "position";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "salary";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "contact_info";
            this.dataGridViewTextBoxColumn6.HeaderText = "contact_info";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOrder.Controls.Add(this.radioButtonAscEmployee);
            this.groupBoxOrder.Controls.Add(this.radioButtonDescEmployee);
            this.groupBoxOrder.Location = new System.Drawing.Point(258, 245);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(200, 150);
            this.groupBoxOrder.TabIndex = 13;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Порядок сортування";
            // 
            // radioButtonAscEmployee
            // 
            this.radioButtonAscEmployee.AutoSize = true;
            this.radioButtonAscEmployee.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAscEmployee.Name = "radioButtonAscEmployee";
            this.radioButtonAscEmployee.Size = new System.Drawing.Size(121, 20);
            this.radioButtonAscEmployee.TabIndex = 6;
            this.radioButtonAscEmployee.TabStop = true;
            this.radioButtonAscEmployee.Text = "По зростанню";
            this.radioButtonAscEmployee.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescEmployee
            // 
            this.radioButtonDescEmployee.AutoSize = true;
            this.radioButtonDescEmployee.Location = new System.Drawing.Point(6, 52);
            this.radioButtonDescEmployee.Name = "radioButtonDescEmployee";
            this.radioButtonDescEmployee.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDescEmployee.TabIndex = 7;
            this.radioButtonDescEmployee.TabStop = true;
            this.radioButtonDescEmployee.Text = "По спаданню";
            this.radioButtonDescEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBoxField
            // 
            this.groupBoxField.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxField.Controls.Add(this.radioButtonContactInfo);
            this.groupBoxField.Controls.Add(this.radioButtonEmployeeID);
            this.groupBoxField.Controls.Add(this.radioButtonFullName);
            this.groupBoxField.Controls.Add(this.radioButtonPosition);
            this.groupBoxField.Controls.Add(this.radioButtonSalary);
            this.groupBoxField.Location = new System.Drawing.Point(35, 245);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.Size = new System.Drawing.Size(200, 169);
            this.groupBoxField.TabIndex = 12;
            this.groupBoxField.TabStop = false;
            this.groupBoxField.Text = "Вибір для сортування";
            // 
            // radioButtonContactInfo
            // 
            this.radioButtonContactInfo.AutoSize = true;
            this.radioButtonContactInfo.Location = new System.Drawing.Point(6, 125);
            this.radioButtonContactInfo.Name = "radioButtonContactInfo";
            this.radioButtonContactInfo.Size = new System.Drawing.Size(173, 20);
            this.radioButtonContactInfo.TabIndex = 6;
            this.radioButtonContactInfo.TabStop = true;
            this.radioButtonContactInfo.Text = "Контактна інформація";
            this.radioButtonContactInfo.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployeeID
            // 
            this.radioButtonEmployeeID.AutoSize = true;
            this.radioButtonEmployeeID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonEmployeeID.Name = "radioButtonEmployeeID";
            this.radioButtonEmployeeID.Size = new System.Drawing.Size(137, 20);
            this.radioButtonEmployeeID.TabIndex = 2;
            this.radioButtonEmployeeID.TabStop = true;
            this.radioButtonEmployeeID.Text = "ID Співробітника";
            this.radioButtonEmployeeID.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullName
            // 
            this.radioButtonFullName.AutoSize = true;
            this.radioButtonFullName.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFullName.Name = "radioButtonFullName";
            this.radioButtonFullName.Size = new System.Drawing.Size(91, 20);
            this.radioButtonFullName.TabIndex = 3;
            this.radioButtonFullName.TabStop = true;
            this.radioButtonFullName.Text = "ID Аптеки";
            this.radioButtonFullName.UseVisualStyleBackColor = true;
            // 
            // radioButtonPosition
            // 
            this.radioButtonPosition.AutoSize = true;
            this.radioButtonPosition.Location = new System.Drawing.Point(6, 73);
            this.radioButtonPosition.Name = "radioButtonPosition";
            this.radioButtonPosition.Size = new System.Drawing.Size(95, 20);
            this.radioButtonPosition.TabIndex = 4;
            this.radioButtonPosition.TabStop = true;
            this.radioButtonPosition.Text = "Повне ім\'я";
            this.radioButtonPosition.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalary
            // 
            this.radioButtonSalary.AutoSize = true;
            this.radioButtonSalary.Location = new System.Drawing.Point(6, 99);
            this.radioButtonSalary.Name = "radioButtonSalary";
            this.radioButtonSalary.Size = new System.Drawing.Size(92, 20);
            this.radioButtonSalary.TabIndex = 5;
            this.radioButtonSalary.TabStop = true;
            this.radioButtonSalary.Text = "Зарплата";
            this.radioButtonSalary.UseVisualStyleBackColor = true;
            // 
            // btnSort_Click
            // 
            this.btnSort_Click.Location = new System.Drawing.Point(276, 401);
            this.btnSort_Click.Name = "btnSort_Click";
            this.btnSort_Click.Size = new System.Drawing.Size(153, 50);
            this.btnSort_Click.TabIndex = 11;
            this.btnSort_Click.Text = "Сортувати";
            this.btnSort_Click.UseVisualStyleBackColor = true;
            this.btnSort_Click.Click += new System.EventHandler(this.btnSort_Click_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(687, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Для чисел за діапазоном";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(660, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(617, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Для пошуку за текстом вводіть тільки в 1 ";
            // 
            // textBoxMaxEmployee
            // 
            this.textBoxMaxEmployee.Location = new System.Drawing.Point(690, 353);
            this.textBoxMaxEmployee.Name = "textBoxMaxEmployee";
            this.textBoxMaxEmployee.Size = new System.Drawing.Size(143, 22);
            this.textBoxMaxEmployee.TabIndex = 51;
            // 
            // textBoxMinEmployee
            // 
            this.textBoxMinEmployee.Location = new System.Drawing.Point(690, 306);
            this.textBoxMinEmployee.Name = "textBoxMinEmployee";
            this.textBoxMinEmployee.Size = new System.Drawing.Size(143, 22);
            this.textBoxMinEmployee.TabIndex = 50;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(681, 392);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 48);
            this.buttonSearch.TabIndex = 49;
            this.buttonSearch.Text = "Пошук за умовою";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewEmployee2
            // 
            this.dataGridViewEmployee2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmployee2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee2.Location = new System.Drawing.Point(899, 281);
            this.dataGridViewEmployee2.Name = "dataGridViewEmployee2";
            this.dataGridViewEmployee2.RowHeadersWidth = 51;
            this.dataGridViewEmployee2.RowTemplate.Height = 24;
            this.dataGridViewEmployee2.Size = new System.Drawing.Size(499, 166);
            this.dataGridViewEmployee2.TabIndex = 48;
            // 
            // btnJoinTables1
            // 
            this.btnJoinTables1.Location = new System.Drawing.Point(974, 224);
            this.btnJoinTables1.Name = "btnJoinTables1";
            this.btnJoinTables1.Size = new System.Drawing.Size(152, 45);
            this.btnJoinTables1.TabIndex = 47;
            this.btnJoinTables1.Text = "Перегляд Співробітників та Аптек ";
            this.btnJoinTables1.UseVisualStyleBackColor = true;
            this.btnJoinTables1.Click += new System.EventHandler(this.btnJoinTables1_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(1199, 224);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(152, 45);
            this.buttonCalculate.TabIndex = 46;
            this.buttonCalculate.Text = "Обчислити зарплатню";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // btnFilterByPosition
            // 
            this.btnFilterByPosition.Location = new System.Drawing.Point(824, 56);
            this.btnFilterByPosition.Name = "btnFilterByPosition";
            this.btnFilterByPosition.Size = new System.Drawing.Size(109, 45);
            this.btnFilterByPosition.TabIndex = 55;
            this.btnFilterByPosition.Text = "Фільтрація за позицією";
            this.btnFilterByPosition.UseVisualStyleBackColor = true;
            this.btnFilterByPosition.Click += new System.EventHandler(this.btnFilterByPosition_Click);
            // 
            // dataGridViewEmployee1
            // 
            this.dataGridViewEmployee1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmployee1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee1.Location = new System.Drawing.Point(959, 40);
            this.dataGridViewEmployee1.Name = "dataGridViewEmployee1";
            this.dataGridViewEmployee1.RowHeadersWidth = 51;
            this.dataGridViewEmployee1.RowTemplate.Height = 24;
            this.dataGridViewEmployee1.Size = new System.Drawing.Size(491, 166);
            this.dataGridViewEmployee1.TabIndex = 56;
            // 
            // textBoxPositionFilter
            // 
            this.textBoxPositionFilter.Location = new System.Drawing.Point(810, 107);
            this.textBoxPositionFilter.Name = "textBoxPositionFilter";
            this.textBoxPositionFilter.Size = new System.Drawing.Size(143, 22);
            this.textBoxPositionFilter.TabIndex = 57;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1450, 501);
            this.Controls.Add(this.textBoxPositionFilter);
            this.Controls.Add(this.dataGridViewEmployee1);
            this.Controls.Add(this.btnFilterByPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxEmployee);
            this.Controls.Add(this.textBoxMinEmployee);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewEmployee2);
            this.Controls.Add(this.btnJoinTables1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxField);
            this.Controls.Add(this.btnSort_Click);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxField.ResumeLayout(false);
            this.groupBoxField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private courseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonAscEmployee;
        private System.Windows.Forms.RadioButton radioButtonDescEmployee;
        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.RadioButton radioButtonEmployeeID;
        private System.Windows.Forms.RadioButton radioButtonFullName;
        private System.Windows.Forms.RadioButton radioButtonPosition;
        private System.Windows.Forms.RadioButton radioButtonSalary;
        private System.Windows.Forms.Button btnSort_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxEmployee;
        private System.Windows.Forms.TextBox textBoxMinEmployee;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmployee2;
        private System.Windows.Forms.Button btnJoinTables1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton radioButtonContactInfo;
        private System.Windows.Forms.Button btnFilterByPosition;
        private System.Windows.Forms.DataGridView dataGridViewEmployee1;
        private System.Windows.Forms.TextBox textBoxPositionFilter;
    }
}