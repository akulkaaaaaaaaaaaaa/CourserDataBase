namespace Course
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.courseDataSet = new Course.courseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Course.courseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Course.courseDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOrderCustomer = new System.Windows.Forms.GroupBox();
            this.radioButtonAscCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonDescCustomer = new System.Windows.Forms.RadioButton();
            this.groupBoxFieldCustomer = new System.Windows.Forms.GroupBox();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonFullName = new System.Windows.Forms.RadioButton();
            this.radioButtonContactInfo = new System.Windows.Forms.RadioButton();
            this.radioButtonLoyatyCard = new System.Windows.Forms.RadioButton();
            this.btnSortCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer1 = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnFilterCustomer = new System.Windows.Forms.Button();
            this.buttonJoinTables = new System.Windows.Forms.Button();
            this.textBoxMinCustomerId = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.textBoxMaxCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.groupBoxOrderCustomer.SuspendLayout();
            this.groupBoxFieldCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.courseDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
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
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(1170, 27);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 30);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(545, 143);
            this.customerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "customer_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "full_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "full_name";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "loyalty_card_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "loyalty_card_number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // groupBoxOrderCustomer
            // 
            this.groupBoxOrderCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOrderCustomer.Controls.Add(this.radioButtonAscCustomer);
            this.groupBoxOrderCustomer.Controls.Add(this.radioButtonDescCustomer);
            this.groupBoxOrderCustomer.Location = new System.Drawing.Point(222, 201);
            this.groupBoxOrderCustomer.Name = "groupBoxOrderCustomer";
            this.groupBoxOrderCustomer.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOrderCustomer.TabIndex = 13;
            this.groupBoxOrderCustomer.TabStop = false;
            this.groupBoxOrderCustomer.Text = "Порядок сортування";
            this.groupBoxOrderCustomer.Enter += new System.EventHandler(this.groupBoxOrderCustomer_Enter);
            // 
            // radioButtonAscCustomer
            // 
            this.radioButtonAscCustomer.AutoSize = true;
            this.radioButtonAscCustomer.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAscCustomer.Name = "radioButtonAscCustomer";
            this.radioButtonAscCustomer.Size = new System.Drawing.Size(121, 20);
            this.radioButtonAscCustomer.TabIndex = 6;
            this.radioButtonAscCustomer.TabStop = true;
            this.radioButtonAscCustomer.Text = "По зростанню";
            this.radioButtonAscCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescCustomer
            // 
            this.radioButtonDescCustomer.AutoSize = true;
            this.radioButtonDescCustomer.Location = new System.Drawing.Point(6, 52);
            this.radioButtonDescCustomer.Name = "radioButtonDescCustomer";
            this.radioButtonDescCustomer.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDescCustomer.TabIndex = 7;
            this.radioButtonDescCustomer.TabStop = true;
            this.radioButtonDescCustomer.Text = "По спаданню";
            this.radioButtonDescCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBoxFieldCustomer
            // 
            this.groupBoxFieldCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFieldCustomer.Controls.Add(this.radioButtonID);
            this.groupBoxFieldCustomer.Controls.Add(this.radioButtonFullName);
            this.groupBoxFieldCustomer.Controls.Add(this.radioButtonContactInfo);
            this.groupBoxFieldCustomer.Controls.Add(this.radioButtonLoyatyCard);
            this.groupBoxFieldCustomer.Location = new System.Drawing.Point(-1, 191);
            this.groupBoxFieldCustomer.Name = "groupBoxFieldCustomer";
            this.groupBoxFieldCustomer.Size = new System.Drawing.Size(200, 132);
            this.groupBoxFieldCustomer.TabIndex = 12;
            this.groupBoxFieldCustomer.TabStop = false;
            this.groupBoxFieldCustomer.Text = "Вибір для сортування";
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(6, 21);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(62, 20);
            this.radioButtonID.TabIndex = 2;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "По ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullName
            // 
            this.radioButtonFullName.AutoSize = true;
            this.radioButtonFullName.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFullName.Name = "radioButtonFullName";
            this.radioButtonFullName.Size = new System.Drawing.Size(95, 20);
            this.radioButtonFullName.TabIndex = 3;
            this.radioButtonFullName.TabStop = true;
            this.radioButtonFullName.Text = "Повне ім\'я";
            this.radioButtonFullName.UseVisualStyleBackColor = true;
            // 
            // radioButtonContactInfo
            // 
            this.radioButtonContactInfo.AutoSize = true;
            this.radioButtonContactInfo.Location = new System.Drawing.Point(6, 73);
            this.radioButtonContactInfo.Name = "radioButtonContactInfo";
            this.radioButtonContactInfo.Size = new System.Drawing.Size(195, 20);
            this.radioButtonContactInfo.TabIndex = 4;
            this.radioButtonContactInfo.TabStop = true;
            this.radioButtonContactInfo.Text = "По контактній інформаціїї";
            this.radioButtonContactInfo.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoyatyCard
            // 
            this.radioButtonLoyatyCard.AutoSize = true;
            this.radioButtonLoyatyCard.Location = new System.Drawing.Point(6, 99);
            this.radioButtonLoyatyCard.Name = "radioButtonLoyatyCard";
            this.radioButtonLoyatyCard.Size = new System.Drawing.Size(90, 20);
            this.radioButtonLoyatyCard.TabIndex = 5;
            this.radioButtonLoyatyCard.TabStop = true;
            this.radioButtonLoyatyCard.Text = "По картці";
            this.radioButtonLoyatyCard.UseVisualStyleBackColor = true;
            // 
            // btnSortCustomer
            // 
            this.btnSortCustomer.Location = new System.Drawing.Point(91, 350);
            this.btnSortCustomer.Name = "btnSortCustomer";
            this.btnSortCustomer.Size = new System.Drawing.Size(220, 54);
            this.btnSortCustomer.TabIndex = 11;
            this.btnSortCustomer.Text = "Сортувати";
            this.btnSortCustomer.UseVisualStyleBackColor = true;
            this.btnSortCustomer.Click += new System.EventHandler(this.btnSortCustomer_Click);
            // 
            // dataGridViewCustomer1
            // 
            this.dataGridViewCustomer1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCustomer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer1.Location = new System.Drawing.Point(733, 30);
            this.dataGridViewCustomer1.Name = "dataGridViewCustomer1";
            this.dataGridViewCustomer1.RowHeadersWidth = 51;
            this.dataGridViewCustomer1.RowTemplate.Height = 24;
            this.dataGridViewCustomer1.Size = new System.Drawing.Size(367, 202);
            this.dataGridViewCustomer1.TabIndex = 19;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(590, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(124, 22);
            this.txtFullName.TabIndex = 17;
            // 
            // btnFilterCustomer
            // 
            this.btnFilterCustomer.Location = new System.Drawing.Point(575, 75);
            this.btnFilterCustomer.Name = "btnFilterCustomer";
            this.btnFilterCustomer.Size = new System.Drawing.Size(152, 54);
            this.btnFilterCustomer.TabIndex = 16;
            this.btnFilterCustomer.Text = "Фільтрація за іменем";
            this.btnFilterCustomer.UseVisualStyleBackColor = true;
            this.btnFilterCustomer.Click += new System.EventHandler(this.btnFilterCustomer_Click);
            // 
            // buttonJoinTables
            // 
            this.buttonJoinTables.Location = new System.Drawing.Point(575, 144);
            this.buttonJoinTables.Name = "buttonJoinTables";
            this.buttonJoinTables.Size = new System.Drawing.Size(152, 54);
            this.buttonJoinTables.TabIndex = 22;
            this.buttonJoinTables.Text = "Показати замовлення клієнтів";
            this.buttonJoinTables.UseVisualStyleBackColor = true;
            this.buttonJoinTables.Click += new System.EventHandler(this.buttonJoinTables_Click);
            // 
            // textBoxMinCustomerId
            // 
            this.textBoxMinCustomerId.Location = new System.Drawing.Point(372, 329);
            this.textBoxMinCustomerId.Name = "textBoxMinCustomerId";
            this.textBoxMinCustomerId.Size = new System.Drawing.Size(273, 22);
            this.textBoxMinCustomerId.TabIndex = 25;
            this.textBoxMinCustomerId.TextChanged += new System.EventHandler(this.textBoxSearchCustomer_TextChanged);
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Location = new System.Drawing.Point(431, 410);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(152, 48);
            this.buttonSearchCustomer.TabIndex = 24;
            this.buttonSearchCustomer.Text = "Пошук за умовою";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(662, 310);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(496, 161);
            this.dataGridViewCustomer.TabIndex = 23;
            // 
            // textBoxMaxCustomerId
            // 
            this.textBoxMaxCustomerId.Location = new System.Drawing.Point(399, 382);
            this.textBoxMaxCustomerId.Name = "textBoxMaxCustomerId";
            this.textBoxMaxCustomerId.Size = new System.Drawing.Size(246, 22);
            this.textBoxMaxCustomerId.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(357, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Для пошуку за текстом введіть у перше поле";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(428, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Для чисел за діапазоном";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(369, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(342, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Від";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1170, 483);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxCustomerId);
            this.Controls.Add(this.textBoxMinCustomerId);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.buttonJoinTables);
            this.Controls.Add(this.dataGridViewCustomer1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnFilterCustomer);
            this.Controls.Add(this.groupBoxOrderCustomer);
            this.Controls.Add(this.groupBoxFieldCustomer);
            this.Controls.Add(this.btnSortCustomer);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.groupBoxOrderCustomer.ResumeLayout(false);
            this.groupBoxOrderCustomer.PerformLayout();
            this.groupBoxFieldCustomer.ResumeLayout(false);
            this.groupBoxFieldCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private courseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private courseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBoxOrderCustomer;
        private System.Windows.Forms.RadioButton radioButtonAscCustomer;
        private System.Windows.Forms.RadioButton radioButtonDescCustomer;
        private System.Windows.Forms.GroupBox groupBoxFieldCustomer;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonFullName;
        private System.Windows.Forms.RadioButton radioButtonContactInfo;
        private System.Windows.Forms.RadioButton radioButtonLoyatyCard;
        private System.Windows.Forms.Button btnSortCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnFilterCustomer;
        private System.Windows.Forms.Button buttonJoinTables;
        private System.Windows.Forms.TextBox textBoxMinCustomerId;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textBoxMaxCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}