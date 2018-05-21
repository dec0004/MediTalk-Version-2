namespace MedicTalk
{
    partial class List_Of_Requests
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Add_New_User_Button = new System.Windows.Forms.DataGridView();
			this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequestedMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HotOrCold = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.At = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoodRequests_Header = new System.Windows.Forms.Label();
			this.TimedRequest_Header = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Add_New_User_Button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Add_New_User_Button
			// 
			this.Add_New_User_Button.AllowUserToAddRows = false;
			this.Add_New_User_Button.AllowUserToDeleteRows = false;
			this.Add_New_User_Button.AllowUserToOrderColumns = true;
			this.Add_New_User_Button.AllowUserToResizeColumns = false;
			this.Add_New_User_Button.AllowUserToResizeRows = false;
			this.Add_New_User_Button.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Add_New_User_Button.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.Add_New_User_Button.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Add_New_User_Button.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Button,
            this.FirstName,
            this.LastName,
            this.Room,
            this.Section,
            this.RequestedMealName,
            this.MealTime,
            this.HotOrCold,
            this.At,
            this.AtTime,
            this.UID});
			this.Add_New_User_Button.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.Add_New_User_Button.Location = new System.Drawing.Point(200, 104);
			this.Add_New_User_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Add_New_User_Button.Name = "Add_New_User_Button";
			this.Add_New_User_Button.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Add_New_User_Button.Size = new System.Drawing.Size(1500, 380);
			this.Add_New_User_Button.TabIndex = 0;
			this.Add_New_User_Button.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodRequest_Completed);
			// 
			// Button
			// 
			this.Button.HeaderText = "Complete";
			this.Button.Name = "Button";
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
			this.Room.DataPropertyName = "Room";
			this.Room.HeaderText = "Room";
			this.Room.Name = "Room";
			this.Room.ReadOnly = true;
			this.Room.Width = 40;
			// 
			// Section
			// 
			this.Section.DataPropertyName = "Section";
			this.Section.HeaderText = "Section";
			this.Section.Name = "Section";
			this.Section.ReadOnly = true;
			this.Section.Width = 50;
			// 
			// RequestedMealName
			// 
			this.RequestedMealName.DataPropertyName = "MealName";
			this.RequestedMealName.HeaderText = "Requested";
			this.RequestedMealName.Name = "RequestedMealName";
			this.RequestedMealName.ReadOnly = true;
			// 
			// MealTime
			// 
			this.MealTime.DataPropertyName = "MealType";
			this.MealTime.HeaderText = "For";
			this.MealTime.Name = "MealTime";
			this.MealTime.ReadOnly = true;
			this.MealTime.Width = 60;
			// 
			// HotOrCold
			// 
			this.HotOrCold.DataPropertyName = "HotOrCold";
			this.HotOrCold.HeaderText = "Hot or cold";
			this.HotOrCold.Name = "HotOrCold";
			this.HotOrCold.ReadOnly = true;
			this.HotOrCold.Width = 50;
			// 
			// At
			// 
			this.At.DataPropertyName = "DateOfRequest";
			this.At.HeaderText = "Date Requested";
			this.At.MinimumWidth = 60;
			this.At.Name = "At";
			this.At.ReadOnly = true;
			this.At.Width = 60;
			// 
			// AtTime
			// 
			this.AtTime.DataPropertyName = "TimeOfRequest";
			this.AtTime.HeaderText = "Time";
			this.AtTime.MinimumWidth = 70;
			this.AtTime.Name = "AtTime";
			this.AtTime.ReadOnly = true;
			this.AtTime.Width = 70;
			// 
			// UID
			// 
			this.UID.DataPropertyName = "UID";
			this.UID.HeaderText = "UID";
			this.UID.MinimumWidth = 45;
			this.UID.Name = "UID";
			this.UID.ReadOnly = true;
			this.UID.Width = 45;
			// 
			// FoodRequests_Header
			// 
			this.FoodRequests_Header.AutoSize = true;
			this.FoodRequests_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FoodRequests_Header.Location = new System.Drawing.Point(844, 48);
			this.FoodRequests_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FoodRequests_Header.Name = "FoodRequests_Header";
			this.FoodRequests_Header.Size = new System.Drawing.Size(245, 29);
			this.FoodRequests_Header.TabIndex = 1;
			this.FoodRequests_Header.Text = "Current food requests";
			// 
			// TimedRequest_Header
			// 
			this.TimedRequest_Header.AutoSize = true;
			this.TimedRequest_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimedRequest_Header.Location = new System.Drawing.Point(803, 500);
			this.TimedRequest_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TimedRequest_Header.Name = "TimedRequest_Header";
			this.TimedRequest_Header.Size = new System.Drawing.Size(347, 29);
			this.TimedRequest_Header.TabIndex = 3;
			this.TimedRequest_Header.Text = "Wake up calls/shower requests";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(200, 546);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(1500, 380);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Completed";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "FirstName";
			this.Column2.HeaderText = "First Name";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "LastName";
			this.Column3.HeaderText = "Last Name";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Room";
			this.Column4.HeaderText = "Room";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Section";
			this.Column5.HeaderText = "Section";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "TypeOfRequest";
			this.Column6.HeaderText = "TypeOfRequest";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "TimeToComplete";
			this.Column7.HeaderText = "TimeToComplete";
			this.Column7.Name = "Column7";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Login_Page4;
			this.button1.Location = new System.Drawing.Point(200, 54);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 42);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add new user";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// List_Of_Requests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1478, 968);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.TimedRequest_Header);
			this.Controls.Add(this.FoodRequests_Header);
			this.Controls.Add(this.Add_New_User_Button);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "List_Of_Requests";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List_Of_Requests";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.List_Of_Requests_Load);
			((System.ComponentModel.ISupportInitialize)(this.Add_New_User_Button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Add_New_User_Button;
        private System.Windows.Forms.Label FoodRequests_Header;
        private System.Windows.Forms.Label TimedRequest_Header;
		private System.Windows.Forms.DataGridViewButtonColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewButtonColumn Button;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Room;
		private System.Windows.Forms.DataGridViewTextBoxColumn Section;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequestedMealName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MealTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn HotOrCold;
		private System.Windows.Forms.DataGridViewTextBoxColumn At;
		private System.Windows.Forms.DataGridViewTextBoxColumn AtTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn UID;
		private System.Windows.Forms.Button button1;
	}
}