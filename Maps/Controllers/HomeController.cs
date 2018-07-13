#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.HomeController.cs
// Created On    ::    05/07/2018 07:14
// Altered On    ::    05/07/2018 07:35
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Maps.Data;
using System.Web.Mvc;
using X.PagedList;
using X.PagedList.Mvc; //import this so we get our HTML Helper

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

        public ActionResult Trainees(int? page)
        {
            var factory = new Factory();
            factory.Initialize();

            var trainees = factory.Trainees; //returns IQueryable<Product> representing an unknown number of products. a thousand maybe?

            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var model = trainees.ToPagedList(pageNumber, 10); // will only contain 25 products max because of the pageSize

            return View(model);
        }
    }
}