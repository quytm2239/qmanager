using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QManager.Services.HTTP_API;

namespace QManager
{
    public class AppStatus
    {
        public string RememberUsername = null;
        public string RememberPassword = null;
        public bool isAuthorized = false;

        public AppStatus()
        {
            isAuthorized = HTTPClientManager.Shared().hasToken;
        }
    }
}
