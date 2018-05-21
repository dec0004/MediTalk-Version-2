using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace MedicTalk
{
    public partial class List_Of_Requests : Form
    {
        private Form1 form1;
        public Mysql_Connect _connect;
		public string rowToDel;
		public string timedRowToDel;
		public Add_New_User _newUser;
        public List_Of_Requests(Form1 form1, Mysql_Connect connect)
        {
            this.form1 = form1;
            InitializeComponent();
            _connect = connect;
			
        }

        // Load the list of requests on button click
        private void List_Of_Requests_Load(object sender, EventArgs e)
        {
            Display_Lists();
        }


        /// <summary>
        /// Used to display all requests onto a list
        /// </summary>
        public void Display_Lists()
        {
            // Show requests for food
            Requests_Handler.Show_Requests();
            Add_New_User_Button.DataSource = Requests_Handler.DataTable1;

            // Show requests for wake up calls and showers
            Requests_Handler.Show_Timed_Requests();
            dataGridView1.DataSource = Requests_Handler.DataTable2;
        }


        /// <summary>
        /// Signals that a request has been completed, therefore it no longer
        /// has to display on the list
        /// </summary>
        public void FoodRequest_Completed(object sender, DataGridViewCellEventArgs e)
        {
			
			rowToDel = Add_New_User_Button.Rows[e.RowIndex].Cells[10].Value.ToString();
			Debug.WriteLine(rowToDel);
			
			Requests_Handler.Complete_Request(rowToDel, "NEWFoodRequest");
			// Get the values needed to identify each unique row
			/* string date = RequestsList.Rows[e.RowIndex].Cells[8].Value.ToString();
			 string time = RequestsList.Rows[e.RowIndex].Cells[9].Value.ToString();
			 string uid = RequestsList.Rows[e.RowIndex].Cells[10].Value.ToString();

			 // Have to reformat the string to fix Visual studio's stupid crap
			 // Visual studio formats date to: "MM/DD/YYYY HH:MM:SS" When it needs to be "YYYY-MM-DD"
			 date = date.Replace("/", "-");
			 date = date.Substring(0, date.IndexOf(" ")); // Remove everything after the space

			 string[] _splitdate = date.Split('-'); // Split up d, m, y
			 string[] _reverseddate = new string[3];

			 _reverseddate[0] = _splitdate[2]; // Map date to correct area
			 _reverseddate[1] = _splitdate[0]; // Map month to correct area
			 _reverseddate[2] = _splitdate[1]; // Map day to correct area

			 date = String.Join("-", _reverseddate); // Combine strings

			

			 // If it was able to complete the request, reload the list
			 if (Requests_Handler.Complete_Request(uid, date, time))
			 {
				 Display_Lists();
			 }
			 */
			Display_Lists();
		}

		private void TimedRequestsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			timedRowToDel = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

			Debug.WriteLine(timedRowToDel);

			Requests_Handler.Complete_Request(timedRowToDel, "NEWTimedRequest");
			Display_Lists();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_newUser = new Add_New_User(this, _connect, form1);
		}
	}
}
