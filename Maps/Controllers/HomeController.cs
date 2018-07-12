#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.HomeController.cs
// Created On    ::    05/07/2018 07:14
// Altered On    ::    05/07/2018 07:35
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Mvc;

#endregion

namespace Maps.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string id= "")
        {
            SetViewData(id);
            return View();
        }


    }
}