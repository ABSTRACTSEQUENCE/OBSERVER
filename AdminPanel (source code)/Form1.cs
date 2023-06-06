using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * TODO:
 * Жанры дублируются при создании новой игры
 * Реалиpовать возможность выбора нескольких элементов
 */
namespace AdminPanel
{
	public partial class Form1 : Form
	{
		string ServerPath;
		string SavedPath = "./ServerPath.txt";
		public Form1()
		{
			InitializeComponent();
			bt_del.Enabled = false;
			if (File.Exists(SavedPath)) 
			{ 
				ServerPath = File.ReadAllText(SavedPath); 
				bt_add.Enabled = true; 
				bt_del.Enabled = true; 
				l_server_path.Text = ServerPath;
			}
			data_games.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data_games.MultiSelect = false; //сделать true
			data_games.AllowUserToAddRows = false;
			data_games.AllowUserToDeleteRows = false;

			data_game_genre_relation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data_game_genre_relation.MultiSelect = false; //сделать true
			data_game_genre_relation.AllowUserToAddRows = false;
			data_game_genre_relation.AllowUserToDeleteRows = false;


			data_genres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data_genres.MultiSelect = false; //сделать true
			data_genres.AllowUserToAddRows = false;
			data_genres.AllowUserToDeleteRows = false;

			data_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data_users.MultiSelect = false; //сделать true
			data_users.AllowUserToAddRows = false;
			data_users.AllowUserToDeleteRows = false;
			UpdateData();
		}

		private void bt_add_Click(object sender, EventArgs e)
		{
			using(var c = new Context())
				//if(c.Genres.Count() <= 0) { MessageBox.Show("В базе данных отсуствуют жанры. Добавьте жанры в базу данных."); return; }
			Hide();
			new Add(ServerPath).ShowDialog();
			Show();
			UpdateData();
		}
		private void UpdateData()
		{
			using (var c = new Context())
			{
				c.Database.CreateIfNotExists();
				string Query =
						"SELECT * FROM GAMES;" +
						"SELECT * FROM Genres;" +
						"SELECT * FROM Users;" +
						"SELECT * FROM GenreGames";
					/*Query =
						@"SELECT Games.Name AS 'Название игры',
					Genres.Name AS 'Название жанра'
					FROM Games, GenreGames, Genres
					WHERE GenreGames.Game_Id = Games.Id
					AND
					GenreGames.Genre_Id = Genres.Id";*/
				SqlDataAdapter adapter = new SqlDataAdapter(
					Query, c.Database.Connection.ConnectionString);
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				if (ds.Tables.Count > 1)
				{
					data_games.DataSource = ds.Tables[0];
					data_genres.DataSource = ds.Tables[1];
					data_users.DataSource = ds.Tables[2];
					data_game_genre_relation.DataSource = ds.Tables[3];
					adapter.Dispose();
					ds.Dispose();
				}
				else data_genres.DataSource = ds.Tables[0];
			}
		}

		private void bt_del_Click(object sender, EventArgs e)
		{
			
			void DeleteDir(string path)
			{
				if (Directory.Exists(path))
				{
					if (Directory.GetFiles(path).Length <= 0) Directory.Delete(path);
					else 
					{
						foreach(var i in Directory.GetFiles(path))
						{
							File.Delete(i);
						}
						Directory.Delete(path);
					}
				}
			}
			using (Context c = new Context()) 
			{
				if(data_games.SelectedRows.Count>0)
					for (int i=0; i < data_games.SelectedRows.Count; i++)
					{
						string name = data_games.SelectedRows[i].Cells[1].Value.ToString();
						string path = ServerPath + "\\Pictures\\Previews\\" + name;//+ "\\" + name + ".png";
						DeleteDir(path);
						path = ServerPath + "\\Pictures\\Screenshots\\" + name;// + "\\" + name + ".png";
						DeleteDir(path);
						if (!String.IsNullOrEmpty(data_games.SelectedRows[i].Cells[0].Value.ToString()))
						{
							string command = $"DELETE FROM Games WHERE Id ={data_games.SelectedRows[i].Cells[0].Value}";
							c.Database.ExecuteSqlCommand(command);
						}
						
					}
			}
			UpdateData();
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			using (var f = new FolderBrowserDialog())
				if (f.ShowDialog() == DialogResult.OK)
				{
					ServerPath = f.SelectedPath;
					File.WriteAllText(SavedPath, ServerPath);
					/*
				foreach (var i in Directory.GetFiles(ServerPath))
					if (i == "index.php") return;
				switch (MessageBox.Show("В выбранной вами директории отсуствует index.php. Вы хотите создать в ней сервер?", "Пусто", MessageBoxButtons.YesNo))
				{
					case DialogResult.Yes: CreateServer(); break;
					case DialogResult.No: return;
				}*/
				}
			bt_add.Enabled = true;
			bt_del.Enabled = true;
			l_server_path.Text = ServerPath;
		}

