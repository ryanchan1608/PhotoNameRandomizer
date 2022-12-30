namespace PhotoRandomPicker {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.dgPhotoName = new MetroFramework.Controls.MetroGrid();
            this.PhotoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrefix = new MetroFramework.Controls.MetroTextBox();
            this.btnRandom = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbCount = new MetroFramework.Controls.MetroLabel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhotoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = global::PhotoRandomPicker.Properties.Resources.musica_searcher;
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(675, 1);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(23, 63);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PromptText = "Photo Location";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.ShowButton = true;
            this.txtLocation.Size = new System.Drawing.Size(697, 23);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMark = "Photo Location";
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtLocation_ButtonClick);
            // 
            // dgPhotoName
            // 
            this.dgPhotoName.AllowUserToAddRows = false;
            this.dgPhotoName.AllowUserToDeleteRows = false;
            this.dgPhotoName.AllowUserToResizeRows = false;
            this.dgPhotoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPhotoName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPhotoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPhotoName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPhotoName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPhotoName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPhotoName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhotoName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhotoName,
            this.Path});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPhotoName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPhotoName.EnableHeadersVisualStyles = false;
            this.dgPhotoName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgPhotoName.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPhotoName.Location = new System.Drawing.Point(23, 121);
            this.dgPhotoName.Name = "dgPhotoName";
            this.dgPhotoName.ReadOnly = true;
            this.dgPhotoName.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPhotoName.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPhotoName.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPhotoName.RowTemplate.Height = 24;
            this.dgPhotoName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhotoName.Size = new System.Drawing.Size(445, 340);
            this.dgPhotoName.TabIndex = 1;
            this.dgPhotoName.SelectionChanged += new System.EventHandler(this.dgPhotoName_SelectionChanged);
            // 
            // PhotoName
            // 
            this.PhotoName.DataPropertyName = "PhotoName";
            this.PhotoName.HeaderText = "Photo Name";
            this.PhotoName.Name = "PhotoName";
            this.PhotoName.ReadOnly = true;
            this.PhotoName.Width = 200;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPrefix.CustomButton.Image = null;
            this.txtPrefix.CustomButton.Location = new System.Drawing.Point(675, 1);
            this.txtPrefix.CustomButton.Name = "";
            this.txtPrefix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrefix.CustomButton.TabIndex = 1;
            this.txtPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrefix.CustomButton.UseSelectable = true;
            this.txtPrefix.CustomButton.Visible = false;
            this.txtPrefix.Lines = new string[0];
            this.txtPrefix.Location = new System.Drawing.Point(23, 92);
            this.txtPrefix.MaxLength = 32767;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.PasswordChar = '\0';
            this.txtPrefix.PromptText = "Photo Prefix";
            this.txtPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrefix.SelectedText = "";
            this.txtPrefix.SelectionLength = 0;
            this.txtPrefix.SelectionStart = 0;
            this.txtPrefix.ShortcutsEnabled = true;
            this.txtPrefix.Size = new System.Drawing.Size(697, 23);
            this.txtPrefix.TabIndex = 2;
            this.txtPrefix.UseSelectable = true;
            this.txtPrefix.WaterMark = "Photo Prefix";
            this.txtPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandom.Location = new System.Drawing.Point(645, 467);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseSelectable = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 464);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Count:";
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCount.AutoSize = true;
            this.lbCount.ForeColor = System.Drawing.Color.Red;
            this.lbCount.Location = new System.Drawing.Point(76, 464);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(16, 19);
            this.lbCount.TabIndex = 5;
            this.lbCount.Text = "0";
            this.lbCount.UseCustomForeColor = true;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPhoto.Location = new System.Drawing.Point(474, 121);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(246, 340);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 6;
            this.pbPhoto.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 513);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.dgPhotoName);
            this.Controls.Add(this.txtLocation);
            this.Name = "Main";
            this.Text = "Photo Name Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.dgPhotoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtLocation;
		private MetroFramework.Controls.MetroTextBox txtPrefix;
		private MetroFramework.Controls.MetroButton btnRandom;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel lbCount;
		private System.Windows.Forms.PictureBox pbPhoto;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private MetroFramework.Controls.MetroGrid dgPhotoName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhotoName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Path;
	}
}

