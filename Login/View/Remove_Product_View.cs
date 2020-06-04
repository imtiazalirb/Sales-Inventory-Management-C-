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
    public partial class Remove_Product_View : MetroFramework.Forms.MetroForm
    {
        public Remove_Product_View()
        {
            InitializeComponent();
        }
        private void Form_load(object sender, EventArgs e)
        {
            metroGrid.DataSource = ProductController.GetAllProducts();
        }      
        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Idbox.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            ProductController.UpdateProduct(Idbox.Text,Quantitybox.Text, Sellpricebox.Text, DescriptionBox.Text);
            metroGrid.DataSource = ProductController.GetAllProducts();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            new Manager_View().Show();
            this.Close();
        }

        private void Cell_Content_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Idbox.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            this.Namebox.Text = this.metroGrid.CurrentRow.Cells["Name"].Value.ToString();
            this.Quantitybox.Text = this.metroGrid.CurrentRow.Cells["Quantity"].Value.ToString();
            this.Sellpricebox.Text = this.metroGrid.CurrentRow.Cells["Sellprice"].Value.ToString();
            this.DescriptionBox.Text = this.metroGrid.CurrentRow.Cells["Description"].Value.ToString();
        }
        private void Delete_Button(object sender, EventArgs e)
        {
            this.Idbox.Text = this.metroGrid.CurrentRow.Cells["Id"].Value.ToString();
            ProductController.DeleteProduct(Idbox.Text);
            metroGrid.DataSource = ProductController.GetAllProducts();
        }
    }
}
