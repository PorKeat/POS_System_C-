using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Products
{
    public partial class ProductControl : UserControl
    {
        
        public ProductControl()
        {
            InitializeComponent();
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

        }

        public int Id { get; set; }
        public string PName
        {
            get => txtProductName.Text;
            set => txtProductName.Text = value;
        }
        private double price;
        public double Price
        {
            get => price;
            set
            {
                price = value;
                txtPrice.Text = value.ToString("c2");
            }
        }
        public int Qty { get; set; }
        public double Amount { get => Price * Qty; }
        public Image Picture
        {
            get => picture.Image;
            set => picture.Image = value;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(
            //    $"Product ID: {Id}\n"+
            //    $"Product Name: {PName}\n"+
            //    $"Price: {Price}\n"+
            //    $"Quantity: {Qty}\n"+
            //    $"Amount: {Amount}\n"
            //    );
            Qty++;
            btnCancel.Visible = true;
            btnBuy.Text = $"Buy ({Qty})";

            MyData.Orders.Add(this);
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Qty--;
            if(Qty == 0)
            {
                btnCancel.Visible = false;
                btnBuy.Text = "Buy";
                MyData.Orders.Remove(this);
            }
            else
            {
                btnBuy.Text = $"Buy ({Qty})";
            }
        }
    }
}
