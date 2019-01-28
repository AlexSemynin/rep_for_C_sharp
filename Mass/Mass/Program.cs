using System;

namespace Mass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива:
            int[] num2; //Здесь не выделяем память под количество элементов массива(типа динамический)
            int[] num3 = { 1, 2, 3, 4 };

            int[] num1 = new int[4];    // int[] - тип перемменных в массиве; new int[4] - Выделение памяти для 4 элементов. т.е. длинны массива
            num1[0] = 5;
            num1[1] = 3;
            num1[2] = 2;
            num1[3] = 1;
 
            //перебор элементов массива
            foreach(int i in num1)
            {
                Console.WriteLine($"{i}");
            }

            for(int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine($"{num1[i]}");
            }


            // Многомерные массивы
            int[,] numsM = { { 1, 2, 3, }, { 4, 5, 6, } };
            Console.WriteLine(numsM);
            Console.ReadKey();
        }
    }
}
