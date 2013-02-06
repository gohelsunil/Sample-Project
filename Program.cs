using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleForNexSales
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1 ; i <=100; i++)
            {
                var ss = (((i % 3) == 0) ? "sun" : "") + ((i.ToString().EndsWith("3")) ? "burn" : "");
                Console.WriteLine((string.IsNullOrEmpty(ss))?i.ToString() : ss);
            }
            Console.ReadKey();
        }
    }
}
