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
	class Visitor_Signin_Test
	{

		public Form1 _form1;
		public Mysql_Connect _mysql;
		public Visitor_Signin _visitor;
		public List_Of_Requests _list;
		public List<string> _paramaterKey;
		public List<string> _paramaterValue;
		public string rowCount;
		public string newRowCount;
		[Test]
		public void Test_New_Visitor_Can_Be_Added()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_list = new List_Of_Requests(_form1, _mysql);
			_visitor = new Visitor_Signin(_list, _mysql, _form1);

			
			string FirstName = "dec0004";
			string LastName = "J";
			string PersonVisiting = "fdf";


			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);

			rowCount = _mysql.Count("SELECT * FROM NEWVisitorIn");
			_mysql.Insert_Request("INSERT INTO NEWVisitorIn (First_Name, Last_Name, Person_Visiting, Time_In) " + "VALUES ('"  + FirstName + "','" + LastName + "','" + PersonVisiting + "','" + DateTime.Now.TimeOfDay + "');");
			newRowCount = _mysql.Count("SELECT * FROM NEWVisitorIn");

			Assert.AreNotEqual(rowCount, newRowCount);

		
		}

		[Test]
		public void Test_Visitors_Show()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_list = new List_Of_Requests(_form1, _mysql);
			_visitor = new Visitor_Signin(_list, _mysql, _form1);


			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);


			bool exists = _mysql.DataExists("NEWVisitorIn", "First_Name = 'dec0004'");


			Assert.IsTrue(exists);


		}
	}
}