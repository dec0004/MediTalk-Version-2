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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.RequestsList = new System.Windows.Forms.DataGridView();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequestedMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HotOrCold = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.At = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Completed = new System.Windows.Forms.DataGridViewButtonColumn();
			this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoodRequests_Header = new System.Windows.Forms.Label();
			this.TimedRequestsList = new System.Windows.Forms.DataGridView();
			this.TimedRequest_Header = new System.Windows.Forms.Label();
			this.New_Request_Notification_Timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.RequestsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TimedRequestsList)).BeginInit();
			this.SuspendLayout();
			// 
			// RequestsList
			// 
			this.RequestsList.AllowUserToAddRows = false;
			this.RequestsList.AllowUserToDeleteRows = false;
			this.RequestsList.AllowUserToOrderColumns = true;
			this.RequestsList.AllowUserToResizeColumns = false;
			this.RequestsList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RequestsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.RequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.RequestsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Room,
            this.Section,
            this.RequestedMealName,
            this.MealTime,
            this.HotOrCold,
            this.At,
            this.AtTime,
            this.Completed,
            this.UID});
			this.RequestsList.Location = new System.Drawing.Point(39, 132);
			this.RequestsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RequestsList.Name = "RequestsList";
			this.RequestsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.RequestsList.Size = new System.Drawing.Size(1146, 380);
			this.RequestsList.TabIndex = 0;
			this.RequestsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodRequest_Completed);
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
			// Completed
			// 
			this.Completed.DataPropertyName = "Completed";
			this.Completed.HeaderText = "Completed?";
			this.Completed.Name = "Completed";
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
			this.FoodRequests_Header.Location = new System.Drawing.Point(52, 83);
			this.FoodRequests_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FoodRequests_Header.Name = "FoodRequests_Header";
			this.FoodRequests_Header.Size = new System.Drawing.Size(245, 29);
			this.FoodRequests_Header.TabIndex = 1;
			this.FoodRequests_Header.Text = "Current food requests";
			// 
			// TimedRequestsList
			// 
			this.TimedRequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TimedRequestsList.Location = new System.Drawing.Point(39, 583);
			this.TimedRequestsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TimedRequestsList.Name = "TimedRequestsList";
			this.TimedRequestsList.Size = new System.Drawing.Size(1146, 306);
			this.TimedRequestsList.TabIndex = 2;
			// 
			// TimedRequest_Header
			// 
			this.TimedRequest_Header.AutoSize = true;
			this.TimedRequest_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimedRequest_Header.Location = new System.Drawing.Point(52, 534);
			this.TimedRequest_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TimedRequest_Header.Name = "TimedRequest_Header";
			this.TimedRequest_Header.Size = new System.Drawing.Size(347, 29);
			this.TimedRequest_Header.TabIndex = 3;
			this.TimedRequest_Header.Text = "Wake up calls/shower requests";
			// 
			// New_Request_Notification_Timer
			// 
			this.New_Request_Notification_Timer.Enabled = true;
			this.New_Request_Notification_Timer.Interval = 10000;
			this.New_Request_Notification_Timer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// List_Of_Requests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1236, 968);
			this.Controls.Add(this.TimedRequest_Header);
			this.Controls.Add(this.TimedRequestsList);
			this.Controls.Add(this.FoodRequests_Header);
			this.Controls.Add(this.RequestsList);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "List_Of_Requests";
			this.Text = "List_Of_Requests";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.List_Of_Requests_Load);
			((System.ComponentModel.ISupportInitialize)(this.RequestsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TimedRequestsList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestsList;
        private System.Windows.Forms.Label FoodRequests_Header;
        private System.Windows.Forms.DataGridView TimedRequestsList;
        private System.Windows.Forms.Label TimedRequest_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedMealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotOrCold;
        private System.Windows.Forms.DataGridViewTextBoxColumn At;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtTime;
        private System.Windows.Forms.DataGridViewButtonColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
		private System.Windows.Forms.Timer New_Request_Notification_Timer;
	}
}