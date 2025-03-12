using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Products
{
    public partial class MainProducts: Form
    {
        public MainProducts()
        {
            InitializeComponent();
            MyData.LoadProducts(tableLayoutPanel1);
        }

        private void MainProducts_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
