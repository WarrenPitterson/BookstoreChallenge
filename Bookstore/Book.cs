using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Book : Publication
    {
        public int pageCount { get; set; }

        public Book(string title, int price, int pageCount):base(title,price) {
           this.pageCount = pageCount;
        }

        public override void getdata()
        {
            base.getdata();
            Console.WriteLine($"The page count is {pageCount}");
        }
    }
}
