using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Mvc3MusicStore.Models;

namespace Mvc3MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return this.View(genres);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            Genre genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return this.View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);
            
            return this.View(album);
        }
    }
}
