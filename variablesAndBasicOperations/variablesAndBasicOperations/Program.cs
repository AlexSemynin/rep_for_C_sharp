using System;

namespace variablesAndBasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Hello, World";
            {
                Console.Write(hello + "\n");
                Console.Write("by, World\n");
            }

            //Консольный вывод

            string name = Console.ReadLine();
            int age = 15;
            double weight = 73.5;
              Console.Write($"Имя : {name}\n");
              Console.WriteLine("Возраст: {0}, Вес: {1}", age, weight);
            Console.WriteLine("Введите рост: ");

              decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Рост: {height}м");
              Console.ReadKey();


            {
                //Арифметика
                double z = 10.0 % 4;
                  Console.WriteLine(z);
                int x = 5;
                int y = ++x;
                Console.WriteLine("\t x = 5; y = ++x");
                Console.WriteLine($"x = {x}, y = {y}");

                x = 5;
                y = x++;
                Console.WriteLine("\t x = 5; y = x++");
                Console.WriteLine($"x = {x}, y = {y}");
                Console.ReadKey();

            }

            {
                //Логические операции - поразрядовые
                int i = 5; //101 
                int j = 3; //110
                Console.WriteLine(i | j); // | - Логическое ИЛИ 111 => выведет 7
                Console.WriteLine(i & j); // & - Логическое И 100 => выведет 4
                Console.ReadKey();
                // Операции присваивания - правоассоциативные
                int a, b, c;
                a = 8; b = 6; c = a += b -= 5;
                Console.WriteLine(c);
                Console.ReadKey();
                {
                    // Условные выражения
                    bool c1 = (5 < 6) || (6 < 5); //true 
                    // || Отличается от | тем, что при || если одно значение true то второе не вычисялется. То же самое и с && и &.
                    Console.WriteLine(c1);
                    Console.ReadKey();
                }

            }
        }
    }
}
