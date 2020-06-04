using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Refund
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Batch { get; set; }
        public string Dateofrefund { get; set; }
        public string Customername { get; set; }
        public int Customerphone { get; set; }
        public string Reasonofrefund { get; set; }
    }
}
