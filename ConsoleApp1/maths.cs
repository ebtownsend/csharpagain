using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // practice try & catch exceptions

    class maths
    {
        public void division(int a, int b)
        {
            int result = 0;

                result = a / b;
                Console.WriteLine("Result of division = " + result);



        }

        public void arrayProcessing(int i)
        {
            int[] nums = { 1, 2, 3 };
            try
            {
                Console.WriteLine("Value at location " + i + " is " + nums[i]);
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Cannot access location in array - out of range");
            }
        }
    }
}
