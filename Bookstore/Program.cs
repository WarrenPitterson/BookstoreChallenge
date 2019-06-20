using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the title?");
            string newTitle = Console.ReadLine();

            Console.WriteLine("Please enter a price");
            int newPrice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a runtime");
            int runTime = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a page count");
            int pageCount = Int32.Parse(Console.ReadLine());




            Book A = new Book("Old Boy", 10, 200);
            Tape B = new Tape("Calming seagull noises", 10, 200);
            Book C = new Book (newTitle,newPrice, pageCount);
            

            //A.getdata();
            //B.getdata();
            C.getdata();

            Console.ReadKey();
           

            consoel
           
        }
    }
}
