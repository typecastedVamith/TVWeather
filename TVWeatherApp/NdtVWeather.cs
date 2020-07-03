using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace TVWeatherApp
{
    class NdtVWeather : WeatherForcast
    {
        public float humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public float temperatureInDegree()
        {
            //   var browser = FireFoxBrowser.getInstance();
            //   browser.getDriver();
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

            throw new NotImplementedException();
        }

        public float windInKM()
        {
            throw new NotImplementedException();
        }
    }
}
