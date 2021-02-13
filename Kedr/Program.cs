using System;

namespace Kedr
{
    class Program
    {
        static void Main(string[] args)
        {
            Vrem p = new Vrem(14, 11, 22);
            p.Display();
            DateTime d = new DateTime(2021, 1, 31, 14, 33, 29);
            
            Trains t = new Trains(14, 11, 22, "324556", "Светлогорск",new DateTime(2021, 1, 31, 14, 33, 29),1);
            t.Display();
        }
    }
}
