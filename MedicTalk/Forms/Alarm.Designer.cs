namespace MedicTalk
{
	partial class Alarm
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
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Hour_Box = new System.Windows.Forms.ComboBox();
			this.Minute_Box = new System.Windows.Forms.ComboBox();
			this.AlarmsList = new System.Windows.Forms.DataGridView();
			this.Youralarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.Submit_Button = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AlarmsList)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Icon_Return;
			this.button1.Location = new System.Drawing.Point(4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 85);
			this.button1.TabIndex = 10;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::MedicTalk.Properties.Resources.MediTalk_Heading;
			this.pictureBox1.Location = new System.Drawing.Point(315, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 42);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Plain_Background;
			this.pictureBox2.Location = new System.Drawing.Point(134, 75);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(550, 403);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(360, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 24);
			this.label1.TabIndex = 16;
			this.label1.Text = "Set Alarm";
			// 
			// Hour_Box
			// 
			this.Hour_Box.FormattingEnabled = true;
			this.Hour_Box.Location = new System.Drawing.Point(268, 158);
			this.Hour_Box.Name = "Hour_Box";
			this.Hour_Box.Size = new System.Drawing.Size(121, 28);
			this.Hour_Box.TabIndex = 17;
			this.Hour_Box.Text = "Hour";
			this.Hour_Box.SelectedIndexChanged += new System.EventHandler(this.Hour_Changed);
			// 
			// Minute_Box
			// 
			this.Minute_Box.FormattingEnabled = true;
			this.Minute_Box.Location = new System.Drawing.Point(422, 158);
			this.Minute_Box.Name = "Minute_Box";
			this.Minute_Box.Size = new System.Drawing.Size(121, 28);
			this.Minute_Box.TabIndex = 18;
			this.Minute_Box.Text = "Minutes";
			this.Minute_Box.SelectedIndexChanged += new System.EventHandler(this.Minute_Changed);
			// 
			// AlarmsList
			// 
			this.AlarmsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AlarmsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Youralarm,
            this.RemoveColumn});
			this.AlarmsList.Location = new System.Drawing.Point(225, 282);
			this.AlarmsList.Name = "AlarmsList";
			this.AlarmsList.RowTemplate.Height = 28;
			this.AlarmsList.Size = new System.Drawing.Size(372, 178);
			this.AlarmsList.TabIndex = 20;
			this.AlarmsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlarmsList_CellContentClick);
			this.AlarmsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Remove_Alarm);
			// 
			// Youralarm
			// 
			this.Youralarm.DataPropertyName = "TimeToComplete";
			this.Youralarm.HeaderText = "Your Alarms";
			this.Youralarm.Name = "Youralarm";
			// 
			// RemoveColumn
			// 
			this.RemoveColumn.HeaderText = "Remove alarm";
			this.RemoveColumn.Name = "RemoveColumn";
			this.RemoveColumn.Width = 88;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(334, 247);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "Previous Alarms";
			// 
			// Submit_Button
			// 
			this.Submit_Button.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
			this.Submit_Button.Location = new System.Drawing.Point(345, 202);
			this.Submit_Button.Name = "Submit_Button";
			this.Submit_Button.Size = new System.Drawing.Size(132, 31);
			this.Submit_Button.TabIndex = 38;
			this.Submit_Button.UseVisualStyleBackColor = true;
			this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::MedicTalk.Properties.Resources.Emergency3;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(4, 96);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(89, 85);
			this.button3.TabIndex = 40;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background1;
			this.ClientSize = new System.Drawing.Size(812, 528);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Submit_Button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AlarmsList);
			this.Controls.Add(this.Minute_Box);
			this.Controls.Add(this.Hour_Box);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "Alarm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alarm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AlarmsList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox Hour_Box;
		public System.Windows.Forms.ComboBox Minute_Box;
		public System.Windows.Forms.DataGridView AlarmsList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Youralarm;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveColumn;
		private System.Windows.Forms.Button button3;
	}
}