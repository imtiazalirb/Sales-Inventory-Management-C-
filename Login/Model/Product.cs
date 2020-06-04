using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public int Quantity { get; set; }
        public int Buyprice { get; set; }
        public int Sellprice { get; set; }
        public string Manufacturedate { get; set; }
        public string Expirydate { get; set; }
        public string Description { get; set; }
    }
}
