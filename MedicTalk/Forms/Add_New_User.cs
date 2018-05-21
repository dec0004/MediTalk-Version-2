using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace MedicTalk
{
	public partial class Add_New_User : Form
	{
		public Form1 form1;
		public Mysql_Connect mysql;
		public List_Of_Requests list;
		public string UserName;
		public string FirstName;
		public string LastName;
		public string Password;
		public string Room;
		public string Section;
		public string Age;
		public string Id;
		public List<string> Keywords;
		public List<string> ParameterKey;
		public List<string> ParameterValue;
		private string[] Query_Results;
		public string UserId;

		public Add_New_User(List_Of_Requests _list, Mysql_Connect _mysql, Form1 _form1)
		{
			form1 = _form1;
			mysql = _mysql;
			list = _list;
			InitializeComponent();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Keywords = new List<string>();
			ParameterValue = new List<string>();
			ParameterKey = new List<string>();
			Keywords.Add("UID");
			ParameterKey.Add("FirstName");
			ParameterValue.Add(FirstName);
		
			mysql.Insert_Request("INSERT INTO NEWUsers (UID, UserName, FirstName, LastName, Password) " + "VALUES (default ,'" + UserName + "','" + FirstName + "','" + LastName + "','" + Password + "');");
			Id = mysql.Select("SELECT UID FROM NEWUsers WHERE FirstName = @FirstName", "1", Keywords, ParameterKey, ParameterValue);
			Query_Results = Id.Split('/');
			UserId = Query_Results[0];
			Debug.WriteLine(UserId);
			mysql.Insert_Request("INSERT INTO NEWResidents (UID, FirstName, LastName, Room, Section, Age) " + "VALUES ('" +UserId +"','" + FirstName + "','" + LastName + "','" + "43', 'D3', 43);");
		
	}

			
		private void User_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{
			UserName = User_Name_Text_Box.Text;
		}

		private void First_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{
			FirstName = First_Name_Text_Box.Text;
		}

		private void Last_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{
			LastName = Last_Name_Text_Box.Text;
		}

		private void Password_Text_Box_TextChanged(object sender, EventArgs e)
		{
			Password = Password_Text_Box.Text;
		}

		private void Room_Text_Box_TextChanged(object sender, EventArgs e)
		{
			Room = Room_Text_Box.Text;
		}

		private void Section_Text_Box_TextChanged(object sender, EventArgs e)
		{
			Section = Section_Text_Box.Text;
		}

		private void Age_Text_Box_TextChanged(object sender, EventArgs e)
		{
			Age = Age_Text_Box.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			list.Show();
		}
	}
}
