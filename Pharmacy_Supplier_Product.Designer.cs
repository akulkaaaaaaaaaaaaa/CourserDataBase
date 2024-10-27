namespace Course
{
    partial class Pharmacy_Supplier_Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseDataSet = new Course.courseDataSet();
            this.pharmacySupplierProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_Supplier_ProductTableAdapter = new Course.courseDataSetTableAdapters.Pharmacy_Supplier_ProductTableAdapter();
            this.pharmacyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySupplierProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pharmacyidDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pharmacySupplierProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacySupplierProductBindingSource
            // 
            this.pharmacySupplierProductBindingSource.DataMember = "Pharmacy_Supplier_Product";
            this.pharmacySupplierProductBindingSource.DataSource = this.courseDataSet;
            // 
            // pharmacy_Supplier_ProductTableAdapter
            // 
            this.pharmacy_Supplier_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacyidDataGridViewTextBoxColumn
            // 
            this.pharmacyidDataGridViewTextBoxColumn.DataPropertyName = "pharmacy_id";
            this.pharmacyidDataGridViewTextBoxColumn.HeaderText = "pharmacy_id";
            this.pharmacyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pharmacyidDataGridViewTextBoxColumn.Name = "pharmacyidDataGridViewTextBoxColumn";
            this.pharmacyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Width = 125;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // Pharmacy_Supplier_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pharmacy_Supplier_Product";
            this.Text = "Pharmacy_Supplier_Product";
            this.Load += new System.EventHandler(this.Pharmacy_Supplier_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySupplierProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource pharmacySupplierProductBindingSource;
        private courseDataSetTableAdapters.Pharmacy_Supplier_ProductTableAdapter pharmacy_Supplier_ProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pharmacyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
    }
}