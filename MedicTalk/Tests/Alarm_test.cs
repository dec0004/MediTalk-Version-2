﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedicTalk;
using System.Windows.Forms;

namespace MediTalk
{

	[TestFixture]
	class Alarm_test
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public Alarm _alarm;
		bool isThere;


		[Test]
		public void Test_Previous_Alarms_Show()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_alarm = new MedicTalk.Alarm(_home, _mysql, _form1);

			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);

			_alarm.Display_Alarms();

			foreach (DataGridViewRow row in _alarm.AlarmsList.Rows)
			{

				if (row.Cells[0].Value.ToString() == "05:32:00")
				{
					isThere = true;
				}

			}
			Assert.AreEqual(isThere, true);
		
		}

		[Test]
		public void Test_Alarm_Can_Be_Added()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_alarm = new MedicTalk.Alarm(_home, _mysql, _form1);

			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);
			//Check cold
			_alarm.Hour = "5";
			_alarm.Minute = "32";
			_alarm.Minute_Box.Text = "32";
			_alarm.Hour_Box.Text = "5";
			_alarm.Display_Alarms();
			
			for (int i = 0; i < _alarm.AlarmsList.RowCount; i++)
			{
				
				if (_alarm.AlarmsList.Rows[i].Cells[1].Value.ToString() == "05:32:00")
				{
					Console.WriteLine(_alarm.AlarmsList.Rows[i].Cells[1].Value.ToString());
					isThere = true;
					Console.WriteLine("csc");
				}
			}
			_alarm.Submit_Button_Click(new object(), EventArgs.Empty);
			Assert.AreEqual(isThere, true);

		}
	}
}