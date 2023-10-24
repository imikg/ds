using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Solution2
{
    public delegate void TempChangeHandler(double current, double change);

    class Termometer
    {
        double current = 24;
        public event TempChangeHandler TempChange;

        public void Run()
        {
            // Logika za merenje
            Random rnd = new Random();
            int passed = 0;

            while (true)
            {
                Thread.Sleep(1000);
                passed += 1000;
                int change = rnd.Next(3) - 1; // -1, 0, 1
                current += change;

                // Console.WriteLine("DEBUG: " + current);

                if (change != 0 && TempChange != null)
                {
                    TempChange(current, change);
                }

                if (passed >= 5000)
                {
                    return;
                }
            }
        }
    }
}
