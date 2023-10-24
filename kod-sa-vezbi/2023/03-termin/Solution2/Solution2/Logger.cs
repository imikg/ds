using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Logger
    {
        string name = "Default";

        public Logger(string name)
        {
            this.name = name;
        }

        public void Log(double temp, double delta)
        {
            Console.WriteLine("Logger (" + name + "): " + temp + ", " + delta);
        }
    }
}
