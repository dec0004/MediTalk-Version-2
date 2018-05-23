namespace MedicTalk
{
    partial class List_Of_Incidents
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
            this.SearchByUser_Box = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.Search_User_Textbox = new System.Windows.Forms.TextBox();
            this.UserSearch_List = new System.Windows.Forms.ListView();
            this.UID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfIncident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeOfIncident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_residentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IncidentDescriber_TextBox = new System.Windows.Forms.RichTextBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label_UID = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Incident_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Incident_date_search = new System.Windows.Forms.GroupBox();
            this.Search_Date_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.From_text = new System.Windows.Forms.Label();
            this.To_date_input = new System.Windows.Forms.TextBox();
            this.From_date_input = new System.Windows.Forms.TextBox();
            this.Requests_Button = new System.Windows.Forms.Button();
            this.SearchByUser_Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Incident_date_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchByUser_Box
            // 
            this.SearchByUser_Box.Controls.Add(this.Search);
            this.SearchByUser_Box.Controls.Add(this.Search_User_Textbox);
            this.SearchByUser_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByUser_Box.Location = new System.Drawing.Point(580, 30);
            this.SearchByUser_Box.Name = "SearchByUser_Box";
            this.SearchByUser_Box.Size = new System.Drawing.Size(347, 61);
            this.SearchByUser_Box.TabIndex = 1;
            this.SearchByUser_Box.TabStop = false;
            this.SearchByUser_Box.Text = "Search by user";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(238, 23);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(103, 24);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Search_Button_Click);
            // 
            // Search_User_Textbox
            // 
            this.Search_User_Textbox.Location = new System.Drawing.Point(6, 23);
            this.Search_User_Textbox.Name = "Search_User_Textbox";
            this.Search_User_Textbox.Size = new System.Drawing.Size(226, 24);
            this.Search_User_Textbox.TabIndex = 0;
            this.Search_User_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_Keydown);
            // 
            // UserSearch_List
            // 
            this.UserSearch_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UID,
            this.FullName,
            this.DateOfIncident,
            this.TimeOfIncident,
            this.Description});
            this.UserSearch_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearch_List.FullRowSelect = true;
            this.UserSearch_List.Location = new System.Drawing.Point(580, 262);
            this.UserSearch_List.Name = "UserSearch_List";
            this.UserSearch_List.Size = new System.Drawing.Size(347, 267);
            this.UserSearch_List.TabIndex = 2;
            this.UserSearch_List.UseCompatibleStateImageBehavior = false;
            this.UserSearch_List.View = System.Windows.Forms.View.Details;
            this.UserSearch_List.SelectedIndexChanged += new System.EventHandler(this.Incident_Record_Clicked);
            // 
            // UID
            // 
            this.UID.Width = 0;
            // 
            // FullName
            // 
            this.FullName.Text = "Name";
            this.FullName.Width = 138;
            // 
            // DateOfIncident
            // 
            this.DateOfIncident.Text = "Date occured";
            this.DateOfIncident.Width = 93;
            // 
            // TimeOfIncident
            // 
            this.TimeOfIncident.Text = "Time occured";
            this.TimeOfIncident.Width = 112;
            // 
            // Description
            // 
            this.Description.Width = 0;
            // 
            // label_residentName
            // 
            this.label_residentName.AutoSize = true;
            this.label_residentName.Location = new System.Drawing.Point(89, 30);
            this.label_residentName.Name = "label_residentName";
            this.label_residentName.Size = new System.Drawing.Size(45, 18);
            this.label_residentName.TabIndex = 3;
            this.label_residentName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incident description:";
            // 
            // IncidentDescriber_TextBox
            // 
            this.IncidentDescriber_TextBox.Enabled = false;
            this.IncidentDescriber_TextBox.Location = new System.Drawing.Point(12, 114);
            this.IncidentDescriber_TextBox.Name = "IncidentDescriber_TextBox";
            this.IncidentDescriber_TextBox.Size = new System.Drawing.Size(511, 415);
            this.IncidentDescriber_TextBox.TabIndex = 5;
            this.IncidentDescriber_TextBox.Text = "";
            // 
            // Edit_Button
            // 
            this.Edit_Button.Enabled = false;
            this.Edit_Button.Location = new System.Drawing.Point(223, 535);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(138, 31);
            this.Edit_Button.TabIndex = 6;
            this.Edit_Button.Text = "Edit description";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Edit_Button_Clicked);
            // 
            // Update_Button
            // 
            this.Update_Button.Enabled = false;
            this.Update_Button.Location = new System.Drawing.Point(367, 535);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(156, 31);
            this.Update_Button.TabIndex = 7;
            this.Update_Button.Text = "Update description";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Clicked);
            // 
            // label_UID
            // 
            this.label_UID.AutoSize = true;
            this.label_UID.Location = new System.Drawing.Point(89, 59);
            this.label_UID.Name = "label_UID";
            this.label_UID.Size = new System.Drawing.Size(22, 18);
            this.label_UID.TabIndex = 8;
            this.label_UID.Text = "ID";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(386, 30);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(36, 18);
            this.label_Date.TabIndex = 9;
            this.label_Date.Text = "date";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(386, 59);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(36, 18);
            this.label_Time.TabIndex = 10;
            this.label_Time.Text = "time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date occurred:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time occurred:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resident: ";
            // 
            // Add_Incident_Button
            // 
            this.Add_Incident_Button.Enabled = false;
            this.Add_Incident_Button.Location = new System.Drawing.Point(771, 535);
            this.Add_Incident_Button.Name = "Add_Incident_Button";
            this.Add_Incident_Button.Size = new System.Drawing.Size(156, 31);
            this.Add_Incident_Button.TabIndex = 15;
            this.Add_Incident_Button.Text = "Add new incident";
            this.Add_Incident_Button.UseVisualStyleBackColor = true;
            this.Add_Incident_Button.Click += new System.EventHandler(this.Add_Incident_Button_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Incident_date_search);
            this.groupBox1.Controls.Add(this.Add_Incident_Button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SearchByUser_Box);
            this.groupBox1.Controls.Add(this.UserSearch_List);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_residentName);
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IncidentDescriber_TextBox);
            this.groupBox1.Controls.Add(this.Update_Button);
            this.groupBox1.Controls.Add(this.label_UID);
            this.groupBox1.Controls.Add(this.Edit_Button);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 575);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incidents";
            // 
            // Incident_date_search
            // 
            this.Incident_date_search.Controls.Add(this.Search_Date_Button);
            this.Incident_date_search.Controls.Add(this.label7);
            this.Incident_date_search.Controls.Add(this.label6);
            this.Incident_date_search.Controls.Add(this.From_text);
            this.Incident_date_search.Controls.Add(this.To_date_input);
            this.Incident_date_search.Controls.Add(this.From_date_input);
            this.Incident_date_search.Location = new System.Drawing.Point(580, 97);
            this.Incident_date_search.Name = "Incident_date_search";
            this.Incident_date_search.Size = new System.Drawing.Size(347, 148);
            this.Incident_date_search.TabIndex = 16;
            this.Incident_date_search.TabStop = false;
            this.Incident_date_search.Text = "Search by date";
            // 
            // Search_Date_Button
            // 
            this.Search_Date_Button.Location = new System.Drawing.Point(238, 111);
            this.Search_Date_Button.Name = "Search_Date_Button";
            this.Search_Date_Button.Size = new System.Drawing.Size(103, 31);
            this.Search_Date_Button.TabIndex = 5;
            this.Search_Date_Button.Text = "Search";
            this.Search_Date_Button.UseVisualStyleBackColor = true;
            this.Search_Date_Button.Click += new System.EventHandler(this.Date_Search_Button_Clicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter in format: DD/MM/YYYY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "To";
            // 
            // From_text
            // 
            this.From_text.AutoSize = true;
            this.From_text.Location = new System.Drawing.Point(70, 51);
            this.From_text.Name = "From_text";
            this.From_text.Size = new System.Drawing.Size(44, 18);
            this.From_text.TabIndex = 2;
            this.From_text.Text = "From";
            // 
            // To_date_input
            // 
            this.To_date_input.Location = new System.Drawing.Point(120, 81);
            this.To_date_input.Name = "To_date_input";
            this.To_date_input.Size = new System.Drawing.Size(221, 24);
            this.To_date_input.TabIndex = 1;
            // 
            // From_date_input
            // 
            this.From_date_input.Location = new System.Drawing.Point(120, 51);
            this.From_date_input.Name = "From_date_input";
            this.From_date_input.Size = new System.Drawing.Size(221, 24);
            this.From_date_input.TabIndex = 0;
            // 
            // Requests_Button
            // 
            this.Requests_Button.Location = new System.Drawing.Point(12, 12);
            this.Requests_Button.Name = "Requests_Button";
            this.Requests_Button.Size = new System.Drawing.Size(97, 23);
            this.Requests_Button.TabIndex = 5;
            this.Requests_Button.Text = "Requests";
            this.Requests_Button.UseVisualStyleBackColor = true;
            this.Requests_Button.Click += new System.EventHandler(this.Requests_Button_Click);
            // 
            // List_Of_Incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 629);
            this.Controls.Add(this.Requests_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "List_Of_Incidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Of_Incidents";
            this.SearchByUser_Box.ResumeLayout(false);
            this.SearchByUser_Box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Incident_date_search.ResumeLayout(false);
            this.Incident_date_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchByUser_Box;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Search_User_Textbox;
        private System.Windows.Forms.ListView UserSearch_List;
        private System.Windows.Forms.ColumnHeader UID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader DateOfIncident;
        private System.Windows.Forms.ColumnHeader TimeOfIncident;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label_residentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox IncidentDescriber_TextBox;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label_UID;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Incident_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Incident_date_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label From_text;
        private System.Windows.Forms.TextBox To_date_input;
        private System.Windows.Forms.TextBox From_date_input;
        private System.Windows.Forms.Button Search_Date_Button;
        private System.Windows.Forms.Button Requests_Button;
    }
}