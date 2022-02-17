using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class Alarm
    {
        private int hour;
        public int Hour {get=>hour;set=>hour=value;}

        private int minute;
        public int Minute {get=>minute;set=>minute=value;}

        private List<Action> actions;

        public Alarm(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.actions= new List<Action>();
            ActionSpeak speak= new ActionSpeak(new String[]{"Bonjour", "Il est l'heure de se lever."});
            ActionUrl playlist= new ActionUrl(new String[]{"https://youtu.be/R9RtTGzs5EE"});
            ActionMeteo meteo= new ActionMeteo(new String[]{"b9200fb78d390b0bc6eedd24725e5f71", "Asniere"});
            actions.Add(speak);
            actions.Add(playlist);
            actions.Add(meteo);
        }

        public void observerThread(DateTime dt){
            if(dt.Hour.Equals(hour)&&
                dt.Minute.Equals(minute)){
                    foreach(Action action in actions){
                        action.execute();
                    }
            }
        }
    }
}