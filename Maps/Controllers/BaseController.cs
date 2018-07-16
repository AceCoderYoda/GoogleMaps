#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.BaseController.cs
// Created On    ::    05/07/2018 07:30
// Altered On    ::    05/07/2018 07:31
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Mvc;
using System.Web.UI;
using Maps.Data;

#endregion

namespace Maps.Controllers
{
    public class BaseController : Controller
    {
        private readonly Factory factory;
        public Factory Factory => factory;

        public BaseController()
        {
            if (factory == null)
            {
                factory = new Factory();
                factory.Initialize();
            }
            else
            {
                factory.Update();
            }
        }

        public void SetViewData(string id)
        {
           if (string.IsNullOrEmpty(id))
                id = Factory.FirstOrDefault().Id;

            ViewData["markers"] = Factory.Markers();
            ViewData["id"] = id;
            ViewData["key"] = "AIzaSyAVZqCjMiB9lr32F7SIZn5fdnt9i4itTFo";
        }
    }
}