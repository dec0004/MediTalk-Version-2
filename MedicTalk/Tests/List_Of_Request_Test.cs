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
	class List_Of_Request_Test
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public List_Of_Requests _list;
		bool isThere;


		[Test]
		public void Test_Food_Request_Can_Be_Completed()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_list = new MedicTalk.List_Of_Requests(_form1, _mysql);
			_list.Display_Lists();
			int numrows = _list.Add_New_User_Button.Rows.Count;
			_list.FoodRequest_Completed(new object(), new DataGridViewCellEventArgs(1,1));
			int newNumRows = _list.Add_New_User_Button.Rows.Count;
			Assert.AreNotEqual(numrows, newNumRows);
		}

		[Test]
		public void Test_Timed_Request_Can_Be_Completed()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_list = new MedicTalk.List_Of_Requests(_form1, _mysql);
			_list.Display_Lists();
			int numrows = _list.dataGridView1.Rows.Count;
			_list.dataGridView1_CellContentClick(new object(), new DataGridViewCellEventArgs(1, 1));
			int newNumRows = _list.dataGridView1.Rows.Count;
			Assert.AreNotEqual(numrows, newNumRows);
		}
	}
}