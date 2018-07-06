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
        public void SetViewData(int? index)
        {
            var model = new Trainees();

            if (index == null)
                index = 1;

            model.SetSelected(index.Value);

            ViewData["Trainees"] = model.Items;
            ViewData["key"] = "AIzaSyAVZqCjMiB9lr32F7SIZn5fdnt9i4itTFo";
        }
    }
}