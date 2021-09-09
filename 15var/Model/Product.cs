using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public float UnitsInStock { get; set; }
        public float UnitsInOrder { get; set; }
        public Product() { }
        public Product(int id, int categoryid, string productname, float unitprice,
        float unitsinstock, float unitsinorder)
        {
            this.Id = id;
            this.CategoryId = categoryid;
            this.ProductName = productname;
            this.UnitPrice = unitprice;
            this.UnitsInStock = unitsinstock;
            this.UnitsInOrder = unitsinorder;
        }
    }
}
