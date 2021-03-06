﻿using System;
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
	public partial class Visitor_Signin : Form
	{
		public List_Of_Requests list;
		public Mysql_Connect mysql;
		public Form1 form1;
		public string rowToDel;
		public string _FirstName;
		public string _LastName;
		public string _PersonVisiting;
		public Visitor_Signin(List_Of_Requests _list, Mysql_Connect _mysql, Form1 _form1)
		{
			InitializeComponent();
			list = _list;
			mysql = _mysql;
			form1 = _form1;

			Requests_Handler.Show_Visitors();
			Add_New_User_Button.DataSource = Requests_Handler.DataTable1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			list.Show();
			
		}

		private void Add_New_User_Button_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			rowToDel = Add_New_User_Button.Rows[e.RowIndex].Cells[4].Value.ToString();
			Debug.WriteLine(rowToDel);
			Requests_Handler.Complete_Request(rowToDel, "NEWVisitorSignIn");
			Requests_Handler.Show_Visitors();
			Add_New_User_Button.DataSource = Requests_Handler.DataTable1;
			MessageBox.Show("Thanks for visiting!");
		}


		private void Person_Visiting_Textbox_TextChanged(object sender, EventArgs e)
		{
			_PersonVisiting = Person_Visiting_Textbox.Text;
		}

		private void Last_Name_Textbox_TextChanged(object sender, EventArgs e)
		{
			_LastName = Last_Name_Textbox.Text;
		}

		private void First_Name_Textbox_TextChanged(object sender, EventArgs e)
		{
			_FirstName = First_Name_Textbox.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Requests_Handler.Add_Visitor(_FirstName, _LastName, _PersonVisiting, DateTime.Now.ToString("hh:mm:ss tt"));
			Requests_Handler.Show_Visitors();
			Add_New_User_Button.DataSource = Requests_Handler.DataTable1;
		}
	}
}
