using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MedicTalk
{
	[TestFixture]
	class MediTalk_test
	{
		Mysql_Connect _conn = new Mysql_Connect();
		private string User_Name = "admin";
		private string Password = "admin";
		private string User_Name_wrong = "dadmin";
		private string Password_wrong = "addmin";
		private string _expectedRows;
		private bool valid;
		
		List<string> Keywords;
		List<string> Parameters;
		List<string> ParameterValues;

		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		[Test]
		public void test_mysql_conn()
		{
			valid = _conn.OpenConnection();
			Assert.AreEqual(valid, true);
		}

		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		[Test]
		public void test_mysql_conn_close()
		{

			valid = _conn.CloseConnection();
			Assert.AreEqual(valid, true);
		}

		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		[Test]
		public void test_login_function_correct_details()
		{
			
			valid = _conn.Login("SELECT * FROM Accounts WHERE User_Name = @user and Password=@Password", User_Name, Password);
			
			Assert.AreEqual(valid, true);
		}
		
		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		[Test]
		public void test_login_function_incorrect_details()
		{

			valid = _conn.Login("SELECT * FROM Accounts WHERE User_Name = @user and Password=@Password", User_Name_wrong, Password_wrong);

			Assert.AreNotEqual(valid, true);
		}

		
		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		
		[Test]
		public void test_count_method()
		{
			Keywords = new List<string>();
			Keywords.Add("Breakfast_cold_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			_expectedRows = _conn.Count("SELECT COUNT(*) FROM Breakfast_cold");
			Assert.AreEqual(_expectedRows, "4");
			//string _returnedQuery = _connect.Select("SELECT Breakfast_cold_item FROM Breakfast_cold", expectedRows, Keywords, Parameters, ParameterValues);
		}

		/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		[Test]
		public void test_select_method_with_multiple_rows_returned()
		{
			string _returnedQuery = _conn.Select("SELECT Breakfast_cold_item FROM Breakfast_cold", "4", Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			Query_Results = _returnedQuery.Split('/');
			string[] Expected = new string[4];
			Expected[0] = "KTime Cereal";
			Expected[1] = "Corn Flakes Cereal";
			Expected[2] = "Froot loops";
			Expected[3] = "Tuna Sandwhich";
			
			Assert.AreEqual(Query_Results, Expected);
			
		}
	}
}
