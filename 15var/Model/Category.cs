using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.Model
{
    public class Category
    {
        
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category() { }
        public Category(int id, string categoryname, string description)
        {
            this.Id = id;
            this.CategoryName = categoryname;
            this.Description = description;
        }
    }
}

