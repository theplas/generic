using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
    public class MyGeneric<T>
    {
        public T a;
        public T b;
        public void SoSanh<T>(T a,T b)
        {
            if (a.Equals(b))
            {
                
                Console.WriteLine($"{a}bang {b}");
            }
            else
            {
                
                Console.WriteLine($"{a} khong bang {b}");
            }
        }
    }
}