using System;
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

        // Functionality that's needed for all tests.
        // It logs in as a user and presents the GUI
        public void Do_Pretesting_Login()
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
        }



        // Test that the resident can see what alarms they've created
		[Test]
		public void Test_Previous_Alarms_Show()
		{
            Do_Pretesting_Login(); // Log in

			foreach (DataGridViewRow row in _alarm.AlarmsList.Rows)
			{
                Console.WriteLine("The value is: " + row.Cells[0].Value);
                if (row.Cells[0].Value.ToString() == "05:32:00")
                //if (row.Cells[0] != null)
                {
				    isThere = true;
				}
			}
			Assert.AreEqual(isThere, true);
		
		}


        // Test that user can add alarms
		[Test]
		public void Test_Alarm_Can_Be_Added()
		{
            Do_Pretesting_Login();
			
            // Simulate user entering these values
			_alarm.Minute_Box.Text = "32";
			_alarm.Hour_Box.Text = "5";


            // Simulate the user clicking on submit to ensure that method works
            _alarm.Submit_Button_Click(new object(), EventArgs.Empty);

            // Search if the new data now exists in the database
            Assert.IsTrue(_mysql.DataExists("NEWTimedRequests", "UID = '5' AND TimeToComplete = '05:32:00';"));

            // Remove the alarm afterwards, so this test can be tested again
            _mysql.Delete("DELETE FROM NEWTimedRequests WHERE UID = 5 AND TimeToComplete = '05:32:00';");
        }
	}
}