using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Delegate_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем банковскхий счет
            Account acc = new Account(200);
            //делегат передаем в качесве параметра в RegisterHandler
            acc.RegisterHAndler(new Account.AccountStateHandler(ShowMessege)); //где в сам делегат добавляем ссылку на ShowMessege.
            acc.Withdraw(100);
            acc.Withdraw(200);
            Console.ReadKey();

        }
        public static void ShowMessege(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}
