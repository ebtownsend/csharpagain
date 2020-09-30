using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // practice throwing exceptions
    class Finance
    {
        public void tax(int salary, int absenties)
        {
            float tax = 0;

            if (absenties > 10)
            {
                NBSException e = new NBSException();
                throw e;
            } else
            {
                tax = salary * 20 / 100;
                Console.WriteLine("Tax calculated = " + tax);
            }
        }
    }
}
