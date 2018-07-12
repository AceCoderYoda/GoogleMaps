#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.BaseController.cs
// Created On    ::    05/07/2018 07:30
// Altered On    ::    05/07/2018 07:31
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Mvc;
using Maps.Data;

#endregion

namespace Maps.Controllers
{
    public class BaseController : Controller
    {
        public void SetViewData(string id)
        {
            var factory = new Factory();
            factory.Initialize();

            if (string.IsNullOrEmpty(id))
                id = factory.FirstOrDefault().Id;

            factory.SetSelected(id);

            ViewData["markers"] = factory.Markers();
            ViewData["id"] = id;
            ViewData["key"] = "AIzaSyAVZqCjMiB9lr32F7SIZn5fdnt9i4itTFo";
        }
    }
}