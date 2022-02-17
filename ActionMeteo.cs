using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;


namespace MyAlarm // Note: actual namespace depends on the project name.
{
    public class ActionMeteo : Action
    {

        private String url="http://api.weatherstack.com/current?";
        private String key;
        private String location;
        public ActionMeteo(string[] args) : base(Action.TYPE_METEO, args)
        {
            key= args[0];
            location= args[1];
        }

        public override async void  execute()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{url}access_key={key}&query={location}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JsonTextReader reader = new JsonTextReader(new StringReader(responseBody));
            String currentParameter="";
            String[] texts= new string[2];
            while (reader.Read()){
                if (reader.Value != null)
                {
                    if(reader.TokenType.ToString().Equals("PropertyName")){
                        currentParameter= reader.Value.ToString();
                    }else if(currentParameter.Equals("temperature")
                                &&reader.TokenType.ToString().Equals("Integer")){
                        texts[0]= $"La température est de {reader.Value.ToString()}°C.";
                    }
                }
            }
            texts[1]="Voici la page des données météo.";
            ActionSpeak speak= new ActionSpeak(texts);
            speak.execute();
            ActionUrl pageMeteo= new ActionUrl(new string[]{$"https://www.google.com/search?q=meteo+{location}"});
            pageMeteo.execute();
        }
    }
}