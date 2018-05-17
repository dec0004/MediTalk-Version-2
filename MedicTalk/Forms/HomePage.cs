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
	public partial class HomePage : Form
	{
		private Form1 form1;
        private Alarm _alarm;
		private Order_Food _orderFood;
		private Shower _shower;
		public Mysql_Connect _connect;
		public Request_Emergency _emergencyRequest;
		public Visitor _visitor;
		List<string> Parameters;
		List<string> ParameterValues;
		public bool result;

		public HomePage(Form1 form1, Mysql_Connect connect)
		{
			this.form1 = form1;
			InitializeComponent();
			_connect = connect;
			_emergencyRequest = new Request_Emergency(_connect, form1);
		
			////Initialize button icons to fit button size
			BreakFast_Button.BackgroundImageLayout = ImageLayout.Stretch;
			LunchButton.BackgroundImageLayout = ImageLayout.Stretch;
			Dinner_Button.BackgroundImageLayout = ImageLayout.Stretch;
			button9.BackgroundImageLayout = ImageLayout.Stretch;
			button4.BackgroundImageLayout = ImageLayout.Stretch;
			button5.BackgroundImageLayout = ImageLayout.Stretch;
			button6.BackgroundImageLayout = ImageLayout.Stretch;
		
			button8.BackgroundImageLayout = ImageLayout.Stretch;
			button10.BackgroundImageLayout = ImageLayout.Stretch;
			

		}

		//Logout button
		private void button4_Click(object sender, EventArgs e)
		{
			var _confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm logout", MessageBoxButtons.YesNo);

			if (_confirm == DialogResult.Yes)
			{
				this.Hide();
				form1.Logout();
				form1.UserNameProperty = "";
				form1.PasswordProperty = "";
				//form1.UserIDProperty = "0";
			}
			
		}


		//Alarm Icon
		private void button6_Click(object sender, EventArgs e)
		{
			_alarm = new MedicTalk.Alarm(this, _connect, form1);
			this.Hide();
			_alarm.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			_visitor = new MedicTalk.Visitor(this, _connect, form1);
			this.Hide();
			_visitor.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			_shower = new MedicTalk.Shower(this, _connect, form1);
			this.Hide();
			_shower.Show();
		}


        // Request breakfast
        private void BreakfastButton_Click(object sender, EventArgs e)
        {
            _orderFood = new MedicTalk.Order_Food(this, _connect, form1, _emergencyRequest, "breakfast");
            this.Hide();
			_orderFood.Show();

        }

        // Request Lunch
        private void LunchButton_Click(object sender, EventArgs e)
        {
            _orderFood = new MedicTalk.Order_Food(this, _connect, form1, _emergencyRequest, "lunch");
            this.Hide();
            _orderFood.Show();
        }

        // Request dinner
        private void DinnerButton_Click(object sender, EventArgs e)
        {
            _orderFood = new MedicTalk.Order_Food(this, _connect, form1, _emergencyRequest, "dinner");
            this.Hide();
            _orderFood.Show();
        }

        // Request drinks
        private void DrinkButton_Click(object sender, EventArgs e)
        {
            _orderFood = new MedicTalk.Order_Food(this, _connect, form1, _emergencyRequest, "drink");
            this.Hide();
            _orderFood.Show();
        }
		

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_emergencyRequest.CallRequest();
		}

		public void button10_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Type_of_request");
			Parameters.Add("Date_to_complete");
			Parameters.Add("Time_to_complete");
			ParameterValues = new List<string>();
			ParameterValues.Add("6");
			ParameterValues.Add("General Assistance");
			ParameterValues.Add(DateTime.Now.ToString("HH:mm:ss tt"));
			ParameterValues.Add(DateTime.Now.Date.ToString());

			if (_connect.Insert("INSERT INTO NEWTimedRequests (UID, TypeOfRequest, DateToComplete, TimeToComplete) VALUES (@User_id, @Type_of_request, @Date_to_complete, @Time_to_complete);", Parameters, ParameterValues))
			{
				result = true;
			}

			result =  false;
			
		}
	}
}
