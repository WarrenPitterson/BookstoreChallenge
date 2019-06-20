using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Tape : Publication
    {
        public float playingTimeMins { get; set; }

        public Tape(string title, int price, float playingTimeMins) :base (title, price)
        {
            this.playingTimeMins = playingTimeMins;
        }

       public override void getdata()
        {
            base.getdata();
            Console.WriteLine($"The runtime is {playingTimeMins}");
        }

    }
}
