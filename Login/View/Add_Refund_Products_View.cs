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
    public partial class Add_Refund_Products_View : MetroFramework.Forms.MetroForm
    {
        public Add_Refund_Products_View()
        {
            InitializeComponent();
        }
        private void Refund_Product_Load(object sender, EventArgs e)
        {
            Product_View_Grid.DataSource = SaleController.GetAllSales();
            Refund_List_Grid.DataSource = RefundController.GetAllRefunds();
        }
        private void Add_Button(object sender, EventArgs e)
        {
            dynamic i = Datetime_Box.Value.ToString();
            RefundController.AddRefund(Id_Box.Text, Name_Box.Text, Batch_Box.Text, Datetime_Box.Text, Customer_Name_Box.Text, Customer_Phoner_Number_Box.Text, Refund_Reason_Box.Text);
            MessageBox.Show("Successfully Added to Refund List");
            Refund_List_Grid.DataSource = RefundController.GetAllRefunds();
        }

        private void Product_List_Cell_Content_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Id_Box.Text = this.Product_View_Grid.CurrentRow.Cells["Id"].Value.ToString();
            this.Name_Box.Text = this.Product_View_Grid.CurrentRow.Cells["Name"].Value.ToString();
            this.Batch_Box.Text = this.Product_View_Grid.CurrentRow.Cells["Batch"].Value.ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new Employee_View().Show();
        }

        private void All_Refund_Products_View_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Sales_Search_Box_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
