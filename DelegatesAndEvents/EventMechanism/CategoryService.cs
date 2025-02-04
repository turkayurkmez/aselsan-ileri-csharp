using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    public class CategoryCreatedEventArgs : EventArgs
    {
        public Category Category { get; set; }
        public DateTime CreatedTime { get; set; }
    }
    public class CategoryService
    {
        //public delegate void CategoryAddedEventHandler(object sender, CategoryCreatedEventArgs e);
        public event EventHandler<CategoryCreatedEventArgs> CategoryAdded;

        public void CreateNewCategory(Category category)
        {
            if (CategoryAdded != null)
            {
                CategoryCreatedEventArgs eventArgs = new() { Category = category, CreatedTime = DateTime.Now };

                CategoryAdded(this, eventArgs);
            }
        }
    }


    public class Category
    {
        public string Name { get; set; }

    }

}