		private void bt_genre_del_Click(object sender, EventArgs e)
		{
			using (var c = new Context())
			{
				//bool found = false;
				/*foreach(DataGridViewRow i in data_genres.Rows)
				{
					//ids.Add((int)i.Cells[0].Value);
					foreach(Genre j in c.Genres)
					{
						if (j.Id == (int)i.Cells[0].Value)
						{
							c.Genres.Remove(j);
							found = true;
							break;
						}
					}
					if (found) break;
				}*/
				foreach(var i in c.Genres)
				{
					if (i.Id == (int)data_genres.SelectedCells[0].Value)
					{
						c.Genres.Remove(i);
						break;
					}
				}
				
				c.SaveChanges();
			}
			UpdateData();
		}

		private void bt_genre_add_Click(object sender, EventArgs e)
		{
			l_genre.Visible= true;
			tb_genre.Visible= true;
			bt_genre_ok.Visible= true;
		}

		private void bt_genre_ok_Click(object sender, EventArgs e)
		{
			using (var c = new Context()) 
			{
				foreach(var i in c.Genres)
				{
					if (tb_genre.Text == i.Name) { MessageBox.Show("Такой жанр уже существeт"); return;}			
				}
				c.Genres.Add(new Genre(tb_genre.Text));
				c.SaveChanges();
			}	
			l_genre.Visible = false;
			tb_genre.Visible = false;
			bt_genre_ok.Visible = false;
			UpdateData();
		}

		private void bt_user_del_Click(object sender, EventArgs e)
		{
			int del_id = (int)data_users.SelectedCells[0].Value;
			using(var c = new Context()) 
			{
				Users ToDel = (from u in c.Users where u.Id == del_id select u).ToArray()[0];
				Comment[] comments = (from cms in c.Comments where cms.User.Id == del_id select cms).ToArray();
				c.Comments.RemoveRange(comments);
				c.Users.Remove(ToDel);
				c.SaveChanges();
				UpdateData();
			}
		}

		private void bt_genre_bind_Click(object sender, EventArgs e)
		{
			if (data_games.SelectedCells.Count == 0 || data_genres.SelectedCells.Count == 0) { MessageBox.Show("Выберите игру и жанр, которые хотите связать "); return; }
			int gameId = (int)data_games.SelectedCells[0].Value;
			int genreId = (int)data_genres.SelectedCells[0].Value;
			Genre GenreToBind = null;
			Game GameToBind = null;
			using(Context c = new Context())
			{
				
				DataSet ds = new DataSet();
				new SqlDataAdapter(new SqlCommand(
				"SELECT * FROM GenreGames " +
				$"WHERE Genre_Id = {genreId} " +
				$"AND Game_Id = {gameId}", new SqlConnection(c.Database.Connection.ConnectionString))).Fill(ds);
				if(ds.Tables[0].Rows.Count > 0) { MessageBox.Show("Данный жанр и игра уже связаны"); return; }
				
				foreach (Genre i in c.Genres)
				{
					if (i.Id == genreId) 
					{
						GenreToBind = i; break; 
					}
				}
				
				foreach(Game i in c.Games)
				{
					if(i.Id == gameId) 
					{
						//Предотвратить дублирование жанров!!!
						GameToBind = i; break;
					}
				}
				//Убрать дубликаты связей

				/*Games_Genres Relation = new Games_Genres(GameToBind, GenreToBind);
				foreach(var i in c.Games_Genres)
				{
					if(i.GameId == Relation.GameId && i.GenreId == Relation.GenreId)
					{
						MessageBox.Show("Данный жанр и игра уже связаны");
						return;
					}
				}
				GameToBind.GenreId = Relation;
				GenreToBind.GameId = Relation;*/
				GameToBind.Genres.Add(GenreToBind);
				//GenreToBind.Games.Add(GameToBind);
				c.SaveChanges(); UpdateData();
			}
		}

		private void bt_update_Click(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void bt_rel_genreGame_del_Click(object sender, EventArgs e)
		{
			using (Context c = new Context())
			{
				if (data_game_genre_relation.SelectedRows.Count > 0)
				{
					int GameId = (int)data_game_genre_relation.SelectedCells[1].Value;
					int GenreId = (int)data_game_genre_relation.SelectedCells[0].Value;
					string Sql =
						"DELETE FROM GenreGames " +
						$"WHERE Game_Id = {GameId} " +
						$"AND Genre_Id = {GenreId};";
					c.Database.ExecuteSqlCommand(Sql);
					UpdateData();
				}
			}
		}
	}
}
