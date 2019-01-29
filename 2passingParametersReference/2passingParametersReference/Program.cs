using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2passingParametersReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 1;
            Increment(a);
            Console.WriteLine($"переменная по значению {a}\n");
            IncrementREF(ref b);
            Console.WriteLine($"переменная по ccылке в Main {b}");
            Console.ReadKey();
        }
        static void Increment(int a)
        {
            a++;
            Console.WriteLine(a);
        }
        static void IncrementREF(ref int a)
        {
            a++;
            Console.WriteLine($"переменная по ссылке в методе {a}");
        }
    }
}
