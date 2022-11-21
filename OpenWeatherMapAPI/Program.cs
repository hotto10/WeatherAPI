using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;
using System.IO;


namespace OpenWeatherMapAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = System.IO.File.ReadAllText("appsettings.json");
            
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine();
            Console.WriteLine("Enter a zipcode to check for weather");
            var zipCode = Console.ReadLine();
            Console.WriteLine();
            

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine($"It is {WeatherMap.GetTemp(weatherURL)} degrees outside");
        }
    }
}