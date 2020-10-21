using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace Weather
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string results;
            Console.WriteLine("Current weather in Cracow Poland");

            using (WebClient client = new WebClient())

            results = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=cracow&appid=085f4e9a1bb01af375c061ffa74b3886&units=metric");
            dynamic jo = JObject.Parse(results);
            Console.WriteLine($"Temperature: " + jo.main.temp + " Celcius");

        }

       
    }
}
