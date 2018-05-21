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
	class HomePageTest
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public string count;
		public string newCount;
		//Test that user logs out and all details reset

		[Test]
		public void Test_User_Log_Out()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1,_mysql);
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			_home.button4_Click(new object(), EventArgs.Empty);
			_home.confirm = DialogResult.Yes;

			Assert.AreEqual(_home.form1.UserNameProperty, "");
			Assert.AreEqual(_home.form1.PasswordProperty, "");
			Assert.AreEqual(_home.form1.UserIDProperty, "0");
		}

		[Test]
		public void Test_Username_And_Password_Text_Boxes_Erase_After_Logout()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			_home.button4_Click(new object(), EventArgs.Empty);
			_home.confirm = DialogResult.Yes;
			Assert.AreEqual(_home.form1.Username_Textbox.Text, "");
			Assert.AreEqual(_home.form1.Password_Textbox.Text, "");
		}
		
		[Test]
		public void Test_Emergency_Request_Works()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);


			_home = new HomePage(_form1, _mysql);
			_home.button3_Click(new object(), EventArgs.Empty);

			Assert.AreNotEqual(_home._status, "success");
		}
		

		[Test]
		public void Test_General_Assistance()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			
			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);

			_home.button3_Click(new object(), EventArgs.Empty);

		}
	}
}