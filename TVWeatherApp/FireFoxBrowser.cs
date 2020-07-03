using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TVWeatherApp
{
    public sealed class FireFoxBrowser
    {
        static FireFoxBrowser init = new FireFoxBrowser();
        private IWebDriver driver;
        FireFoxBrowser()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        public static FireFoxBrowser getInstance()
        {
            return init;
        }
        public  IWebDriver getDriver()
        {
            return driver;
        }
    }
}
