using Microsoft.AspNet.Identity;
using RateIt.Data;
using RateIt.Models;
using RateItModels.Movie;
using RateItModels.Music;
using RateItModels.Review;
using RateItServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace RateIt.Controllers
{
    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MusicService(userId);
            var model = service.GetMusics();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MusicCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            var service = CreateMusicService();
            if (service.CreateMusic(model))
            {
                TempData["SaveResult"] = "Your Music was created";
                return RedirectToAction("Index");

            };
            ModelState.AddModelError("", "Music could not be created");
            return View(model);

        }
        public ActionResult Details(int id)
        {
            var svc = CreateMusicService();
            var model = svc.GetMusicById(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateMusicService();
            var detail = service.GetMusicById(id);
            var model = new MusicEdit
            {
                ArtistName = detail.ArtistName,
                Duration = detail.Duration,
                DateRelease = detail.DateRelease,
                GenreOfMusic = detail.GenreOfMusic,
                TypeOfMusic = detail.TypeOfMusic
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MusicEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.MusicId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
            }
            var service = CreateMusicService();
            if (service.UpdateMusic(model))
            {
                TempData["SaveResult"] = "Your Music was updated";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Music could not be updated");
            return View();
        }
        public ActionResult Delete(int id)
        {
            var svc = CreateMusicService();
            var model = svc.GetMusicById(id);

            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateMusicService();
            service.DeleteMusic(id);
            TempData["SaveResult"] = "Your music was deleted";

            return RedirectToAction("Index");
        }

        private MusicService CreateMusicService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MusicService(userId);
            return service;
        }
    }
}