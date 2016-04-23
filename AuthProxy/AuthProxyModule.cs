using System;
using System.Net;

namespace AuthProxy
{
    public class AuthProxyModule : IWebProxy
    {
        ICredentials crendential = new NetworkCredential("USER", "PASS");

        public ICredentials Credentials
        {
            get
            {
                return crendential;
            }
            set
            {
                crendential = value;
            }
        }

        public Uri GetProxy(Uri destination)
        {
            return new Uri("http://YOUR_HOST:PORT", UriKind.Absolute);
        }

        public bool IsBypassed(Uri host)
        {
            return host.IsLoopback;
        }

    }
}