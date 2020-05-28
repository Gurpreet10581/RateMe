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
    public class MusicSearchController : Controller
    {
        private MusicDataModel db = new MusicDataModel();

        // GET: MusicSearch
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "ArtistName")
            {
                return View(db.Musics.Where(x => x.ArtistName.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View(db.Musics.Where(x => x.GenreOfMusic.ToString().StartsWith(search) || search == null).ToList());
            }
        }

        
    }
}
