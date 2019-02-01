using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_Cycles_vs_Struct_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();
            state1.m = 1;
            state1.n = 2;
            state2.m = 3;
            state2.n = 4;

            state1 = state2;
            state2.m = 5;
            Console.WriteLine(state1.m);
            Console.WriteLine(state2.m);
            Console.ReadKey();

            Country country2 = new Country();
            Country country3 = new Country();
            country2.x = 5;
            country3.x = 6;
            country2 = country3;
            country2.x = 7;
            Console.WriteLine(country2.x);
            Console.WriteLine(country3.x);
            Console.ReadKey();
        }
    }
    class Country
    {
        public int x;
        public int y;
    }
    struct State
    {
        public int m;
        public int n;
        public Country contry1;
    }
}