using System;
using System.Collections.Generic;
using System.Text;

namespace Kedr
{
    class Trains:Vrem
    {
        private string Number { get; set; }
        private string Direction { get; set; }
        private DateTime Date { get; }
        private int Timeres { get; set; }
        public Trains(int hourses,int minutes,int seconds,string number,string direction,DateTime date,int timeres) : base(hourses,minutes,seconds)
        {
            this.Number = number;
            this.Direction = direction;
            this.Date = date;
            this.Timeres = timeres = date.Minute - Minutes;
            int res = timeres;
        }
        
        public new void Display()
        {
            Console.WriteLine("Поезд: "+Number+" | Направление: "+Direction+" | Дата и время отправления: "+Date+" | Время до приезда: " +Timeres+ " минуты");
        }
    }
}
