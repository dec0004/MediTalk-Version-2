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
	class Visitor_Test
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public Shower _shower;
		public Visitor _visitor;


		[Test]
		public void Test_If_User_Can_Register_Shower()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_visitor = new MedicTalk.Visitor(_home, _mysql, _form1);

			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);
			//Check cold
			_visitor.textBox1.Text = "Jordan";
			_visitor.textBox2.Text = "de carheil";
			_visitor.comboBox1.Text = "5";
			_visitor.comboBox2.Text = "43";
			_visitor.button2_Click(new object(), EventArgs.Empty);
			
			Assert.AreEqual(_visitor._result, DialogResult.OK);



		}
	}
}