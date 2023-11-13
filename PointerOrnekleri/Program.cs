using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerOrnekleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                double a = 5;
                double* ptr1;
                ptr1 = &a;
                *ptr1 = 10;
                Console.WriteLine(a);
                Console.WriteLine((long)ptr1);

                char c = 'A';
                char* ptr2;
                ptr2 = &c;
                *ptr2 = 'S';
                Console.WriteLine(c);
                Console.WriteLine((long)ptr2);
                Console.WriteLine("-----------------------------");
                Console.Read();
            }
        }
    }
}
