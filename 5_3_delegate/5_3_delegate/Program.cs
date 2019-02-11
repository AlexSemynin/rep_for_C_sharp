using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.RegisterHandler(Display); //теперь делегат будет указывать на метод Display 
            account.Put(100);
            account.Widthdraw(100);
            account.Widthdraw(150);
            Console.ReadKey();
        }
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
    public delegate void AccountStateHandler(string messege); //Здесь он будет принимать то уведомление, которое мы хотим отправлять пользователю   
                                                              //Внешний код сам будет определять те действия, которые должны выполняться
    class Account
    {
        //Определим переменную данного делегата
        AccountStateHandler _del;
        //чтобы переменную можно было восстановить, определим метод, через который будем передавать объект данного делегата
        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;                     //Здесь мы не знаем, что это за действие. Мы только знаем, что это децствие представляет метод, которы принимает строку
        }
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            _sum += sum;
            if (_del != null)
                _del($"На счет пришло {sum}"); //в делегат мы передаем сообщение.
            // Console.WriteLine($"На счет пришло {sum}");       //Здесь вместо вывода на консоль мы будем уведомлять внешний код при помощи delegate
        }
        public void Widthdraw(int sum)
        {
            if(sum <= _sum)
            {
                _sum -= sum;
                if (_del != null)
                    _del($"Списание {sum}"); // del же отвечает за метод
                //Console.WriteLine($"Списание {sum}");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно средств");
            }
        }
    }
}
