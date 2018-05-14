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
	public partial class Visitor : Form
	{
		public HomePage _homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		public string _firstName;
		public string _lastName;
		public string _hour;
		public string _minute;
		public string _date;
		public string _time;
		List<string> Parameters;
		List<string> ParameterValues;
		public Request_Emergency _emergencyRequest;
		public Visitor(HomePage _homePage, Mysql_Connect connect, Form1 _form1)
		{
			InitializeComponent();
			this._homePage = _homePage;
			this._connect = connect;
			this.form1 = _form1;
			_firstName = "";
			_lastName = "";
			_hour = "";
			_minute = "";
			_date = "";
			_time = "";
			_emergencyRequest = new Request_Emergency(_connect, form1);

			string[] _hours = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
			this.comboBox1.Items.AddRange(_hours);
			string[] _minutes = new string[] { "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" };
			this.comboBox2.Items.AddRange(_minutes);
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button3.BackgroundImageLayout = ImageLayout.Stretch;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			_firstName = textBox1.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			_lastName = textBox2.Text;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			_hour = comboBox1.Text;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			_minute = comboBox2.Text;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			_date = dateTimePicker1.Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Visitor_fName");
			Parameters.Add("Visitor_lName");
			Parameters.Add("Visitor_d");
			Parameters.Add("Visit_t");
			ParameterValues = new List<string>();
			//ParameterValues.Add(form1.UserIDProperty.ToString());
			ParameterValues.Add(_firstName);
			ParameterValues.Add(_lastName);
			ParameterValues.Add(_date);
			ParameterValues.Add(_time);
			_time = _hour + ":" + _minute;
	
			_connect.Insert("INSERT INTO Visits (User_id, Visitor_first_name, Visitor_last_name, Visitor_date, Visit_time) VALUES (@User_id, @Visitor_fName, @Visitor_lName, @Visitor_d, @Visit_t);", Parameters, ParameterValues);
			MessageBox.Show("You have registered your visit!");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_homePage.Show();
			this.Hide();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_emergencyRequest.CallRequest();
		}
	}
}
