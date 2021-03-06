﻿using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TVWeatherApp
{
    /*
     *   This class reads temperature from getcall of openweather api and returns value in long format
     *   Only temperature implementation is used,others are not implemented
     */
    class OpenWeatherMap : WeatherForcast
    {
        public float humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public double temperatureInDegree()
        {
            return double.Parse(JObject.Parse(requestWeatherForCity())["main"]["temp"].ToString().Trim()) - 273.15;
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
