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
            dynamic weatherResults = JObject.Parse(results);
            Console.WriteLine($"Temperature: " + weatherResults.main.temp + " Celcius");
            Console.WriteLine($"Pressure: " + weatherResults.main.pressure + " hPa");
            Console.WriteLine($"Humidity: " + weatherResults.main.humidity + " %");
            Console.WriteLine($"Visibility: " + weatherResults.visibility + " m");
            Console.WriteLine($"Description: " + weatherResults.weather[0].description);

            Console.ReadLine();

        }

       
    }
}
