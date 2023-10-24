using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Logger
    {
        string name;
        public Logger(string name)
        {
            this.name = name;
        }
        public void Log()
        {
            Console.WriteLine("Placeholder");
        }

        public int Mul(int x, int y)
        {
            Console.WriteLine("Logger " + this.name + " racuna...");
            return x * y;
        }
    }
}
