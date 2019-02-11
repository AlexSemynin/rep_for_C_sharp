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
            //Регистрируем делегат - передаем ему на какой метод будет ссылаться
            account.RegisterHendler(Messege);
            account.Put(100);
            account.Withdraw(200);
            Console.ReadKey();
        }
        public static void Messege(string mess)
        {
            Console.WriteLine(mess);
        }
    }
    public delegate void MessegeHandler(string message);
    class Account
    {
        MessegeHandler _del;
        int _sum;

        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum { get; }
        public void Put(int sum)
        {
            _sum += sum;
            _del($"Вам поступило на счет {sum}rub");
        }
        public void Withdraw(int sum)
        {
            _sum -= sum;
            _del($"Списание {sum}rub");
            _del($"Остаток {_sum}rub");
        }
        public void RegisterHendler(MessegeHandler del)
        {
            _del += del;
        }
    }
}
