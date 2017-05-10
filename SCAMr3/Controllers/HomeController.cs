using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCAMr3.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
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

		public ActionResult Boards()
		{
			ViewBag.Message = "The Discussion board page.";

			return View();
		}

		public ActionResult Schedule()
		{
			ViewBag.Message = "My Schedule page.";

			return View();
		}

		public ActionResult Profile()
		{
			ViewBag.Message = "My Profile page.";

			return View();
		}

		public ActionResult FAQs()
		{
			ViewBag.Message = "FAQs";

			return View();
		}

		public ActionResult Threads()
		{
			return View();
		}

		public ActionResult GeneratedSchedule()
		{
			ViewBag.Message = "Generated Schedule page.";

			return View();
		}
	}
}