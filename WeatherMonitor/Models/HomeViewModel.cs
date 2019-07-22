using System;

namespace WeatherMonitor.Models
{
    public class HomeViewModel
    {
        public string appVersion { 
            get => Environment.GetEnvironmentVariable("APPVERSION");
         }
    }
}