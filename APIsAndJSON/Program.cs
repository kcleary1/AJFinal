﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace APIsAndJSON
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            KanyeAndRon.KanyeRonConversation();

            await OpenWeatherMapAPI.CurrentWeatherForGivenCity();



        }
    }
}
