using _15var.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> ListProduct { get; set; } = new
ObservableCollection<Product>();
        public ProductViewModel()
        {
            this.ListProduct.Add(new Product
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "клавиатура g500",
                UnitPrice = 700,
                UnitsInStock = 1,
                UnitsInOrder = 1
            });
            this.ListProduct.Add(new Product
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "всёнорм",
                UnitPrice = 600,
                UnitsInStock = 18,
                UnitsInOrder = 1
            });
        }
    }
}
