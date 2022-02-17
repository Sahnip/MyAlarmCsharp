using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public abstract class Action
    {
        public static String TYPE_SPEAK= "speak";
        public static String TYPE_METEO= "meteo";
        public static String TYPE_URL= "url";

        protected String type;

        protected String [] args;

        public Action(String type, String[] args){
            this.type= type;
            this.args= args;
        }

        public abstract void execute();
    }
}