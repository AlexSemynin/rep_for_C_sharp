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
    }
}
