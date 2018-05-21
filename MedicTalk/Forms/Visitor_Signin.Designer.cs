namespace MedicTalk
{
	partial class Visitor_Signin
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Add_New_User_Button = new System.Windows.Forms.DataGridView();
			this.Sign_Out = new System.Windows.Forms.DataGridViewButtonColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Visitor_Sign_In = new System.Windows.Forms.Label();
			this.First_Name_Textbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Last = new System.Windows.Forms.Label();
			this.Last_Name_Textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Person_Visiting_Textbox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Add_New_User_Button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::MedicTalk.Properties.Resources.MediTalk_Heading;
			this.pictureBox1.Location = new System.Drawing.Point(667, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 42);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Icon_Return;
			this.button1.Location = new System.Drawing.Point(4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 85);
			this.button1.TabIndex = 14;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Add_New_User_Button
			// 
			this.Add_New_User_Button.AllowUserToAddRows = false;
			this.Add_New_User_Button.AllowUserToDeleteRows = false;
			this.Add_New_User_Button.AllowUserToOrderColumns = true;
			this.Add_New_User_Button.AllowUserToResizeColumns = false;
			this.Add_New_User_Button.AllowUserToResizeRows = false;
			this.Add_New_User_Button.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Add_New_User_Button.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.Add_New_User_Button.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Add_New_User_Button.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sign_Out,
            this.FirstName,
            this.LastName,
            this.Room,
            this.Time_In,
            this.Time_Out});
			this.Add_New_User_Button.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.Add_New_User_Button.Location = new System.Drawing.Point(135, 285);
			this.Add_New_User_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Add_New_User_Button.Name = "Add_New_User_Button";
			this.Add_New_User_Button.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Add_New_User_Button.Size = new System.Drawing.Size(1237, 380);
			this.Add_New_User_Button.TabIndex = 15;
			this.Add_New_User_Button.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Add_New_User_Button_CellContentClick);
			// 
			// Sign_Out
			// 
			this.Sign_Out.HeaderText = "Sign out";
			this.Sign_Out.Name = "Sign_Out";
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			this.FirstName.HeaderText = "First name";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "Last name";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// Room
			// 
			this.Room.DataPropertyName = "Person_Visiting";
			this.Room.HeaderText = "Person Visiting";
			this.Room.Name = "Room";
			this.Room.ReadOnly = true;
			this.Room.Width = 40;
			// 
			// Time_In
			// 
			this.Time_In.DataPropertyName = "Section";
			this.Time_In.HeaderText = "Time In";
			this.Time_In.Name = "Time_In";
			this.Time_In.ReadOnly = true;
			this.Time_In.Width = 50;
			// 
			// Time_Out
			// 
			this.Time_Out.DataPropertyName = "MealName";
			this.Time_Out.HeaderText = "Time Out";
			this.Time_Out.Name = "Time_Out";
			this.Time_Out.ReadOnly = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Plain_Background;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(135, 60);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1237, 217);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// Visitor_Sign_In
			// 
			this.Visitor_Sign_In.AutoSize = true;
			this.Visitor_Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Visitor_Sign_In.Location = new System.Drawing.Point(634, 64);
			this.Visitor_Sign_In.Name = "Visitor_Sign_In";
			this.Visitor_Sign_In.Size = new System.Drawing.Size(230, 37);
			this.Visitor_Sign_In.TabIndex = 17;
			this.Visitor_Sign_In.Text = "Visitor Sign In";
			// 
			// First_Name_Textbox
			// 
			this.First_Name_Textbox.Location = new System.Drawing.Point(913, 176);
			this.First_Name_Textbox.Name = "First_Name_Textbox";
			this.First_Name_Textbox.Size = new System.Drawing.Size(197, 26);
			this.First_Name_Textbox.TabIndex = 18;
			this.First_Name_Textbox.TextChanged += new System.EventHandler(this.First_Name_Textbox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(453, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "First Name";
			// 
			// Last
			// 
			this.Last.AutoSize = true;
			this.Last.Location = new System.Drawing.Point(710, 151);
			this.Last.Name = "Last";
			this.Last.Size = new System.Drawing.Size(86, 20);
			this.Last.TabIndex = 20;
			this.Last.Text = "Last Name";
			// 
			// Last_Name_Textbox
			// 
			this.Last_Name_Textbox.Location = new System.Drawing.Point(654, 176);
			this.Last_Name_Textbox.Name = "Last_Name_Textbox";
			this.Last_Name_Textbox.Size = new System.Drawing.Size(197, 26);
			this.Last_Name_Textbox.TabIndex = 21;
			this.Last_Name_Textbox.TextChanged += new System.EventHandler(this.Last_Name_Textbox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(955, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "Person Visiting";
			// 
			// Person_Visiting_Textbox
			// 
			this.Person_Visiting_Textbox.Location = new System.Drawing.Point(397, 176);
			this.Person_Visiting_Textbox.Name = "Person_Visiting_Textbox";
			this.Person_Visiting_Textbox.Size = new System.Drawing.Size(197, 26);
			this.Person_Visiting_Textbox.TabIndex = 23;
			this.Person_Visiting_Textbox.TextChanged += new System.EventHandler(this.Person_Visiting_Textbox_TextChanged);
			// 
			// button2
			// 
			this.button2.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
			this.button2.Location = new System.Drawing.Point(687, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 31);
			this.button2.TabIndex = 24;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Visitor_Signin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1478, 968);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Person_Visiting_Textbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Last_Name_Textbox);
			this.Controls.Add(this.Last);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.First_Name_Textbox);
			this.Controls.Add(this.Visitor_Sign_In);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Add_New_User_Button);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Visitor_Signin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visitor_Signin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Add_New_User_Button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView Add_New_User_Button;
		private System.Windows.Forms.DataGridViewButtonColumn Sign_Out;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Room;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time_In;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time_Out;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label Visitor_Sign_In;
		private System.Windows.Forms.TextBox First_Name_Textbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Last;
		private System.Windows.Forms.TextBox Last_Name_Textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Person_Visiting_Textbox;
		private System.Windows.Forms.Button button2;
	}
}