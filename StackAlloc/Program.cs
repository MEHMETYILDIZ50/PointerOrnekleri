using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAlloc
{
    class Program
    {
       unsafe static void Main(string[] args)
        {
            Console.WriteLine("Dizi boyutu gir:");
            int boyut = 0;
            try
            {
                boyut = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            int* dizi= stackalloc int[boyut];
            for (int i = 0;i<boyut;i++)
            {
                *(dizi + i) = i;
                Console.WriteLine(dizi[i]);
                Console.WriteLine((long)(dizi+i));
            }
            Console.ReadLine();
        }
    }
}
