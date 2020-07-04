﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TVWeatherApp
{
    class BrowserUI
    {
        private IWebDriver Driver = ChromeBrowser.getInstance().getDriver();
        
        public void click(String screen, String locatorType, String locator, int index)
        {
            Driver.FindElement(Config.locator(screen,locatorType,locator)).Click();
        }

        public void click(String screen, String locatorType, String locator, int index, String updateparam)
        {
            Driver.FindElement(Config.updateLocator(screen, locatorType, locator, updateparam)).Click();
        }

        public void sendText(String screen, String locatorType, String locator, String text)
        {
            Driver.FindElement(Config.locator(screen, locatorType, locator)).SendKeys(text);
        }

        public String extractText(String screen, String locatorType, String locator)
        {
            return Driver.FindElement(Config.locator(screen, locatorType, locator)).Text;
        }
    }
}
