using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //вызов метода
            SayHello();
            string str = GetBy();
            Console.WriteLine(str);

            int result = SumPlusZ(1, 2);
            int result1 = SumPlusZ(1, 2, 3);
            Console.WriteLine($"{result} + {result1}");
            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }
        static string GetBy()
        {
            return "by, World";
        }
        //параметры
        static int SumPlusZ(int x, int y, int z = 1)
        {
            return x + y + z;
        }
    }
}
