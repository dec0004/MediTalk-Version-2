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
	class Shower_test
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public Shower _shower;



		[Test]
		public void Test_Shower_Option_Can_Be_Chosen()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_shower = new MedicTalk.Shower(_home, _mysql, _form1);

			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);
			//Check cold
			_shower._minute = "32";
			_shower._hour = "10";
			_shower.Shower_Button_Changed(new object(), EventArgs.Empty);
			_shower.Submit_Button_Click(new object(), EventArgs.Empty);

			Assert.AreEqual(_shower.result, DialogResult.OK);

			

		}
	}
}