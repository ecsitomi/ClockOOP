using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat 1
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);

            //Feladat 2
            List<Alarm> lista = new List<Alarm>();
            Alarm ebreszto1 = new Alarm(6, 0);
            Alarm ebreszto2 = new Alarm(8, 0);
            lista.Add(ebreszto1);
            lista.Add(ebreszto2);

            //Feladat 3
            Timer myTimer = new Timer(10);

            //Feladat 4
            Console.WriteLine($"Az aktuális idő:");
            myClock.DisplayTime(); //a Feladat 1 órámat átneveztem myClock-nak

            //Feladat 5
            foreach(Alarm alarm in lista) 
            {
                bool megszolalE = alarm.IsAlarmTime(myClock.Hour,myClock.Minute);
                if (megszolalE) //csak hogy szebben nézzen ki
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
                else 
                {
                    Console.WriteLine("Az ébresztő nem szólalt meg."); //csak hogy adjon vissza választ teszteléskor
                }
            }

            //Feladat 6
            myTimer.StartTimer();

            //Feladat 7
            Console.WriteLine("Feladatsor lefuttatva, minden működött."); //az óra ellenőrzését 25 órával is kipróbáltam, működött az ellenőrzés
            Console.ReadLine();
        }
    }
}
