using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Publication
    {
        public string title { get; set; }
        public int price { get; set; }

        public Publication(string title, int price)
        {
            this.title = title;
            this.price = price;
        }

        public virtual void getdata()
        {
            Console.WriteLine($"The book title is {title}");
            Console.WriteLine($"The price is {price}");
        }
      
    }
}
