using Project.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.Controller
{

    class RefundController
    {
        static Database db = new Database();
        public static ArrayList GetAllRefunds()
        {
            return db.Refunds.GetAllRefunds();
        }
        public static void AddRefund(string id, string name, string batch, string dateofrefund, string customername, string customerphone, string reasonofrefund)
        {
            {
                Refund r = new Refund()
                {
                    Id = Int32.Parse(id),
                    Name = name,
                    Batch = batch,
                    Dateofrefund = dateofrefund,
                    Customername = customername,
                    Customerphone = Int32.Parse(customerphone),
                    Reasonofrefund = reasonofrefund
                };
                db.Refunds.AddRefund(r);
            }
        }
    }
}
