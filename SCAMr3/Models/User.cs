using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SCAMr3.Models
{
	public class User
	{
		public int ID { get; set; }
		public string UserID { get; set; }
		public string StudentID { get; set; }
	}

	public class UserDBContext : DbContext
	{
		public DbSet<User> Users { get; set; }
	}
}