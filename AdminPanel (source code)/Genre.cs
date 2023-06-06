using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
	internal class Genre
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public Genre(string name ) { Name = name;}
		public List<Game> Games { get; set; }
		public Genre() { Games = new List<Game>(); }
		public Genre(List<Game> games)
		{
			Games = games;
		}
		public override string ToString() { return Name; }
	}
}
