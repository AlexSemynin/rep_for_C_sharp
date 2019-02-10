using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancLibrary
{
    //Для реакции на изменения состояния счеты мы будем использовать событийную модель.
    //Делегат:
    public delegate void AccountStateHandler(object sender); // Делегат будет использоваться для создания событий
    //вспомогательный класс
    public class AccountEventsArgs  //для обработки событий
    {
        //аксессоры
        public string Message { get; private set; } //Cообщение
        public decimal Sum { get; private set; } //Cумма, на которую изменился счет

        //конструктор
        public AccountEventsArgs(string _mes, decimal _sum)
        {
            Sum = _sum;
            Message = _mes;
        }
    }


}
