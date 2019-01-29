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
            {
                int area;
                double perimetr;
                Calculate(3, 4, out area, out perimetr);
                Console.Write($"периметр: {perimetr} \n Площадь: {area}");
            }
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
        static void Calculate(int x, int y, out int area, out double perimetr)
        {
            area = x * y;
            perimetr = (x + y) / 2;
        }
        
    }
}
