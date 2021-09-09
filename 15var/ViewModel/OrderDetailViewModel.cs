using _15var.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.ViewModel
{
    public class OrderDetailViewModel
    {
        public ObservableCollection<OrderDetail> ListOrderDetail { get; set; } = new
ObservableCollection<OrderDetail>();
        public OrderDetailViewModel()
        {
            this.ListOrderDetail.Add(new OrderDetail
            {
                ProductId = 1,
                OrderId = 1,
                UnitPrice = 700,
                Discount = 50
            });
            this.ListOrderDetail.Add(new OrderDetail
            {
                ProductId = 2,
                OrderId = 2,
                UnitPrice = 600,
                Discount = 20
            });
        }

    }
}
