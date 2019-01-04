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

            {
                //switch
                Console.WriteLine("Нажмите Y или X");
                string letter = Console.ReadLine();
                switch (letter)
                {
                    case "Y":
                        Console.WriteLine("Вы нажали Y");
                        break;
                    case "X":
                        Console.WriteLine("Вы нажали X");
                        break;
                    default:
                        Console.WriteLine("Неизвестно");
                        break;
                }

                //Оператор goto case вместо break;
                int number = 1;
                switch (number)
                {
                    case 1:
                        goto case 5;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 5:
                        Console.WriteLine("Переход выполнени успешно");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }

            }

            {
                //Тенарная операция
                int x = 3;
                int y = 2;
                Console.WriteLine("Нажмите + или -");
                string selection = Console.ReadLine();
                int z = selection == "+" ? (x + y) : (x - y);
                Console.WriteLine(z);
            }

            Console.ReadKey();
        }
    }
}
