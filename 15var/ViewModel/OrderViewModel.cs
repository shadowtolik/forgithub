using _15var.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.ViewModel
{
    public class OrderViewModel
    {
        public ObservableCollection<Order> ListOrder { get; set; } =
            new ObservableCollection<Order>();
        public OrderViewModel()
        {
            this.ListOrder.Add(
                new Order
                {
                    Id = 1,
                    Customer = "Иван",
                    Employee = "Алексей",
                    OrderDate = new DateTime(2018, 01, 12),
                    ShippedDate = new DateTime(2018, 01, 15),
                    ShipName = "Электроник",
                    ShipAddres = "Улица Пушкина дом Колотушкина"
                });
            this.ListOrder.Add(
                new Order
                {
                    Id = 2,
                    Customer = "Ксения",
                    Employee = "Акакий",
                    OrderDate = new DateTime(2019, 02, 22),
                    ShippedDate = new DateTime(2019, 02, 25),
                    ShipName = "Медик-Юг",
                    ShipAddres = "Улица дружбы дом соцслужбы"
                });
        }
    }
}
