using System;
using System.Collections.Generic;
using System.Text;

namespace Kedr
{
    class Vrem
    {
        private int hourses;
        private int minutes;
        private int seconds;
        public Vrem(int hourses)
        {
            this.Hourses = hourses;
        }
        public Vrem(int hourses, int minutes) : this(hourses)
        {
            this.Minutes = minutes;
        }
        public Vrem(int hourses,int minutes,int seconds) : this(hourses,minutes)
        {
            this.Seconds = seconds;
        }
        public int Hourses
        {
            get { return hourses; }
            set
            {
                if (value > 0 && value < 24) ;
                hourses = value;
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value > 0 && value < 60) ;
                minutes = value;
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value > 0 && value < 60) ;
                seconds = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Время в Калининграде: "+Hourses+"ч "+Minutes+"м "+Seconds+"c");
        }
    }
}
