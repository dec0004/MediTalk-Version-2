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
	public partial class Add_New_User : Form
	{
		public Form1 form1;
		public Mysql_Connect mysql;
		public List_Of_Requests list;
		public Add_New_User(List_Of_Requests _list, Mysql_Connect _mysql, Form1 _form1)
		{
			form1 = _form1;
			mysql = _mysql;
			list = _list;

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void User_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void First_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Last_Name_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Password_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Room_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Section_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Age_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
