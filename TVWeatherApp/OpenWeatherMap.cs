using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TVWeatherApp
{
    class OpenWeatherMap : WeatherForcast
    {
        public float humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public float temperatureInDegree()
        {
            return float.Parse(JObject.Parse(requestWeatherForCity())["main"]["temp"].ToString().Trim());
        }

        public float windInKM()
        {
            throw new NotImplementedException();
        }

        private String requestWeatherForCity()
        {
            var client = new RestClient(Config.readOpenWeatherUrl());
            var request = new RestRequest("?q=" + Config.readCity() + "&appid=" + Config.readApi(), Method.GET);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
