using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public delegate int BinaryOp(int a, int b);

    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            BinaryOp f = Add;
            int rez = f(10, 16);
            Console.WriteLine(rez);

            Logger log = new Logger("L1");
            BinaryOp g = log.Mul;
            rez = g(11, 45);
            Console.WriteLine(rez);

            Logger log2 = new Logger("L2");
            BinaryOp k = log2.Mul;
            rez = k(22, 33);
            Console.WriteLine(rez);

            //BinaryOp f = (x, y) => x + y;
            //int rez = f(10, 16);
            //Console.WriteLine(rez);

            BinaryOp[] niz = new BinaryOp[3];
            niz[0] = f;
            niz[1] = g;
            niz[2] = k;

            // niz[0](1, 2);


            Console.ReadLine();
        }
    }
}
