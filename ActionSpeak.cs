using System;
using System.Collections.Generic;
using System.Speech.Synthesis;


namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class ActionSpeak : Action
    {

        SpeechSynthesizer synth = new SpeechSynthesizer();  
        public ActionSpeak(string[] args) : base(Action.TYPE_SPEAK, args)
        {
            synth.SetOutputToDefaultAudioDevice();  
        }

        public override void execute()
        {

            foreach(String text in args){
                Console.WriteLine($"merry: {text}");
                synth.Speak(text);
            }
        }
    }
}