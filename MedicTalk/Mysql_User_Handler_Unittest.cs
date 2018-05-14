using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedicTalk;

namespace MediTalk
{
    // This class is responsible for testing all the functionality required
    // to connect the user to the application and database.
    [TestFixture]
    class User_Handler_UnitTest
    {
        // Test that user can connect with correct credentials
        // Must return true for test to pass
        [Test]
        public void Should_Connect_If_User_Enters_NamePass()
        {
            Assert.IsTrue(Mysql_User_Handler.Login("admin", "admin"), "User should be able to log in, but can't");
        }


        // Test that the username is case insensitive
        [Test]
        public void Should_Not_Be_Case_Sensitive()
        {
            Assert.IsTrue(Mysql_User_Handler.Login("ADMIN", "admin"), "The program should not worry about case sensitivty of username");
        }


        // Test that user can't connect if they entered the wrong credentials
        [Test]
        public void Should_Return_False_If_Inccorect_Details()
        {
            Assert.IsFalse(Mysql_User_Handler.Login("admi", "adam"), "User should NOT be able to log in");
        }


        // Test if user can change password
        [Test]
        public void Should_Change_Password_If_Entered()
        {

        }


        // Test if a user who is categorised as a staff member has access to their specific features
        // In this case, test if the usertype property becomes "staff"
        [Test]
        public void Should_Give_More_Access_To_Staff()
        {
            Mysql_User_Handler.Login("admin", "admin");
            Assert.IsTrue(Mysql_User_Handler.UserType == "staff", "User is not identified as a staff member when they should be");
        }


        // Test if a user who is a resident has access to their specific features
        [Test]
        public void Should_Give_Residents_Access()
        {
            Mysql_User_Handler.Login("resident", "resident");
            Assert.IsTrue(Mysql_User_Handler.UserType == "resident", "User is not identified as a resident when they should be");
        }
    }
}



/*using System;
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
*/
