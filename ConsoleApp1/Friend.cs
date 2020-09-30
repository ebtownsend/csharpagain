using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Friend
    {
        // practice this keyword

        public int a = 0;

        public void go()
        {
            int a;
            a = 15;
            //this.a = 15;
            Console.WriteLine(++a);
        }

        public void show()
        {
            Console.WriteLine(a);
        }
    }
}
