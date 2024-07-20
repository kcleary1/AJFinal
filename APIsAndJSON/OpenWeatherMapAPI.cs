using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        

        public static async Task CurrentWeatherForGivenCity()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("What city would you like to check the weather in?");
                var cityName = Console.ReadLine();
                Console.WriteLine("Okay. What state is that located in? Please use the two-letter state code for your input.");
                var stateCode = Console.ReadLine();

                var apiKey = "c7141a1fd47b1c993dafd2e8765ef7a1";
                var tempURL = $"http://api.openweathermap.org/data/2.5/weather?q={cityName},{stateCode},US&appid={apiKey}&units=imperial";


                var response = await client.GetStringAsync(tempURL);
                var weatherData = JObject.Parse(response);

                var tempActual = weatherData["main"]["temp"].ToString();
                var weatherDescription = weatherData["weather"][0]["description"].ToString();

                Console.WriteLine($"The current temperature in {cityName}, {stateCode} is {tempActual}°F with {weatherDescription}.");

            }
        }
    }
}

    

