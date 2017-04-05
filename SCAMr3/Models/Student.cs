using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SCAMr3.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Major { get; set; }
		public string Year { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		//NEED TO SERIALIZE/DESERIALIZE
		public string UncompletedCourses { get; set; }
		public string CurrentCourses { get; set; }
		public string Friends { get; set; }
		/*
		public List<string> UncompletedCourses { get; set; }
		public List<string> CurrentCourses { get; set; }
		public List<int> Friends { get; set; }
		*/
	}

	public class StudentDBContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
	}
}
