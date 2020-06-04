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
    public partial class Add_Product_View : MetroFramework.Forms.MetroForm
    {
        public Add_Product_View()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {                     
            dynamic i = Manufacturedatebox.Value.ToString();
            dynamic j = Expirydatebox.Value.ToString();
            ProductController.AddProduct(Namebox.Text, Batchbox.Text, Quantitybox.Text, Buypricebox.Text, Sellpricebox.Text, i, j, DescriptionBox.Text);
            //dataGridViewUsers.DataSource = EmployeeController.GetAllUsers();
            MessageBox.Show("Successfully Added Product");
            metroGrid.DataSource = ProductController.GetAllProducts();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new Manager_View().Show();
        }

        private void AddProductView_Load(object sender, EventArgs e)
        {
            var products = ProductController.GetAllProducts();
            metroGrid.DataSource = ProductController.GetAllProducts();
        }
    }
}
