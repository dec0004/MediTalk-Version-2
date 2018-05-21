namespace MedicTalk
{
	partial class Order_Food
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
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.ColdCheckbox = new System.Windows.Forms.CheckBox();
			this.WarmCheckbox = new System.Windows.Forms.CheckBox();
			this.HotCheckbox = new System.Windows.Forms.CheckBox();
			this.MealType_Header = new System.Windows.Forms.Label();
			this.MealSelection = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Icon_Return;
			this.button1.Location = new System.Drawing.Point(4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 85);
			this.button1.TabIndex = 9;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
			this.button2.Location = new System.Drawing.Point(350, 465);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 31);
			this.button2.TabIndex = 10;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Submit_Clicked);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Plain_Background;
			this.pictureBox2.Location = new System.Drawing.Point(134, 75);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(550, 368);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// ColdCheckbox
			// 
			this.ColdCheckbox.AutoSize = true;
			this.ColdCheckbox.Location = new System.Drawing.Point(224, 168);
			this.ColdCheckbox.Name = "ColdCheckbox";
			this.ColdCheckbox.Size = new System.Drawing.Size(67, 24);
			this.ColdCheckbox.TabIndex = 12;
			this.ColdCheckbox.Text = "Cold";
			this.ColdCheckbox.UseVisualStyleBackColor = true;
			this.ColdCheckbox.CheckedChanged += new System.EventHandler(this.ColdCheckbox_Checked);
			// 
			// WarmCheckbox
			// 
			this.WarmCheckbox.AutoSize = true;
			this.WarmCheckbox.Location = new System.Drawing.Point(362, 168);
			this.WarmCheckbox.Name = "WarmCheckbox";
			this.WarmCheckbox.Size = new System.Drawing.Size(77, 24);
			this.WarmCheckbox.TabIndex = 13;
			this.WarmCheckbox.Text = "Warm";
			this.WarmCheckbox.UseVisualStyleBackColor = true;
			this.WarmCheckbox.CheckedChanged += new System.EventHandler(this.WarmCheckbox_Checked);
			// 
			// HotCheckbox
			// 
			this.HotCheckbox.AutoSize = true;
			this.HotCheckbox.Location = new System.Drawing.Point(507, 168);
			this.HotCheckbox.Name = "HotCheckbox";
			this.HotCheckbox.Size = new System.Drawing.Size(61, 24);
			this.HotCheckbox.TabIndex = 14;
			this.HotCheckbox.Text = "Hot";
			this.HotCheckbox.UseVisualStyleBackColor = true;
			this.HotCheckbox.CheckedChanged += new System.EventHandler(this.HotCheckBoxChecked);
			// 
			// MealType_Header
			// 
			this.MealType_Header.AutoSize = true;
			this.MealType_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MealType_Header.Location = new System.Drawing.Point(321, 85);
			this.MealType_Header.Name = "MealType_Header";
			this.MealType_Header.Size = new System.Drawing.Size(194, 47);
			this.MealType_Header.TabIndex = 15;
			this.MealType_Header.Text = "Breakfast";
			// 
			// MealSelection
			// 
			this.MealSelection.FormattingEnabled = true;
			this.MealSelection.Location = new System.Drawing.Point(273, 290);
			this.MealSelection.Name = "MealSelection";
			this.MealSelection.Size = new System.Drawing.Size(295, 28);
			this.MealSelection.TabIndex = 19;
			this.MealSelection.Text = "Make your choice";
			this.MealSelection.SelectedIndexChanged += new System.EventHandler(this.MealSelectionBox_Changed);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(358, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 20);
			this.label4.TabIndex = 20;
			this.label4.Text = "Todays options";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Info;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(306, 9);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.label9.Size = new System.Drawing.Size(203, 58);
			this.label9.TabIndex = 36;
			this.label9.Text = "MediTalk";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::MedicTalk.Properties.Resources.Emergency3;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(4, 96);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(89, 85);
			this.button3.TabIndex = 39;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_2);
			// 
			// Order_Food
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background1;
			this.ClientSize = new System.Drawing.Size(812, 528);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MealSelection);
			this.Controls.Add(this.MealType_Header);
			this.Controls.Add(this.HotCheckbox);
			this.Controls.Add(this.WarmCheckbox);
			this.Controls.Add(this.ColdCheckbox);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Order_Food";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.CheckBox ColdCheckbox;
		public System.Windows.Forms.CheckBox WarmCheckbox;
		public System.Windows.Forms.CheckBox HotCheckbox;
		private System.Windows.Forms.Label MealType_Header;
		public System.Windows.Forms.ComboBox MealSelection;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
	}
}