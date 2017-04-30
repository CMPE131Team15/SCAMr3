using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SCAMr3.Models
{
	public class Course
	{
		public int ID { get; set; }
		public string Name { get; set; } //For instance, CMPE131
		public string Title { get; set; } //For instance, "Software Engineering I"
		public string Description { get; set; }
	}

	public class CourseDBContext : DbContext
	{
		public DbSet<Course> Courses { get; set; }
	}
}
