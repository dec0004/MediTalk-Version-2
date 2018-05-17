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
	public partial class Alarm : Form
	{
		public HomePage homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		public string Hour;
		public string Minute;
		public Request_Emergency _emergencyRequest;

		public Alarm(HomePage _homePage, Mysql_Connect connect, Form1 _form1)
		{
			InitializeComponent();
			string[] _Hour = new string[24];
			string[] _minutes = new string[60];
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			_emergencyRequest = new Request_Emergency(_connect, form1);

			for (int i = 0; i < _Hour.Length; i++)
			{
				_Hour[i] = i.ToString();
			}
			for (int i = 0; i < _minutes.Length; i++)
			{
				_minutes[i] = i.ToString();
			}

			this.Hour_Box.Items.AddRange(_Hour);
			this.Minute_Box.Items.AddRange(_minutes);
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			// Load current alarms the user has already
			Display_Alarms();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}

		// Once user has clicked on submit
		private void Submit_Button_Click(object sender, EventArgs e)
		{
			if (Hour_Box.Text == "Hour" || Minute_Box.Text == "Minutes")
			{
				MessageBox.Show("You must enter all details");
			}
			else
			{
				Requests_Handler.Add_Timed_Request("alarm", Hour + ":" + Minute + ":00");
				MessageBox.Show("You have added an alarm");
			}
			// Reload the alarms so the datagridview is updated
			Display_Alarms();
		}


		// Once user has changed the hour
		private void Hour_Changed(object sender, EventArgs e)
		{
			Hour = Hour_Box.Text;
		}


		// Once user changed the minute
		private void Minute_Changed(object sender, EventArgs e)
		{
			Minute = Minute_Box.Text;
		}


		// Remove an alarm once a user has clicked on it
		private void Remove_Alarm(object sender, DataGridViewCellEventArgs e)
		{

			// Get the value of the 1st column for the alarm
			// that the user wants to delete
			int TheRow = e.RowIndex;
			string alarm_time = AlarmsList.Rows[TheRow].Cells[1].Value.ToString();

			// If the alarm was deleted refresh the datagridview
			if (Requests_Handler.Delete_Alarm(alarm_time))
			{
				Display_Alarms();
			}
		}

		// Load all alarms
		private void Display_Alarms()
		{
			Requests_Handler.Show_Alarms();
			AlarmsList.DataSource = Requests_Handler.DataTable;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_emergencyRequest.CallRequest();
		}
	}
}
