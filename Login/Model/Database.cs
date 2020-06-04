using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Database
    {
        public Logins Logins { get; set; }
        public Employees Employees { get; set; }
        public Products Products { get; set; }
        public Refunds Refunds{get; set;}
        public Sales Sales { get; set; }


        public Database()
        {
            Logins = new Logins();

            Employees = new Employees();

            Products = new Products();

            Refunds = new Refunds();

            Sales = new Sales();

        }
    }
}
