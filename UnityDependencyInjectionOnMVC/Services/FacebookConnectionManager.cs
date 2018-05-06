using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDependencyInjectionOnMVC.Services
{
    public class FacebookConnectionManager : IFacebookConnectionManager
    {
        private readonly string _userName;
        private readonly string _authenticationToken;
        private readonly string _facebookUrl;
        public FacebookConnectionManager(string userName, string authenticationToken, string facebookUrl)
        {
            this._userName = userName;
            this._authenticationToken = authenticationToken;
            this._facebookUrl = facebookUrl;
        }
        public bool Authenticate()
        {
            if (!string.IsNullOrEmpty(_userName)
                && !string.IsNullOrEmpty(_authenticationToken)
                && !string.IsNullOrEmpty(_facebookUrl))
            {
                return true;
            }
            else
                return false;
        }
    }
}