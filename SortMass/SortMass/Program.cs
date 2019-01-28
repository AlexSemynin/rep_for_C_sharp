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

            // 1 Найдем количество положительных чисел в массиве:
            int[] NameOfMass = { 3, 2, -1, 4, -3, -1, 5, 5 };
            int kolElements = 0;
            foreach(int number in NameOfMass)
            {
                if(number < 0)
                {
                    kolElements++;
                }
            }
            Console.WriteLine($"Колличество отрицательных элементов в массиве = {kolElements}");

            // 2 Сортировка массива
            Console.WriteLine("Введите количество элементов массива");
            int lengthOfMass = Convert.ToInt32(Console.ReadLine());
            int[] myMass = new int[lengthOfMass];
            for(int i = 0; i < lengthOfMass; i++)
            {
                Console.Write($"Введите {i}-й эллемент массива: \t");
                myMass[i] = Convert.ToInt32(Console.ReadLine());

            }

            int temp;
            for (int i = 0; i < myMass.Length - 1; i++)
            {
                for (int j = i + 1; j < myMass.Length; j++)
                {
                    if (myMass[i] > myMass[j])
                    {
                        temp = myMass[i];
                        myMass[i] = myMass[j];
                        myMass[j] = temp;
                    }
                }
            }

            for (int i = 0; i < myMass.Length; i++)
            {
                Console.WriteLine(myMass[i]);
            }

            Console.ReadKey();
        }
    }
}
