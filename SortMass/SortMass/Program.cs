using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMass
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthMass = 5;
            int[] NameArray = new int[lengthMass];
            for(int i = 0; i < lengthMass; i++)
            {
                NameArray[i] = i+1;
            }
            for(int i = 0; i < lengthMass; i++)
            {
                Console.WriteLine(NameArray[i]);
            }

            ////Многомерные массивы
            //int[,] BigMass = new int[1, 2];
            //int[,] BigMass1 = new int[,] { { }, { } };
            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j < 4; i++)
            //    {
            //        BigMass1[i, j] = i;
            //        Console.Write(BigMass1[i, j]);
            //    }
            //}
            
            //ЗАДАЧИ С МАССИВАМИ
            Console.ReadKey();
        }
    }
}
