using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal d = new Decimal();
            d.A = "123";
            d.B = "123";
            d.Display();
            Console.WriteLine(" A + B = " + d.Add());
            Console.WriteLine(" A - B = " + d.Sub());

            Binary b = new Binary();
            b.A = "101";
            b.B = "010";
            b.Display();
            Console.WriteLine(" A + B = " + b.Add());
            Console.WriteLine(" A - B = " + b.Sub());



            Console.ReadKey();
        }
    }
}
