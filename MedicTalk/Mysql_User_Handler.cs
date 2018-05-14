using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace MedicTalk
{
    // This class controls how the user interacts with the program.
    // Its a static class since no instances of it will be needed.
    static class Mysql_User_Handler
    {

        private static string _userType; // Will store what kind of user is logged in (Resident, staff, etc)
        private static string _user_ID; // Stores user ID

        static Mysql_Connect _MySQL = new Mysql_Connect();

        // Keeps track of the kind of user (Resident, staff, etc) that's logged in
        public static string UserType
        {
            get
			{
				return _userType;
			}
        }
        public static string User_ID
        {
            get
			{
				return _user_ID;
			}
        }


        // <summary>
        // Checks if user exists in the database and the password is correct
        // </summary>
        // <return>True if user exists</return>
        public static bool User_Exists(string user, string pass)
        {
            string _inputCommand = "SELECT * FROM NEWUsers WHERE UserName = '" + user + "' and Password = '" + pass + "'";
            Console.WriteLine(_inputCommand);
            MySqlCommand _command = new MySqlCommand();

            if (_MySQL.OpenConnection() == true)
            {
                _command.CommandText = _inputCommand;
                _command.Parameters.AddWithValue("@user", user);
                _command.Parameters.AddWithValue("@password", pass);
                _command.Connection = _MySQL.connection;
                MySqlDataReader login = _command.ExecuteReader();

                if (login.Read())
                {
                    login.Close();
                    _MySQL.CloseConnection();
                    return true;
                }
                else
                {
                    login.Close();
                    _MySQL.CloseConnection();
                    return false;
                }
            }
            return false;
        }


        // <summary>
        // Logs user in and shows sets the user type depending
        // on whether they're staff, residents, etc.
        // Return true if user can log in, or else return false so the
        // program can inform the user.
        // </summary>
        public static bool Login(string username, string password)
        {
            if (User_Exists(username, password))
            {
                // Get the id from the list
                List<string> userDetails = new List<string>(_MySQL.Select("NEWUsers", "UID", "UserName = '" + username + "'", 1));
                string[] seperatedDetails = userDetails[0].Split('/');
                string userID = seperatedDetails[0];
                _user_ID = seperatedDetails[0];

                // Check whether user is a staff member or resident
                if (_MySQL.DataExists("NEWStaff", "UID = '" + userID + "'"))
                {
                    _userType = "staff";
                }
                else if (_MySQL.DataExists("NEWResidents", "UID = '" + userID + "'"))
                {
                    _userType = "resident";
                }

                //TODO: Add visitor
                
                return true;
            }
            return false;
        }
    }
}
