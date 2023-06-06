using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace AdminPanel
{
	internal class Game
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Steam { get; set; }
		public List<Genre> Genres{ get; set; }
		public List<Comment> Comments { get; set; }
		public Game(string name, string steam= "", string description = "" ) 
		{
			Name = name; Description = description; Steam = steam; Genres = new List<Genre>();
		}
		public Game() { Genres = new List<Genre>(); Comments = new List<Comment>(); }
		public Game(List<Genre> genres) { Genres = genres; }
	}
}
