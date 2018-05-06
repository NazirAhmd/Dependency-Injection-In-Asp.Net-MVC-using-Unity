using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDependencyInjectionOnMVC.Services;

namespace UnityDependencyInjectionOnMVC.Controllers
{
    public class UnityController : Controller
    {
        private readonly ILocalWeatherServiceProvider _localWeatherServiceProvider;
        private readonly IFacebookConnectionManager _facebookConnectionManager;

        //public UnityController()
        //{
        //    _localWeatherServiceProvider = new LocalWeatherServiceProvider();//ctor is creating the object,we want to give this responsibility to some other framework/external class.

        //}
        public UnityController(ILocalWeatherServiceProvider localWeatherServiceProvider
            , IFacebookConnectionManager facebookConnectionManager)
        {
            _localWeatherServiceProvider = localWeatherServiceProvider;
            _facebookConnectionManager = facebookConnectionManager;
        }
        public ActionResult Index()
        {
            if (_facebookConnectionManager.Authenticate())
            {
                string weatherReport = _localWeatherServiceProvider.GetLocalWeatherByZipCode(12345);
            }
            return View();
        }
    }
}