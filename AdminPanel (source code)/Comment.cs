using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
	internal class Comment
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public Users User { get; set; }
		public Comment(string Text, Users user)
		{
			this.Text = Text;
			User = user;
		}
		public Comment() { User = new Users(); }

	}
}
