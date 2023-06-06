using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
	public partial class Add : Form
	{
		OpenFileDialog PictureSelector;
		List<string> ScreenshotLocations;
		string ServerPath;
		public Add(string serverPath)
		{
			InitializeComponent();
			ServerPath = serverPath;
			PictureSelector= new OpenFileDialog();
			PictureSelector.Filter = "Изображение|*.png||*.jpg";
			PictureSelector.Multiselect = false;
		}
		private void bt_add_Click(object sender, EventArgs e)
		{
		
			Validate();
			//foreach(var i in lb_genres.Items) Genres.Add((Genre)i);
			if (String.IsNullOrEmpty(ServerPath)) { MessageBox.Show("Выберите путь к серверу"); return; }
			if (String.IsNullOrEmpty(PictureSelector.FileName)){ MessageBox.Show("Выберите превью"); return; }
			if (!String.IsNullOrEmpty(Name))
			{
				string Name = tb_name.Text; string Description = tb_desc.Text; string Steam = tb_steam.Text;
				string PreviewPath = ServerPath + "\\Pictures\\Previews\\"+Name +"\\"+ Name + ".png";
				string ScreenshotPath = ServerPath + "\\Pictures\\Screenshots\\" + Name;
				PictureSelector.Dispose();
				string pic = pb_preview.ImageLocation;
				PictureSelector = null;
				pb_preview.Dispose();
				pb_preview= null;
				using (var context = new Context())
				{
					Game game = new Game(Name,Steam, Description);
					context.Database.CreateIfNotExists();
					context.Games.Add(game);
					context.SaveChanges();
					if (!File.Exists(PreviewPath)) File.Move(pic, PreviewPath);
					for (int i = 0; i < ScreenshotLocations.Count; i++)
					{
						string path = ScreenshotPath + "\\" + i + ".png";
						if (!File.Exists(path)) File.Copy(ScreenshotLocations[i],path);
					};
					MessageBox.Show("Готово!");
					Close(); return;
				}
			}
			else { MessageBox.Show("Поле с именем не должно быть пустым"); return; };
		}

		private void bt_preview_Click(object sender, EventArgs e)
		{
			string temp = ServerPath + "\\Pictures\\temp\\temp.png";
			if (PictureSelector.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(temp)) File.Delete(temp);
				new Bitmap(Image.FromFile(PictureSelector.FileName), new Size(300, 500)).Save(temp, ImageFormat.Png);
				pb_preview.Load(temp);
			}
		}
		//void CreateServer() { }
		void Validate()
		{
			if (String.IsNullOrEmpty(tb_name.Text)) { MessageBox.Show("Название игры не указано"); return; }
			string name = tb_name.Text;
			List<string> Folders = new List<string>()
			{
				ServerPath+"\\Pictures\\",
				ServerPath+"\\Pictures\\Previews\\"+name,
				ServerPath+"\\Pictures\\Screenshots\\"+name,
				ServerPath+"\\Pictures\\temp"
			};
			foreach (var i in Folders) if (!Directory.Exists(i)) Directory.CreateDirectory(i);
			//if (File.Exists(ServerPath + "\\Pictures\\temp\\temp.png")) File.Delete(ServerPath + "\\Pictures\\temp\\temp.png");
		}

		private void bt_screenshots_Click(object sender, EventArgs e)
		{
			if (ScreenshotLocations == null) ScreenshotLocations = new List<string>();
			if(ScreenshotLocations.Count >= 3) { MessageBox.Show("Нельзя добавлять больше трёх скриншотов"); return; }
			if(PictureSelector.ShowDialog() == DialogResult.OK)
			{
				ScreenshotLocations.Add(PictureSelector.FileName);
				lb_screenshots.Items.Add(new Bitmap(Image.FromFile(PictureSelector.FileName),new Size(300,300)));
			}
		}

		private void lb_screenshots_SelectedIndexChanged(object sender, EventArgs e)
		{
			Bitmap screenshot = lb_screenshots.SelectedItem as Bitmap;
			if (screenshot == null) return;
			pb_screenshots.Image = screenshot;
		}
	}
}
