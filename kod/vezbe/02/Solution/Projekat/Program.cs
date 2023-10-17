using System;

namespace Projekat
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec = new Vector(new double[] { 1, 2, 3, 4 });

            foreach (var item in vec)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
