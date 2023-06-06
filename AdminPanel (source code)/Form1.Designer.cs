namespace AdminPanel
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bt_rel_genreGame_del = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.data_game_genre_relation = new System.Windows.Forms.DataGridView();
			this.bt_update = new System.Windows.Forms.Button();
			this.bt_genre_bind = new System.Windows.Forms.Button();
			this.bt_genre_ok = new System.Windows.Forms.Button();
			this.l_genre = new System.Windows.Forms.Label();
			this.tb_genre = new System.Windows.Forms.TextBox();
			this.bt_genre_add = new System.Windows.Forms.Button();
			this.bt_user_del = new System.Windows.Forms.Button();
			this.bt_genre_del = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.data_users = new System.Windows.Forms.DataGridView();
			this.data_genres = new System.Windows.Forms.DataGridView();
			this.l_server_path = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.bt_del = new System.Windows.Forms.Button();
			this.data_games = new System.Windows.Forms.DataGridView();
			this.bt_add = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_game_genre_relation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data_users)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data_genres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data_games)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(476, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Панель Администратора";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.bt_rel_genreGame_del);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.data_game_genre_relation);
			this.panel1.Controls.Add(this.bt_update);
			this.panel1.Controls.Add(this.bt_genre_bind);
			this.panel1.Controls.Add(this.bt_genre_ok);
			this.panel1.Controls.Add(this.l_genre);
			this.panel1.Controls.Add(this.tb_genre);
			this.panel1.Controls.Add(this.bt_genre_add);
			this.panel1.Controls.Add(this.bt_user_del);
			this.panel1.Controls.Add(this.bt_genre_del);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.data_users);
			this.panel1.Controls.Add(this.data_genres);
			this.panel1.Controls.Add(this.l_server_path);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.bt_del);
			this.panel1.Controls.Add(this.data_games);
			this.panel1.Controls.Add(this.bt_add);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-4, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1528, 1020);
			this.panel1.TabIndex = 1;
			// 
			// bt_rel_genreGame_del
			// 
			this.bt_rel_genreGame_del.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_rel_genreGame_del.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_rel_genreGame_del.FlatAppearance.BorderSize = 0;
			this.bt_rel_genreGame_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_rel_genreGame_del.Location = new System.Drawing.Point(641, 877);
			this.bt_rel_genreGame_del.Name = "bt_rel_genreGame_del";
			this.bt_rel_genreGame_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_rel_genreGame_del.Size = new System.Drawing.Size(101, 31);
			this.bt_rel_genreGame_del.TabIndex = 22;
			this.bt_rel_genreGame_del.Text = "Удалить связь";
			this.bt_rel_genreGame_del.UseVisualStyleBackColor = false;
			this.bt_rel_genreGame_del.Click += new System.EventHandler(this.bt_rel_genreGame_del_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(588, 551);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(158, 18);
			this.label6.TabIndex = 21;
			this.label6.Text = "Связь: игра-жанр";
			// 
			// data_game_genre_relation
			// 
			this.data_game_genre_relation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.data_game_genre_relation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_game_genre_relation.Location = new System.Drawing.Point(482, 572);
			this.data_game_genre_relation.Name = "data_game_genre_relation";
			this.data_game_genre_relation.Size = new System.Drawing.Size(410, 299);
			this.data_game_genre_relation.TabIndex = 20;
			// 
			// bt_update
			// 
			this.bt_update.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_update.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_update.FlatAppearance.BorderSize = 0;
			this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_update.Location = new System.Drawing.Point(113, 663);
			this.bt_update.Name = "bt_update";
			this.bt_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_update.Size = new System.Drawing.Size(114, 65);
			this.bt_update.TabIndex = 19;
			this.bt_update.Text = "Обновить данные";
			this.bt_update.UseVisualStyleBackColor = false;
			this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
			// 
			// bt_genre_bind
			// 
			this.bt_genre_bind.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_genre_bind.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_genre_bind.FlatAppearance.BorderSize = 0;
			this.bt_genre_bind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_genre_bind.Location = new System.Drawing.Point(616, 387);
			this.bt_genre_bind.Name = "bt_genre_bind";
			this.bt_genre_bind.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_genre_bind.Size = new System.Drawing.Size(149, 35);
			this.bt_genre_bind.TabIndex = 18;
			this.bt_genre_bind.Text = "Связать жанр с игрой";
			this.bt_genre_bind.UseVisualStyleBackColor = false;
			this.bt_genre_bind.Click += new System.EventHandler(this.bt_genre_bind_Click);
			// 
			// bt_genre_ok
			// 
			this.bt_genre_ok.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_genre_ok.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_genre_ok.FlatAppearance.BorderSize = 0;
			this.bt_genre_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_genre_ok.Location = new System.Drawing.Point(742, 450);
			this.bt_genre_ok.Name = "bt_genre_ok";
			this.bt_genre_ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_genre_ok.Size = new System.Drawing.Size(53, 20);
			this.bt_genre_ok.TabIndex = 17;
			this.bt_genre_ok.Text = "OK";
			this.bt_genre_ok.UseVisualStyleBackColor = false;
			this.bt_genre_ok.Visible = false;
			this.bt_genre_ok.Click += new System.EventHandler(this.bt_genre_ok_Click);
			// 
			// l_genre
			// 
			this.l_genre.AutoSize = true;
			this.l_genre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_genre.Location = new System.Drawing.Point(462, 452);
			this.l_genre.Name = "l_genre";
			this.l_genre.Size = new System.Drawing.Size(148, 18);
			this.l_genre.TabIndex = 16;
			this.l_genre.Text = "Название жанра";
			this.l_genre.Visible = false;
			// 
			// tb_genre
			// 
			this.tb_genre.Location = new System.Drawing.Point(616, 450);
			this.tb_genre.Name = "tb_genre";
			this.tb_genre.Size = new System.Drawing.Size(123, 20);
			this.tb_genre.TabIndex = 15;
			this.tb_genre.Visible = false;
			// 
			// bt_genre_add
			// 
			this.bt_genre_add.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_genre_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_genre_add.FlatAppearance.BorderSize = 0;
			this.bt_genre_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_genre_add.Location = new System.Drawing.Point(797, 387);
			this.bt_genre_add.Name = "bt_genre_add";
			this.bt_genre_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_genre_add.Size = new System.Drawing.Size(95, 35);
			this.bt_genre_add.TabIndex = 14;
			this.bt_genre_add.Text = "Добавить жанр";
			this.bt_genre_add.UseVisualStyleBackColor = false;
			this.bt_genre_add.Click += new System.EventHandler(this.bt_genre_add_Click);
			// 
			// bt_user_del
			// 
			this.bt_user_del.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_user_del.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_user_del.FlatAppearance.BorderSize = 0;
			this.bt_user_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_user_del.Location = new System.Drawing.Point(1063, 387);
			this.bt_user_del.Name = "bt_user_del";
			this.bt_user_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_user_del.Size = new System.Drawing.Size(133, 35);
			this.bt_user_del.TabIndex = 13;
			this.bt_user_del.Text = "Удалить пользователя";
			this.bt_user_del.UseVisualStyleBackColor = false;
			this.bt_user_del.Click += new System.EventHandler(this.bt_user_del_Click);
			// 
			// bt_genre_del
			// 
			this.bt_genre_del.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_genre_del.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_genre_del.FlatAppearance.BorderSize = 0;
			this.bt_genre_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_genre_del.Location = new System.Drawing.Point(482, 387);
			this.bt_genre_del.Name = "bt_genre_del";
			this.bt_genre_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_genre_del.Size = new System.Drawing.Size(101, 35);
			this.bt_genre_del.TabIndex = 12;
			this.bt_genre_del.Text = "Удалить жанр";
			this.bt_genre_del.UseVisualStyleBackColor = false;
			this.bt_genre_del.Click += new System.EventHandler(this.bt_genre_del_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1060, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Пользователи";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(638, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Жанры";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(230, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Игры";
			// 
			// data_users
			// 
			this.data_users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.data_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_users.Location = new System.Drawing.Point(938, 82);
			this.data_users.Name = "data_users";
			this.data_users.Size = new System.Drawing.Size(391, 299);
			this.data_users.TabIndex = 8;
			// 
			// data_genres
			// 
			this.data_genres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.data_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_genres.Location = new System.Drawing.Point(482, 82);
			this.data_genres.Name = "data_genres";
			this.data_genres.Size = new System.Drawing.Size(410, 299);
			this.data_genres.TabIndex = 7;
			// 
			// l_server_path
			// 
			this.l_server_path.AutoSize = true;
			this.l_server_path.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_server_path.Location = new System.Drawing.Point(154, 506);
			this.l_server_path.Name = "l_server_path";
			this.l_server_path.Size = new System.Drawing.Size(93, 18);
			this.l_server_path.TabIndex = 6;
			this.l_server_path.Text = "Не указан";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 506);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Путь к серверу: ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(86, 551);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(161, 35);
			this.button1.TabIndex = 4;
			this.button1.Text = "Выбрать путь к серверу";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_del
			// 
			this.bt_del.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_del.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_del.FlatAppearance.BorderSize = 0;
			this.bt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_del.Location = new System.Drawing.Point(57, 387);
			this.bt_del.Name = "bt_del";
			this.bt_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_del.Size = new System.Drawing.Size(120, 35);
			this.bt_del.TabIndex = 3;
			this.bt_del.Text = "Удалить игру";
			this.bt_del.UseVisualStyleBackColor = false;
			this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
			// 
			// data_games
			// 
			this.data_games.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.data_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_games.Location = new System.Drawing.Point(57, 82);
			this.data_games.Name = "data_games";
			this.data_games.Size = new System.Drawing.Size(374, 299);
			this.data_games.TabIndex = 2;
			// 
			// bt_add
			// 
			this.bt_add.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_add.Enabled = false;
			this.bt_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_add.FlatAppearance.BorderSize = 0;
			this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_add.Location = new System.Drawing.Point(311, 387);
			this.bt_add.Name = "bt_add";
			this.bt_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_add.Size = new System.Drawing.Size(120, 35);
			this.bt_add.TabIndex = 1;
			this.bt_add.Text = "Добавить игру";
			this.bt_add.UseVisualStyleBackColor = false;
			this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1520, 1008);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_game_genre_relation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data_users)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data_genres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data_games)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bt_add;
		private System.Windows.Forms.DataGridView data_games;
		private System.Windows.Forms.Button bt_del;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label l_server_path;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView data_users;
		private System.Windows.Forms.DataGridView data_genres;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bt_user_del;
		private System.Windows.Forms.Button bt_genre_del;
		private System.Windows.Forms.Button bt_genre_add;
		private System.Windows.Forms.Label l_genre;
		private System.Windows.Forms.TextBox tb_genre;
		private System.Windows.Forms.Button bt_genre_ok;
		private System.Windows.Forms.Button bt_genre_bind;
		private System.Windows.Forms.Button bt_update;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView data_game_genre_relation;
		private System.Windows.Forms.Button bt_rel_genreGame_del;
	}
}

