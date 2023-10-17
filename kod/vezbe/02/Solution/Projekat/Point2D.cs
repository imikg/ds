using System;

namespace Projekat
{
    class Point2D
    {
        private double x = 0;
        private double y = 0;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return base.ToString() + " " + x + " " + y;
        }

        public static Point2D operator +(Point2D a, Point2D b)
        {
            double x = a.x + b.x;
            double y = a.y + b.y;

            return new Point2D(x, y);
        }

        public static Point2D operator +(Point2D a, double x)
        {
            return new Point2D(a.x + x, a.y);
        }

        public static Point2D operator -(Point2D p)
        {
            return new Point2D(-p.x, -p.y);
        }

        public static Point2D operator -(Point2D a, Point2D b)
        {
            return a + (-b);
        }

        public static bool operator ==(Point2D a, Point2D b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Point2D a, Point2D b)
        {
            return !(a == b);
        }

        // Cast

        public static implicit operator double[](Point2D p)
        {
            return new double[] { p.x, p.y };
        }

        public static explicit operator Point2D(double[] arr)
        {
            var p = new Point2D(0, 0);

            if (arr.Length > 0)
                p.x = arr[0];

            if (arr.Length > 1)
                p.y = arr[1];

            return p;
        }

        
    }
}
