using System;
using System.Collections.Generic;
using System.Text;

namespace TVWeatherApp
{
    interface WeatherForcast
    {
        public double temperatureInDegree();
        public float humidityInPercentage();
        public float windInKM();
        
    }
}
