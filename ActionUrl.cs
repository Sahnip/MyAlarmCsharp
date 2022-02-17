using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class ActionUrl : Action
    {
        public ActionUrl(string[] args) : base(Action.TYPE_URL, args)
        {
        }

        public override void execute()
        {
            foreach(String text in args){
                Console.WriteLine($"start: {text}");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = text;
                System.Diagnostics.Process.Start(psi);
            }
        }
    }
}