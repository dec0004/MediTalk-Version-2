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
	public partial class Visitor_Signin : Form
	{
		public List_Of_Requests list;
		public Mysql_Connect mysql;
		public Form1 form1;
		public Visitor_Signin(List_Of_Requests _list, Mysql_Connect _mysql, Form1 _form1)
		{
			InitializeComponent();
			list = _list;
			mysql = _mysql;
			form1 = _form1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			list.Show();
			
		}

		private void Add_New_User_Button_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Person_Visiting_Textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void Last_Name_Textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void First_Name_Textbox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
