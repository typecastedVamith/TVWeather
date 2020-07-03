using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace TVWeatherApp
{
    public class Config
    {
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
            return returnValue(ConfigVariable.OpenweathermapUrl);
        }

        private static String returnValue(String key)
        {
           return JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "/config.json")).GetValue(key).ToString();
        }
    }
}
