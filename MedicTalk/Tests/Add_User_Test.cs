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
	class Add_User_Test
	{

		public Form1 _form1;
		public Mysql_Connect _mysql;
		public Add_New_User _newUser;
		public List_Of_Requests _list;
		public List<string> _paramaterKey;
		public List<string> _paramaterValue;
		public string rowCount;
		public string newRowCount;
		[Test]
		public void Test_New_User_Can_Be_Added()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_list = new List_Of_Requests(_form1, _mysql);
			_newUser = new Add_New_User(_list, _mysql, _form1);
			_paramaterKey = new List<string>();
			_paramaterValue = new List<string>();

			_newUser = new MedicTalk.Add_New_User(_list, _mysql, _form1);
			string UserName = "dec0004";
			string FirstName = "J";
			string LastName = "fdf";
			string Password = "cdsd";
			/*
			_newUser.User_Name_Text_Box.Text = "dec0004";
			_newUser.First_Name_Text_Box.Text = "J";
			_newUser.Last_Name_Text_Box.Text = "fdf";
			_newUser.Password_Text_Box.Text = "cdsd";
			_newUser.Room_Text_Box.Text = "4";
			_newUser.Section_Text_Box.Text = "D4";
			_newUser.Age_Text_Box.Text = "45";
			*/
			_paramaterKey.Add("UserName");
			_paramaterKey.Add("FirstName");
			_paramaterKey.Add("LastName");
			_paramaterKey.Add("Password");
			_paramaterValue.Add(UserName);
			_paramaterValue.Add(FirstName);
			_paramaterValue.Add(LastName);
			_paramaterValue.Add(Password);
			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);

			rowCount = _mysql.Count("SELECT COUNT(*) FROM NEWUsers");
			_mysql.Insert_Request("INSERT INTO NEWUsers ( UserName, FirstName, LastName, Password) " + "VALUES ('" + UserName + "','" + FirstName + "','" + LastName + "','" + Password + "');"); 
			newRowCount = _mysql.Count("SELECT COUNT(*) FROM NEWUsers");


			Assert.AreNotEqual(rowCount, newRowCount);

			rowCount = _mysql.Count("SELECT COUNT(*) FROM NEWResidents");
			_mysql.Insert_Request("INSERT INTO NEWResidents (UID, FirstName, LastName, Room, Section, Age) " + "VALUES (28, '" + FirstName + "','" + LastName + "','" + "43', 'D3', 43);");
			newRowCount = _mysql.Count("SELECT COUNT(*) FROM NEWResidents");
			Assert.AreNotEqual(rowCount, newRowCount);
		}
	}
}