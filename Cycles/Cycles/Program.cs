using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                if(i == 2)
                {
                    continue;
                }
                Console.Write($"i = {i}, result ={i * i}\n");
            }
            Console.ReadKey();

            // выполняется пока условие == True
        }
    }
}
