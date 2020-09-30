using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            maths m = new maths();

            m.arrayProcessing(5);

            try
            {
                m.division(4,0);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            Finance f = new Finance();

            try
            {
                f.tax(2000, 12);
            } catch (NBSException e)
            {
                Console.WriteLine("Its ok");
            }

            try
            {
                f.tax(2000, 13);
            } catch (NBSException e)
            {
                Console.WriteLine("Not allowed");
            }

            Friend friend = new Friend();
            friend.go();
            friend.show();

            Sentence s = new Sentence();
            s.longestWord("Hello my friend how are you");

    Console.ReadKey();
        }
    }
}
