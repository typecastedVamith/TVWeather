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
            var browser = ChromeBrowser.getInstance();
            browser.getDriver().Navigate().GoToUrl(Config.readNDTYWeatherUrl());
            BrowserUI UI = new BrowserUI();
            UI.click("Ndtv", "id", "NdtvPlaceHolder",0);
            UI.sendText("Ndtv", "id", "NdtvPlaceHolder", "Mumbai");

            throw new NotImplementedException();
        }

        public float windInKM()
        {
            throw new NotImplementedException();
        }
    }
}
