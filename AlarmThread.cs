using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class AlarmThread
    {

        private Thread thread;
        public delegate void onTimeChange(DateTime dt);
        public onTimeChange callback;

        public AlarmThread()
        {
            thread = new Thread(new ThreadStart(this.task));
        }

        public void task(){
            while(thread.IsAlive){          
                callback(DateTime.Now);
                Thread.Sleep(1000*60);
            }
        }

        public void start(){
            thread.Start();
        }

        public void stop(){
            thread.Interrupt();
        }
    }
}