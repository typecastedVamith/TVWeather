using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TVWeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForcast openWeatherApi = new OpenWeatherMap();
            WeatherForcast ndtvTemp = new NdtVWeather();
            var ndtv = ndtvTemp.temperatureInDegree();
            var openwdrTemp = openWeatherApi.temperatureInDegree();
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Temperature fromNDTV :" + ndtv + " Temperature from openweatherapi :" + openwdrTemp+" Configured threshold Range: "+Config.readComparatorThreshold());
            Assert.IsTrue(Config.calculateThreshold(ndtv, openwdrTemp), "Temperature is not within the threshold range");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
