using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9
{
    public class Binary : Integer
    {
        public override string Add()
        {
            int a = Convert.ToInt32(A, 2);
            int b = Convert.ToInt32(B, 2);
            int sum = a + b;
            return Convert.ToString(sum, 2).PadLeft(8, '0');
        }
        public override string Sub()
        {
            int a = Convert.ToInt32(A, 2);
            int b = Convert.ToInt32(B, 2);
            int sum = a - b;
            return Convert.ToString(sum, 2).PadLeft(8, '0');
        }
        public override void Display()
        {
            Console.WriteLine($" Binary:\n A = {A}\n B = {B}");
        }
    }
}
