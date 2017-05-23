using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCAMr3.Models;

namespace SCAMr3.Controllers
{
	public class HomeController : Controller
	{

		private StudentDBContext db = new StudentDBContext();

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

		public ActionResult UserProfile(int? id)
		{
			if(id == null)
			{
				ViewBag.Message = "This is not a valid person.";
			}
			else
			{
				Student student = db.Students.Find(id);
				if (student == null)
				{
					return HttpNotFound();
				}
				ViewBag.Message = "Hey there, " + student.Name.ToString() + ".";
				ViewBag.Name = student.Name.ToString();
				ViewBag.Major = student.Major.ToString();
				ViewBag.Year = student.Year.ToString();
			}
			
			return View();
		}

		public ActionResult Edit_Profile()
		{
			ViewBag.Message = "Edit Profile page.";

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