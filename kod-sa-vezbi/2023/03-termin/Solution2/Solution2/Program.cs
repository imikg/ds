using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Log(double temp, double change)
        {
            Console.WriteLine("Log: " + temp + ", " + change);
        }

        static void Main(string[] args)
        {
            Logger log1 = new Logger("L1");

            Termometer t = new Termometer();

            TempChangeHandler f = (c, d) => { Console.WriteLine("--------"); };

            t.TempChange += Log;
            t.TempChange += log1.Log;
            t.TempChange += f;

            t.Run();

            t.TempChange -= log1.Log;
            t.TempChange -= f;

            t.Run();


            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
