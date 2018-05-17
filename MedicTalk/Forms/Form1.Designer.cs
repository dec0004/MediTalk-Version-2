namespace MedicTalk
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.Username_Textbox = new System.Windows.Forms.TextBox();
			this.Password_Textbox = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.Login = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Username_Textbox
			// 
			this.Username_Textbox.Location = new System.Drawing.Point(262, 206);
			this.Username_Textbox.Name = "Username_Textbox";
			this.Username_Textbox.Size = new System.Drawing.Size(272, 26);
			this.Username_Textbox.TabIndex = 1;
			this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
			// 
			// Password_Textbox
			// 
			this.Password_Textbox.Location = new System.Drawing.Point(263, 283);
			this.Password_Textbox.Name = "Password_Textbox";
			this.Password_Textbox.Size = new System.Drawing.Size(272, 26);
			this.Password_Textbox.TabIndex = 2;
			this.Password_Textbox.TextChanged += new System.EventHandler(this.Password_Textbox_Changed);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.SystemColors.Info;
			this.Login.Location = new System.Drawing.Point(346, 356);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(110, 36);
			this.Login.TabIndex = 10;
			this.Login.Text = "Login";
			this.Login.UseVisualStyleBackColor = false;
			this.Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Info;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(306, 10);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.label9.Size = new System.Drawing.Size(203, 58);
			this.label9.TabIndex = 37;
			this.label9.Text = "MediTalk";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Image = global::MedicTalk.Properties.Resources.Login_Page4;
			this.label5.Location = new System.Drawing.Point(324, 254);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "Enter Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Image = global::MedicTalk.Properties.Resources.Login_Page4;
			this.label4.Location = new System.Drawing.Point(326, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Enter Username";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Login_Page2;
			this.pictureBox2.Location = new System.Drawing.Point(208, 136);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(381, 292);
			this.pictureBox2.TabIndex = 38;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background;
			this.ClientSize = new System.Drawing.Size(812, 526);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Password_Textbox);
			this.Controls.Add(this.Username_Textbox);
			this.Controls.Add(this.pictureBox2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Forgot_Password;
		private System.Windows.Forms.Button Forgot_UserName;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Username_Textbox;
		private System.Windows.Forms.TextBox Password_Textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

