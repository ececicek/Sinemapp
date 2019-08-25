using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sinemapp.Admin.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IFilmService filmService;
        private readonly IGenreService genreService;
        private readonly ICastService castService;

        public FilmsController(IFilmService filmService, IGenreService genreService, ICastService castService)
        {
            this.filmService = filmService;
            this.genreService = genreService;
            this.castService = castService;
        }

        public ActionResult Index()
        {
            var films = Mapper.Map<IEnumerable<FilmViewModel>>(filmService.GetAll());
            return View(films);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}