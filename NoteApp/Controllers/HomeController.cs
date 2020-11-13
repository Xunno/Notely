using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoteApp.Models;
using NoteApp.Services;
using NoteApp.Data;

namespace NoteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductServices productServices = new ProductServices();
        private NumberServices numberServices = new NumberServices();
        private NoteList noteList = new NoteList();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {

            Product product = productServices.getProductDetail();

            return View(product);
        }

        public IActionResult Number(string inputNumber = null)
        {
            if (inputNumber.Equals("1"))
            {
                inputNumber = "1";
            }
            if (String.IsNullOrEmpty(inputNumber))
            {
                inputNumber = "0";
            }

            Number number = numberServices.createNumber(inputNumber);
            return View(number);
        }

        public IActionResult NoteList()
        {
            List<Note> notes = noteList.GetAllNotes();

            return View(notes);
        }

        public IActionResult NoteDetail(string title = null, string detail = null)
        {
            if (!String.IsNullOrEmpty(title))
            {
                Note note = new Note(title, detail);

                noteList.AddNotes(note); 
                
                return View(note);
            }

            return RedirectToAction("NoteList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
