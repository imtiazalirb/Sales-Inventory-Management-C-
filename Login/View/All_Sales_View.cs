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
    public partial class All_Sales_View : MetroFramework.Forms.MetroForm
    {
        public DataSet Ds { get; set; }
        DataAccess Da { get; set; }
        public All_Sales_View()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        void PopulateGridView(string sql)
        {
            this.metroGrid.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql);
            this.metroGrid.DataSource = this.Ds.Tables[0];
        }
        private void All_Sales_View_Load(object sender, EventArgs e)
        {
            metroGrid.DataSource = SaleController.GetAllSales();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            string Name = this.Search_Box.Text;
            {
                string sql = "select * from Sales where Name like '" + Name + "%'; ";
                this.PopulateGridView(sql);
            }
        }
    }
}
