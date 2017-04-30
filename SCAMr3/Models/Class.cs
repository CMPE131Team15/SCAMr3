using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SCAMr3.Models
{
	public class Class
	{
		public int ID { get; set; }
		public string ClassNumber { get; set; } //The unique class identifier number
		public int CourseID { get; set; } //ID of the course from the course model this class is
		public int SectionNumber { get; set; } 
		public string Instructor { get; set; }
		public string Days { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
	}

	public class ClassDBContext : DbContext
	{
		public DbSet<Class> Class { get; set; }
	}
}
