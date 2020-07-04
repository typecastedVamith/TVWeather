using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace TVWeatherApp
{
    /*
     * This class reads from ndtv weather section and returns temperature from city mentioned in config file
     *  returns value in long
     */
    class NdtVWeather : WeatherForcast
    {
        public float humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public double temperatureInDegree()
        {
            var browser = ChromeBrowser.getInstance();
            browser.getDriver().Navigate().GoToUrl(Config.readNDTYWeatherUrl());
            BrowserUI UI = new BrowserUI();
            UI.click("Ndtv", "id", "NdtvPlaceHolder",0);
            UI.sendText("Ndtv", "id", "NdtvPlaceHolder", Config.readCity());
            UI.click("Ndtv", "xpath", "NdtvCityOnMap", 0, Config.readCity());
            Console.WriteLine(UI.extractText("Ndtv", "xpath", "NdtvCityTemperature").Replace("Temp in Degrees:","").Trim());
            return double.Parse(UI.extractText("Ndtv", "xpath", "NdtvCityTemperature").Replace("Temp in Degrees:", "").Trim());


        }

        public float windInKM()
        {
            throw new NotImplementedException();
        }
    }
}
