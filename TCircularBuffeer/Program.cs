using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCircularBuffeer
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircularBuffer cb = new TCircularBuffer();
            for (int i = 0; i < 2; ++i )
                cb.Insert(i);
            cb.Remove();

            
        }

        void A<T>(T variable) where T:class
        {
            long k = sizeof(T);
        }
    }
}
