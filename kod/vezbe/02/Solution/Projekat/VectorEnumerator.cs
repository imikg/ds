using System;
using System.Collections;

namespace Projekat
{
    class VectorEnumerator : IEnumerator
    {
        Vector vector;
        int index = -1;

        public VectorEnumerator(Vector vector)
        {
            this.vector = vector;
        }

        // public object Current => vector.data[index];

        public object Current
        {
            get
            {
                return vector.data[index];
            }
        }

        public bool MoveNext()
        {
            return ++index < vector.data.Length;
        }

        public void Reset() {
            index = -1;
        }
    }
}
