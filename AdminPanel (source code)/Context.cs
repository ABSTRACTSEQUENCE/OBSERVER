using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
	internal class Context:DbContext
	{
		public Context():base("Connection"){}
		public DbSet<Game> Games { get; set; }
		public DbSet<Users> Users { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Comment> Comments { get; set; }
		//public DbSet<Games_Genres> Games_Genres { get; set;}
		//protected override void OnModelCreating(DbModelBuilder builder) {}
	}
}
