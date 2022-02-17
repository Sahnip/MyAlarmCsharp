using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class Program
    {

        [STAThread]
        static void Main()
        {
            Alarm alarm= new Alarm(7,0);
            AlarmThread alarmThread= new AlarmThread();
            alarmThread.callback+= new AlarmThread.onTimeChange(alarm.observerThread);
            alarmThread.start();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyAlarmForm());
        }
    }
}