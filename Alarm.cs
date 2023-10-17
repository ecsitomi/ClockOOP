using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP
{
    internal class Alarm
    {
        public int alarmHour {  get; set; }
        public int alarmMinute { get; set; }
        public bool isAlarmOn { get; set; }

        public Alarm(int alarmHour, int alarmMinute)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
        }

        public void SetAlarm(int hour, int minute)
        { 
            this.alarmHour = hour;
            this.alarmMinute = minute;
            //azért this mert máshol is lehet alarmHour v. Minute és így egyértelmű legyen
        }

        public void TurnOnAlarm()
        { 
            this.isAlarmOn = true;
        }

        public void TurnOffAlarm()
        {
            this.isAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute) 
        {
            if (this.alarmHour == hour && this.alarmMinute == minute) 
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
