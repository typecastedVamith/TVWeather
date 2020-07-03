using System;
using System.Collections.Generic;
using System.Text;

namespace TVWeatherApp
{
    interface WeatherForcast
    {
        public float temperatureInDegree();
        public float humidityInPercentage();
        public float windInKM();
        
    }
}
