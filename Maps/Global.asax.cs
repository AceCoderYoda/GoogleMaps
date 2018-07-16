#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Global.asax.cs
// Created On    ::    05/07/2018 07:14
// Altered On    ::    16/07/2018 08:25
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

#endregion

namespace Maps
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}