using System;
using System.Collections;

namespace Projekat
{
    class Vector : IEnumerable
    {
        public double[] data;

        public Vector(double[] data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            string el = "";

            for (int i = 0; i < data.Length; i++)
            {
                el += data[i] + " ";
            }

            return base.ToString() + " : " + el;
        }

        public IEnumerator GetEnumerator()
        {
            return new VectorEnumerator(this);
        }

        // == Indekseri ==

        public double this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public double[] this[int first, int last]
        {
            get
            {
                int len = last - first + 1;
                double[] sub = new double[len];

                for (int i = 0; i < len; i++)
                {
                    sub[i] = data[first + i];
                }

                return sub;
            }
        }
    }
}
