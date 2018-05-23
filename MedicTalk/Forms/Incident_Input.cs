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
    public partial class Incident_Input : Form
    {
        private List_Of_Incidents _incidentsForm;
        private string _user_id;
        private string _user_fullName;

        public Incident_Input(List_Of_Incidents incidentForm, string userid, string userFullName)
        {
            InitializeComponent();
            _user_fullName = userFullName;
            Incident_Header.Text = "Add incident for: " + _user_fullName;
            _user_id = userid;
            _incidentsForm = incidentForm;
        }

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            this.Hide();

            Incidents.Add_Incident(_user_id, Description_Textbox.Text);
            // Repopulate the list, so the new description is can be seen
            _incidentsForm.Populate_User_Search_List();            

        }

        private void Cancel_Button_Clicked(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
