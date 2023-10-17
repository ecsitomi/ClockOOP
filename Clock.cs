using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP
{
    internal class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string timeZone { get; set; }
        public bool is24HourFormat { get; set; }

        //public string Format { get; set; }

        public Clock (int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
            //Format = string.Empty;

            //Beállítja az órát ha nem 24 órás a formátum
            if (!is24HourFormat)
            {
                if (24 > Hour && Hour > 12)
                {
                    Hour -= 12;
                }
                else {
                    Console.WriteLine("Hibás időformátum!");
                }
            }

            //Ellenőrzi, hogy az HH-MM-SS értékek helyesek-e
            if (Hour > 24 || Hour < 0)
            {
                Console.WriteLine("Hibás az órák száma!");
            }
            if (Minute > 59 || Minute < 0) 
            {
                Console.WriteLine("Hibás a percek száma!");
            }
            if (Second > 59 || Second < 0)
            {
                Console.WriteLine("Hibás a másodpercek száma!");
            }
        }

        void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void DisplayTime()
        {
            // Próbálkoztam egy új adattaggal, de "assigned but never used" hibás, így hagytam

            //if (is24HourFormat) { string Format = "24 órás"; } else { string Format = "12 órás"; }
            //Console.WriteLine($"A beállított idő: {Hour}:{Minute}:{Second} \nIdőzóna: {timeZone}, Időformátum: {Format}");

            if (is24HourFormat)
            {
                Console.WriteLine($"{Hour}:{Minute}:{Second} \nIdőzóna: {timeZone}, Időformátum: 24 órás");
            } else
            {
                Console.WriteLine($"{Hour}:{Minute}:{Second} \nIdőzóna: {timeZone}, Időformátum: 12 órás");
            }
        }

        public void SetTimeZone(string timeZone) 
        {
            this.timeZone = timeZone;
        }

        public void ToggleTimeFormat()
        {
            if (is24HourFormat)
            {
                if (Hour > 12)
                {
                    Hour -= 12;
                }
            }
            else if (!is24HourFormat)
            { 
                if (Hour < 12)
                {
                    Hour += 12;
                }
            }
        }
    }
}
