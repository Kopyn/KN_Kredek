using MaciejKopinskiLab4ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab4ZadDom.Controllers
{
    public class HomeController : Controller
    {

        List<SongViewModel> allSongs;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //creating songs list
            allSongs = new List<SongViewModel>();
            //adding songs to list
            allSongs.Add(new SongViewModel("Everlong", "Foo Fighters", "~/everlongTab.svg", "~/everlongNotes.png", "~/everlongLyrics.png"));
            allSongs.Add(new SongViewModel("Wish You Were Here", "Pink Floyd", "~/wishYouWereHereTab.png", "~/wishYouWereHereNotes.png", "~/wishYouWereHereLyrics.png"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //endpoint to return all songs
        public IActionResult GetAllSongs()
        {
            return View(allSongs);
        }

        //endpoint to return list of all songs
        public IActionResult GetListOfSongs()
        {
            //create list which will contain all titles
            List<string> allTitles = new List<string>();
            foreach(var song in allSongs)
            {
                allTitles.Add(song.Title);
            }
            
            return View(allTitles);
        }

        //endpoint to return all song data of given title
        public IActionResult GetSongByTitle(string title)
        {
            var song = allSongs.Where(a => a.Title.ToLower() == title.ToLower()).FirstOrDefault();
            return View(song);
        }

        //endpoint to view form with song tab
        [HttpGet]
        public IActionResult SongTabForm()
        {
            return View();
        }

        //endpoint to post song tab data
        [HttpPost]
        public IActionResult SongTabForm(SongViewModel songData)
        {
            ViewBag.Title = songData.Title;
            ViewBag.Vocalist = songData.Vocalist;
            ViewBag.Tab = songData.Tab;
            return View("SongTabFormSummary");
        }

        //endpoint to view form with song notes
        [HttpGet]
        public IActionResult SongNotesForm()
        {
            return View();
        }

        //endpoint to post song notes data
        [HttpPost]
        public IActionResult SongNotesForm(SongViewModel songData)
        {
            ViewBag.Title = songData.Title;
            ViewBag.Vocalist = songData.Vocalist;
            ViewBag.Notes = songData.Notes;
            return View("SongNotesFormSummary");
        }

        //endpoint to view form with song lyrics
        [HttpGet]
        public IActionResult SongLyricsForm()
        {
            return View();
        }

        //endpoint to post song lyrics data
        [HttpPost]
        public IActionResult SongLyricsForm(SongViewModel songData)
        {
            TempData["Title"] = songData.Title;
            TempData["Vocalist"] = songData.Vocalist;
            TempData["Lyrics"] = songData.Lyrics;
            return View("SongLyricsFormSummary");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
