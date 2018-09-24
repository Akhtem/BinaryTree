using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    public class OwnArray<T>:IEnumerable<T>
    {
        T[] data;
        int start;
        int end;
        public OwnArray(int from, int to)
        {
            if (to <= from) throw new ArgumentException("Range error");
            start = from;
            end = to;
            data = new T[to - from];
        }

        public int Length
        {
            get { return data.Length; }
        }

        public void Sort()
        {
            Array.Sort(data);
        }
        public T this[int index]
        {
            get
            {
                if (index < start || index >= end)
                {
                    throw new IndexOutOfRangeException();
                }
                return data[index - start];
            }
            set
            {
                if (index < start || index >= end)
                {
                    throw new IndexOutOfRangeException();
                }
                data[index - start] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }
    }
}
