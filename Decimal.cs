using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9
{
    public class Decimal : Integer
    {
        public override string Add()
        {
            int x,y;
            x = Convert.ToInt32(A);
            y = Convert.ToInt32(B);
            return (x+y).ToString();     
        }
        public override string Sub()
        {
            int x, y;
            x = Convert.ToInt32(A);
            y = Convert.ToInt32(B);
            return (x - y).ToString();
        }
        public override void Display()
        {
           Console.WriteLine($" Decimal:\n A = {A}\n B = {B}");
        }
        
    }
}
