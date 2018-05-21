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
		public Form1 form1;
        private Alarm _alarm;
		private Order_Food _orderFood;
		private Shower _shower;
		public Mysql_Connect _connect;
		public Request_Emergency _emergencyRequest;
		public Visitor _visitor;
		public System.Windows.Forms.DialogResult confirm;
		public string _status;
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
		public void button4_Click(object sender, EventArgs e)
		{
			confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm logout", MessageBoxButtons.YesNo);

			if (confirm == DialogResult.Yes)
			{
				
				form1.UserNameProperty = "";
				form1.PasswordProperty = "";
				form1.UserIDProperty = "0";
				this.Hide();
				form1.Logout();
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
		

		public void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_emergencyRequest.CallRequest();
			_status = "Success";
		}
	}
}
