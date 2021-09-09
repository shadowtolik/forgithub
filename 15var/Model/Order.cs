using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddres { get; set; }
        public Order() { }
        public Order(int id, string customer, string employee, 
            DateTime orderdate, DateTime shippeddate, string shipname, string shipaddress)
        {
            this.Id = id;
            this.Customer = customer;
            this.Employee = employee;
            this.OrderDate = orderdate;
            this.ShippedDate = shippeddate;
            this.ShipName = shipname;
            this.ShipAddres = shipaddress;
        }
    }
}

