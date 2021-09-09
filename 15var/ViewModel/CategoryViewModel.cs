using _15var.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15var.ViewModel
{
    public class CategoryViewModel
    {
        public ObservableCollection<Category> ListCategory { get; set; } = new
ObservableCollection<Category>();
        public CategoryViewModel()
        {
            this.ListCategory.Add(new Category
            {
                Id = 1,
                CategoryName = "успокоительные",
                Description = "группа лекарств, регулирующих функции нервной системы"
            });
            this.ListCategory.Add(new Category
            {
                Id = 2,
                CategoryName = "периферия",
                Description = "совокупность внешних устройств"
            });

        }
    }
}
