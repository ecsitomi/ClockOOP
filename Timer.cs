using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP
{
    internal class Timer
    {
        public int remainingSeconds { get; set; }
        
        public Timer(int remainingSeconds)
        {
            this.remainingSeconds = remainingSeconds;
        }

        public void SetTime(int seconds) 
        {
            this.remainingSeconds = seconds;
        }

        public void StartTimer()
        { 
            while (this.remainingSeconds > 0) 
            {
                Console.WriteLine(this.remainingSeconds);
                this.remainingSeconds -= 1;
            }
            Console.WriteLine("Az időzítés véget ért.");
        }

    }
}
