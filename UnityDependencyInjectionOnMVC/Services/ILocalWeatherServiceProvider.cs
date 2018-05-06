using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDependencyInjectionOnMVC.Services
{
    public interface ILocalWeatherServiceProvider
    {
        string GetLocalWeatherByZipCode(int zipCode);
    }
}
