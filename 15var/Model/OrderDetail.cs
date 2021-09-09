using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.Model
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public float UnitPrice { get; set; }
        public float Discount { get; set; }
        public OrderDetail() { }
        public OrderDetail(int productid, int orderid, float unitprice,
        float discount)
        {
            this.ProductId = productid;
            this.OrderId = orderid;
            this.UnitPrice = unitprice;
            this.Discount = discount;
        }
    }
}
