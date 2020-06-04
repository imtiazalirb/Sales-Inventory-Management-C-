using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new RemoveProductView());
            // Application.Run(new AllProductView());
             Application.Run(new Login_View());
            //  Application.Run(new AddProductView());
             // Application.Run(new Employee_View());
        }
    }
}
