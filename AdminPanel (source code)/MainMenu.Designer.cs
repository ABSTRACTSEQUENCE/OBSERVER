namespace AdminPanel
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.bt_view_users = new System.Windows.Forms.Button();
			this.bt_view_comments = new System.Windows.Forms.Button();
			this.bt_view_games = new System.Windows.Forms.Button();
			this.data = new System.Windows.Forms.DataGridView();
			this.bt_del = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// bt_view_users
			// 
			this.bt_view_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bt_view_users.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bt_view_users.FlatAppearance.BorderSize = 0;
			this.bt_view_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_view_users.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bt_view_users.Location = new System.Drawing.Point(130, 169);
			this.bt_view_users.Name = "bt_view_users";
			this.bt_view_users.Size = new System.Drawing.Size(184, 46);
			this.bt_view_users.TabIndex = 0;
			this.bt_view_users.Text = "Отобразить пользователей";
			this.bt_view_users.UseVisualStyleBackColor = false;
			this.bt_view_users.Click += new System.EventHandler(this.bt_view_users_Click);
			// 
			// bt_view_comments
			// 
			this.bt_view_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bt_view_comments.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bt_view_comments.FlatAppearance.BorderSize = 0;
			this.bt_view_comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_view_comments.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bt_view_comments.Location = new System.Drawing.Point(130, 221);
			this.bt_view_comments.Name = "bt_view_comments";
			this.bt_view_comments.Size = new System.Drawing.Size(184, 46);
			this.bt_view_comments.TabIndex = 1;
			this.bt_view_comments.Text = "Отобразить комментарии";
			this.bt_view_comments.UseVisualStyleBackColor = false;
			this.bt_view_comments.Click += new System.EventHandler(this.bt_view_comments_Click);
			// 
			// bt_view_games
			// 
			this.bt_view_games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bt_view_games.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bt_view_games.FlatAppearance.BorderSize = 0;
			this.bt_view_games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_view_games.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bt_view_games.Location = new System.Drawing.Point(130, 273);
			this.bt_view_games.Name = "bt_view_games";
			this.bt_view_games.Size = new System.Drawing.Size(184, 46);
			this.bt_view_games.TabIndex = 2;
			this.bt_view_games.Text = "Отобразить игры";
			this.bt_view_games.UseVisualStyleBackColor = false;
			// 
			// data
			// 
			this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.data.GridColor = System.Drawing.SystemColors.ControlLight;
			this.data.Location = new System.Drawing.Point(453, 131);
			this.data.MultiSelect = false;
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.data.Size = new System.Drawing.Size(425, 287);
			this.data.TabIndex = 3;
			// 
			// bt_del
			// 
			this.bt_del.BackColor = System.Drawing.Color.White;
			this.bt_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_del.BackgroundImage")));
			this.bt_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bt_del.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bt_del.FlatAppearance.BorderSize = 0;
			this.bt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bt_del.Location = new System.Drawing.Point(453, 424);
			this.bt_del.Name = "bt_del";
			this.bt_del.Size = new System.Drawing.Size(39, 30);
			this.bt_del.TabIndex = 4;
			this.bt_del.UseVisualStyleBackColor = false;
			this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1027, 548);
			this.Controls.Add(this.bt_del);
			this.Controls.Add(this.data);
			this.Controls.Add(this.bt_view_games);
			this.Controls.Add(this.bt_view_comments);
			this.Controls.Add(this.bt_view_users);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bt_view_users;
		private System.Windows.Forms.Button bt_view_comments;
		private System.Windows.Forms.Button bt_view_games;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Button bt_del;
	}
}