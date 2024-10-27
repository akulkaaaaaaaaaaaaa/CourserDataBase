using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Pharmacy_Supplier_Product : Form
    {
        public Pharmacy_Supplier_Product()
        {
            InitializeComponent();
        }

        private void Pharmacy_Supplier_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Pharmacy_Supplier_Product' table. You can move, or remove it, as needed.
            this.pharmacy_Supplier_ProductTableAdapter.Fill(this.courseDataSet.Pharmacy_Supplier_Product);

        }
    }
}
