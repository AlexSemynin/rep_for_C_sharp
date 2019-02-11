using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            // Добавляем обработчики события
            account.Added += Messege;
            account.Withdrawn += Messege;

            //вызываем методы
            account.Put(50);
            account.Withdraw(100);
            Console.ReadKey();
        }
        public static void Messege(string mess)
        {
            Console.WriteLine(mess);
        }
    }
    //public delegate void MessegeHandler(string message);
    class Account
    {
        //Обхявляем делегат
        public delegate void MessegeHandler(string message);
        //События при выводе и добавлении денег
        public event MessegeHandler Withdrawn;
        public event MessegeHandler Added;


        int _sum;

        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum { get; }
        public void Put(int sum)
        {
            _sum += sum;
            Added($"Вам поступило на счет {sum}rub");
        }
        public void Withdraw(int sum)
        {
            _sum -= sum;
            Withdrawn($"Списание {sum}rub");
            Withdrawn($"Остаток {_sum}rub");
        }
    }
}

//Собития мы можем объявлять и вызывать только из класса или структуры!
