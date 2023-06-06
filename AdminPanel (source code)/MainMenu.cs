using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{ 
	public partial class MainMenu : Form
	{
		string ServerPath;

		string SavedPath = "./ServerPath.txt";
		SqlDataAdapter Adapter;
		DataSet ds;
		public MainMenu()
		{
			InitializeComponent();
			using (var c = new Context()) 
			{
				Adapter = new SqlDataAdapter();				
			}
			data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data.MultiSelect = false; //сделать true
			data.AllowUserToAddRows = false;
			data.AllowUserToDeleteRows = false;
			data.AllowUserToResizeColumns = false;
			data.AllowUserToResizeRows = false;
			//UpdateData();

			string[] SqlSelect =
			{
				"SELECT * FROM dbo.Users", //Users
				"SELECT * FROM dbo.Games", //Games
				//Genres
				"SELECT Games.Name AS 'Игра', Genres.Name AS 'Жанр' FROM GenreGames, Genres, Games WHERE Genre_Id = Genres.Id AND Game_Id = Games.Id;",
				//Comments
				"SELECT Users.Name AS 'Пользователь', Games.Name AS 'Игра', Text AS 'Коментарий' FROM Comments, Users, Games WHERE User_Id = Users.Id AND Game_Id = Games.Id;"
			};
			if (ds == null) ds = new DataSet();
			foreach(var i in SqlSelect) 
			{
				using (var c = new Context())
				{
					Adapter.SelectCommand = new SqlCommand(i, new SqlConnection(c.Database.Connection.ConnectionString));
					Adapter.Fill(ds);
				}
			}
			//ds.Tables: [0] - Users; [1] - Games; [2] - Genres; [3] Comments
		}

		private void bt_view_users_Click(object sender, EventArgs e)
		{
			data.DataSource = ds.Tables[0];
		}

		private void bt_view_comments_Click(object sender, EventArgs e)
		{
			data.DataSource = ds.Tables[3];
		}

		private void bt_del_Click(object sender, EventArgs e)
		{
		}

	}
}
