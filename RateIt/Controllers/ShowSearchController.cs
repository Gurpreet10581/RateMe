using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RateIt.Models;

namespace RateIt.Controllers
{
    public class ShowSearchController : Controller
    {
        private ShowDataModel db = new ShowDataModel();

        // GET: ShowSearch
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "ShowName")
            {
                return View(db.Shows.Where(x => x.ShowName.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View(db.Shows.Where(x => x.DirectorName.StartsWith(search) || search == null).ToList());
            }
        }

    }
}
