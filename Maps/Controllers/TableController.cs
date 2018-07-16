using Maps.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using X.PagedList;

namespace Maps.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index(int? page)
        {
            var model = new Factory();
            model.Initialize();
            var pageNumber = page ?? 1;
            var result = model.Trainees;
            return View(result.ToPagedList(pageNumber, 10));
        }
    }
}