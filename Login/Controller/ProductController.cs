using Project.Model;
using System;
using Project.View;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.Controller
{
    class ProductController
    {
        static Database db = new Database();
        public static ArrayList GetAllProducts()
        {
            return db.Products.GetAllProducts();
        }
        public static void AddProduct(string name, string batch, string quantity, string buyprice, string sellprice, string manufacturedate, string expirydate, string description)
        {
            Product e = new Product()
            {
                Name = name,
                Batch = batch,
                Quantity = Int32.Parse(quantity),
                Buyprice = Int32.Parse(buyprice),
                Sellprice = Int32.Parse(sellprice),
                Manufacturedate = manufacturedate,
                Expirydate = expirydate,
                Description = description,
            };
            db.Products.AddProduct(e);
        }
        public static void UpdateProduct(string Id, string quantity, string sellprice, string description)
        {
            Product e = new Product()
            {  
                Id = Int32.Parse(Id),
                Quantity = Int32.Parse(quantity),
                Sellprice = Int32.Parse(sellprice),
                Description = description,
            };
            db.Products.UpdateProduct(e);
        }
        public static void DeleteProduct(string id)
        {
            Product e = new Product()
            {
                Id = Int32.Parse(id),
            };
            db.Products.DeleteProduct(e);
        }
        public static void SellProduct(string id, string name, string batch, string sellprice, string quantity)
        {
            Product e = new Product()
            {
                Id = Int32.Parse(id),
                Name = name,
                Batch = batch,
                Sellprice = Int32.Parse(sellprice),
                Quantity = Int32.Parse(quantity),
            };
            db.Products.SellProduct(e);
        }
    }
}
