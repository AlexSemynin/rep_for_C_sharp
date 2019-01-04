using System;

namespace ifWhileForList
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Условные конструкции
                int num1 = 8;
                int num2 = 4;
                if(num2 > num1)
                {
                    Console.WriteLine(num2 > num1);
                }
                else if(num1 > num2)
                {
                    Console.WriteLine(num1 > num2);
                }
                else
                {
                    Console.WriteLine("Упс");
                }
            }
            Console.ReadKey();
        }
    }
}
