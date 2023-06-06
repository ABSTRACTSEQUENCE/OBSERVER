using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
	internal class Games_Genres
	{
		public int Id { get; set; }
		public Game GameId { get; set; }
		public Genre GenreId { get; set; }
		public Games_Genres() { }
		public Games_Genres(Game GameID, Genre GenreID)
		{
			GameId = GameID; GenreId = GenreID;
		}
	}
}
