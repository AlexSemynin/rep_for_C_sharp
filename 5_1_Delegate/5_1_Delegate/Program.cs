using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Delegate
{
    class Program
    {
        public delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Mass mas = new Mass();
                //Делегат указывает на метод, определенный в классе
            Operation op = mas.Sum;
            int result = op(4, 5);
            Console.WriteLine(result);



                //Делегат указывает на простой метод
            Operation op1 = Sum;
            int res1 = op1(1, 3);
            Console.WriteLine(res1);

                //создание делегата с помощью конструктора, где в качестве параметра передается метод
            Operation op2 = new Operation(Sum);
            Operation op3 = new Operation(mas.Sum);
            Console.WriteLine($"{op2(10, 10)}\t" + $"{op3(20, 20)}");
            Console.ReadKey();

            //Если делегат пуст, то его значение = null !!!!!

            //Делегаты можно объединять 
            Operation opComm = op2 + op3;

            //В делегаты можно добавлять методы
            op2 += Sum; //Вызов методов что в объединении, что при добавлении будет последовательным.
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        class Mass
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}
