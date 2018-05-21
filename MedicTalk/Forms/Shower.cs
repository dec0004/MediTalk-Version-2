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
	public partial class Shower : Form
	{
		public HomePage homePage;
		public Mysql_Connect connect;
		public Form1 form1;
		public string _hour;
		public string _minute;
		public string _time;
		public string _type;
		List<string> Parameters;
		List<string> ParameterValues;
		public Request_Emergency _emergencyRequest;
		public System.Windows.Forms.DialogResult result;
		public Shower(HomePage _homePage, Mysql_Connect _connect, Form1 _form1)
		{
			_hour = "";
			_minute = "";
			_time = "";
			_type = "";
			form1 = _form1;
			homePage = _homePage;
			connect = _connect;
			InitializeComponent();
			_emergencyRequest = new Request_Emergency(_connect, form1);
			string[] _hours = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
			this.comboBox1.Items.AddRange(_hours);
			string[] _minutes = new string[] { "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" };
			this.comboBox2.Items.AddRange(_minutes);
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			toolTip1.SetToolTip(button3, "Request Emergency");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}


		public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			_hour = comboBox1.Text;
		}

		public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			_minute = comboBox2.Text;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}


        public void Shower_Button_Changed(object sender, EventArgs e)
        {
            _type = Shower_Button.Text;
        }

        private void Bath_Button_Changed(object sender, EventArgs e)
        {
            _type = Bath_Button.Text;
        }


        public void Submit_Button_Click(object sender, EventArgs e)
        {

            Requests_Handler.Add_Timed_Request(_type, _hour + ":" + _minute + ":00");
            result = MessageBox.Show("Your request has been acknowledged");
            /*
            _time = _hour + ":" + _minute;
            Parameters = new List<string>();
            Parameters.Add("User_id");
            Parameters.Add("Type_of");
            Parameters.Add("Choice");
            Parameters.Add("First_Name");
            Parameters.Add("Last_Name");
            Parameters.Add("Section");
            Parameters.Add("Room");
            ParameterValues = new List<string>();
            ParameterValues.Add(form1.UserIDProperty);
            ParameterValues.Add("Bathing");
            ParameterValues.Add(_type);
            ParameterValues.Add(form1.FirstNameProperty);
            ParameterValues.Add(form1.LastNameProperty);
            ParameterValues.Add(form1.SectionProperty);
            ParameterValues.Add(form1.RoomProperty);
            _time = _hour + ":" + _minute;

            connect.Insert("INSERT INTO Requests (User_id, Type_of, Choice, First_Name, Last_Name, Section, Room) VALUES (@User_id, @Type_of, @Choice, @First_Name, @Last_Name, @Section, @Room);", Parameters, ParameterValues);
            MessageBox.Show("Your request has been acknowledged");*/
        }


		private void button3_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_emergencyRequest.CallRequest();
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}
	}
}
