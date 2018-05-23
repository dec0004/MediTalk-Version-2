using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicTalk
{
    public partial class List_Of_Incidents : Form
    {
        private Form1 _form1;
        private List_Of_Requests _listOfRequests;
        private string originalDescription; // Used to store the old description of the incident.
        private string user_UID;
        private string user_fullName;
        private string searchStartDate;
        private string searchEndDate;

        public List_Of_Incidents(List_Of_Requests requestsList, Form1 form1)
        {
            InitializeComponent();
            _listOfRequests = requestsList;
            _form1 = form1;
        }


        // Handle the GUI functionality for user searching
        private void Input_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Populate_User_Search_List();
            }
        }

        private void Search_Button_Click(object sender, MouseEventArgs e)
        {
            Populate_User_Search_List();
        }

        public void Populate_User_Search_List()
        {
            //Clear the ListView of all entries
            UserSearch_List.Items.Clear();
            
            // Run MySQL statement to find incidents by user name. It will populate the list
            // that's called in the foreach loop below. Only populate the list if incidents
            // exist in the database for that name
            if (Incidents.Get_Incidents_By_Name(Search_User_Textbox.Text) || Incidents.Get_Incidents_By_Dates(searchStartDate, searchEndDate)) {
                foreach (RecordedIncident r in Incidents.ListOfIncidents)
                {
                    // First item is the UID. It's hidden in the list view, but
                    // the UID is needed to fill in the incident report details.
                    ListViewItem lvi = new ListViewItem(r.User_id); 
                    lvi.SubItems.Add(r.First_name + " " + r.Last_name);
                    lvi.SubItems.Add(r.Incident_date);
                    lvi.SubItems.Add(r.Incident_time);
                    lvi.SubItems.Add(r.Incident_description);
                    UserSearch_List.Items.Add(lvi);

                    user_UID = r.User_id;
                    user_fullName = r.First_name + " " + r.Last_name;

                    Add_Incident_Button.Enabled = true; // Also allow user to add a new incident for the user
                }
            }
            else
            {
                Add_Incident_Button.Enabled = false;
                MessageBox.Show("No incidents found. Most likely due to incorrect name");
            }
        }



        private void Incident_Record_Clicked(object sender, EventArgs e)
        {
            ListViewItem lviSelectedIncident = UserSearch_List.FocusedItem;
            
            // Enable the edit button
            Edit_Button.Enabled = true;

            // Disable the text box for description
            IncidentDescriber_TextBox.Enabled = false;
            
            // Add all details to report
            label_UID.Text = lviSelectedIncident.SubItems[0].Text;
            label_residentName.Text = lviSelectedIncident.SubItems[1].Text;
            label_Date.Text = lviSelectedIncident.SubItems[2].Text;
            label_Time.Text = lviSelectedIncident.SubItems[3].Text;
            IncidentDescriber_TextBox.Text = lviSelectedIncident.SubItems[4].Text;

            // Have to reformat the string to fix Visual studio's stupid crap
            // Visual studio formats date to: "MM/DD/YYYY HH:MM:SS" When it needs to be "YYYY-MM-DD"
            label_Date.Text = label_Date.Text.Replace("/", "-");
            label_Date.Text = label_Date.Text.Substring(0, label_Date.Text.IndexOf(" ")); // Remove everything after the space

            string[] _splitdate = label_Date.Text.Split('-'); // Split up d, m, y
            string[] _reverseddate = new string[3];

            _reverseddate[0] = _splitdate[2]; // Map date to correct area
            _reverseddate[1] = _splitdate[0]; // Map month to correct area
            _reverseddate[2] = _splitdate[1]; // Map day to correct area

            label_Date.Text = String.Join("-", _reverseddate); // Combine strings



            // Add the description, so that when the user updates,
            // the old description is stored for comparison
            originalDescription = lviSelectedIncident.SubItems[4].Text;
        }

        /// <summary>
        /// Enable the user to edit the incident description
        /// </summary>
        private void Edit_Button_Clicked(object sender, MouseEventArgs e)
        {
            IncidentDescriber_TextBox.Enabled = true;
            Update_Button.Enabled = true;
        }


        /// <summary>
        /// Update the incident's description to what the user has entered
        /// </summary>
        private void Update_Button_Clicked(object sender, EventArgs e)
        {
            string uid = label_UID.Text;
            Console.WriteLine("UID = " + uid);
            Incidents.Update_Incident(uid, originalDescription, IncidentDescriber_TextBox.Text);
            
            // Repopulate the list, so the new description is can be seen
            Populate_User_Search_List();
        }


        /// <summary>
        /// Used to add a new incident for user
        /// </summary>
        private void Add_Incident_Button_Clicked(object sender, EventArgs e)
        {
            Incident_Input incidentInput = new Incident_Input(this, user_UID, user_fullName);
            incidentInput.ShowDialog(); // Freeze this form while other form is open
        }


        private void Date_Search_Button_Clicked(object sender, EventArgs e)
        {
            string startDate = From_date_input.Text;
            string endDate = To_date_input.Text;

            // Have to reformat strings for MySQL
            startDate = startDate.Replace("/", "-");
            endDate = endDate.Replace("/", "-");
            string[] _splitdate = startDate.Split('-'); // Split up d, m, y
            string[] _reverseddate = new string[3];

            // Map values to correct areas so they're YYYY-MM-DD
            _reverseddate[0] = _splitdate[2]; 
            _reverseddate[1] = _splitdate[1]; 
            _reverseddate[2] = _splitdate[0]; 
            startDate = String.Join("-", _reverseddate); // Combine strings

            _splitdate = endDate.Split('-'); // Split up d, m, y
            _reverseddate = new string[3];

            // Map values to correct areas so they're YYYY-MM-DD
            _reverseddate[0] = _splitdate[2];
            _reverseddate[1] = _splitdate[1];
            _reverseddate[2] = _splitdate[0];
            endDate = String.Join("-", _reverseddate); // Combine strings

            searchStartDate = startDate;
            searchEndDate = endDate;

            Populate_User_Search_List();
            
        }


        private void Requests_Button_Click(object sender, EventArgs e)
        {
            _listOfRequests.Show();
            this.Hide();
        }
    }
}
