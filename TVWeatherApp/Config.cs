using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace TVWeatherApp
{
    public class Config
    {
        private static IWebDriver driver = ChromeBrowser.getInstance().getDriver();
        public static String readCity()
        {
            return  returnValue(ConfigVariable.city);
        }

        public static String readApi()
        {
            return returnValue(ConfigVariable.ApiKey);
        }

        public static String readOpenWeatherUrl()
        {
            return returnValue(ConfigVariable.OpenweathermapUrl);
        }

        public static String readNDTYWeatherUrl()
        {
            return returnValue(ConfigVariable.NDTYWeatherUrl);
        }

        private static String returnValue(String key)
        {
           return JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/config.json")).GetValue(key).ToString();
        }

        public static OpenQA.Selenium.By locator(String screen, String locatorType, String locator)
        {
            XmlDocument objectRepo = new XmlDocument();
            objectRepo.Load(Directory.GetCurrentDirectory() + "/" + screen + ".xml");
            XmlNode node = objectRepo.DocumentElement.SelectSingleNode("/class/" + locator);

            switch (locatorType)
            {
                case "id": return By.Id(node.Attributes[locatorType]?.InnerText);
                case "className": return By.ClassName(node.Attributes[locatorType]?.InnerText);
                case "xpath": return By.XPath(node.Attributes[locatorType]?.InnerText);
            }
            return null;
        }

        public static OpenQA.Selenium.By updateLocator(String screen, String locatorType, String locator, String Update)
        {
            XmlDocument objectRepo = new XmlDocument();
            objectRepo.Load(Directory.GetCurrentDirectory() + "/" + screen + ".xml");
            XmlNode node = objectRepo.DocumentElement.SelectSingleNode("/class/" + locator);
            switch (locatorType)
            {
                case "xpath": return By.XPath(node.Attributes[locatorType]?.InnerText.Replace("CITY", Update));
            }
            return null;
        }

    }
}
