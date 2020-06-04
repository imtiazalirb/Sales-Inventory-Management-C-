using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Sell_Product : MetroFramework.Forms.MetroForm
    {
        public Sell_Product()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            All_Products_Grid_View.DataSource = ProductController.GetAllProducts();
            Sold_Products_Grid_View.DataSource = SaleController.GetAllSales();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new Employee_View().Show();
        }
        private void Cell_Content_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Id_Box.Text = this.All_Products_Grid_View.CurrentRow.Cells["Id"].Value.ToString();
            this.Name_Box.Text = this.All_Products_Grid_View.CurrentRow.Cells["Name"].Value.ToString();
            this.Batch_Label.Text = this.All_Products_Grid_View.CurrentRow.Cells["Batch"].Value.ToString();
            this.Unit_Price_Label.Text = this.All_Products_Grid_View.CurrentRow.Cells["Sellprice"].Value.ToString();
            this.Product_Remaining_Label.Text = this.All_Products_Grid_View.CurrentRow.Cells["Quantity"].Value.ToString();
            this.Description_label.Text = this.All_Products_Grid_View.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void Sell_Button_Click(object sender, EventArgs e)
        {
            this.Id_Box.Text = this.All_Products_Grid_View.CurrentRow.Cells["Id"].Value.ToString();
            ProductController.SellProduct(Id_Box.Text, Name_Box.Text, Batch_Label.Text,Unit_Price_Label.Text, Sell_Quantity_Box.Text);
            All_Products_Grid_View.DataSource = ProductController.GetAllProducts();
            SaleController.AddSales(Id_Box.Text, Name_Box.Text, Batch_Label.Text,Sell_Quantity_Box.Text,Unit_Price_Label.Text);
            Sold_Products_Grid_View.DataSource = SaleController.GetAllSales();
        }
    }
}
