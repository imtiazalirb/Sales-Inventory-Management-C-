using Project.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controller
{
    class SaleController
    {
        static Database db = new Database();
        public static ArrayList GetAllSales()
        {
            return db.Sales.GetAllSales();
        }
        public static void AddSales(string id, string name, string batch, string quantity, string unitprice)
        {
            Sale s = new Sale()
            {
                Id = Int32.Parse(id),
                Name = name,
                Batch = batch,
                Quantity = Int32.Parse(quantity),
                UnitPrice = Int32.Parse(unitprice),          
            };
            db.Sales.AddSales(s);
        }
    }
}
