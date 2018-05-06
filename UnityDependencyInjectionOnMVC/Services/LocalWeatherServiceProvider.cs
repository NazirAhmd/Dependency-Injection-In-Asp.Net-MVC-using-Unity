using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDependencyInjectionOnMVC.Services
{
    public class LocalWeatherServiceProvider : ILocalWeatherServiceProvider
    {
        public string GetLocalWeatherByZipCode(int zipCode)
        {
            return "The Weather at zip code " + zipCode + "is cloudy";
        }
    }
}