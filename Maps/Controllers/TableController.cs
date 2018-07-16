#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.TableController.cs
// Created On    ::    16/07/2018 07:30
// Altered On    ::    16/07/2018 07:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Maps.Data;
using Maps.Data.Interfaces;
using Maps.Data.Models;
using X.PagedList;

#endregion

namespace Maps.Controllers
{
    public class TableController : BaseController
    {
        // GET: Table
        public ActionResult Index(int? page, string sortOrder = "", string search = "")
        {
            var pageNumber = Init(page,sortOrder,search);
            return View(Factory.Sort(sortOrder, search).ToPagedList(pageNumber, 6));
        }

        public int Init(int? page, string sortOrder = "", string search = "")
        {
            var pageNumber = page ?? 1;

            ViewBag.NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.GroupSort = sortOrder == "group" ? "group_desc" : "group";
            ViewBag.Page = page;

            return pageNumber;
        }

        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                id = Factory.Trainees.FirstOrDefault().Id;

            return View(Factory[id]);
        }

        public ActionResult Save(Trainee trainee)
        {
            Factory.Save(trainee);
            var pageNumber = Init(null, string.Empty, string.Empty);

            return View("Index", Factory.Sort(string.Empty, string.Empty).ToPagedList(pageNumber, 6));
        }

    }
}