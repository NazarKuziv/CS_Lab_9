using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9
{
    public abstract class Integer
    {
        private string a;
        private string b;
        public string A
        {
            set { a = value; }
            get { return a; }
        }
        public string B
        {
            set { b = value; }
            get { return b; }
        }
        public abstract string  Sub();
        public abstract string  Add();
        public abstract void Display();

    }
}
