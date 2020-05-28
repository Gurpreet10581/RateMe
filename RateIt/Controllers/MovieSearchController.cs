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
    public class MovieSearchController : Controller
    {
        private MovieDataModel db = new MovieDataModel();

        // GET: MovieSearch
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "MovieName")
            {
                return View(db.Movies.Where(x => x.MovieName.StartsWith( search )|| search == null).ToList());
            }
            else
            {
                return View(db.Movies.Where(x => x.DirectorName.StartsWith(search) || search == null).ToList());
            }
        }

    }
}
