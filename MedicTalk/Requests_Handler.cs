using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
namespace MedicTalk
{
    // This class will provide the functionality needed to view, and mark
    // requests as complete
    public static class Requests_Handler
    {

        static Mysql_Connect _MySQL = new Mysql_Connect();
        private static DataTable dataTable1;
		private static DataTable dataTable2;
		public static DataGridViewButtonColumn btn;
		public static DataTable DataTable1
		{
			get
			{
				return dataTable1;
			}
			set
			{
				dataTable1 = value;
			}
		}

		public static DataTable DataTable2
		{
			get
			{
				return dataTable2;
			}
			set
			{
				dataTable2 = value;
			}
		}

		/// <summary>
		/// Add an alarm or shower at a requested date and time
		/// </summary>
		public static void Add_Timed_Request(string type, string dateToComplete, string timeToComplete)
        {
            _MySQL.Insert_Request("INSERT");
        }
        
        /// <summary>
        /// Add an alarm or shower at a requested time
        /// </summary>
        public static void Add_Timed_Request(string type, string timeToComplete)
        {
            // Insert the time
            _MySQL.Insert_Request(
                "INSERT NEWTimedRequests (UID, TypeOfRequest, TimeToComplete) " +
                "VALUES ('" + Mysql_User_Handler.User_ID + "', '" + type + "', '" + timeToComplete + "');");
        }



        /// <summary>
        /// Add food request made by the resident into the database
        /// </summary>
        public static void Add_Food(string foodName, string HotOrCold, string MealType)
        {
            // Insert the request into the table
            _MySQL.Insert_Request(
                "INSERT INTO NEWFoodRequests (UID, MealType, HotOrCold, MealName, TimeOfRequest, DateOfRequest) " +
                "Values (" + Mysql_User_Handler.User_ID + ", '" + MealType + "', '" + HotOrCold + "', '" + foodName + 
                "', NOW(), CURDATE());");
        }


        /// <summary>
        /// Mark a request as complete so it no longer shows
        /// </summary>
        /// <param name="residentUID">Resident's user ID - needed to find the row in mysql</param>
        /// <param name="DateOfRequest">Date of request - needed to find the row in mysql</param>
        /// <param name="TimeOfRequest">Time of request - needed to find the row in mysql</param>
        public static bool Complete_Request(string timeOfRequest, string table)
        {
			Debug.WriteLine(table);
			string _timeofrequest = timeOfRequest;
			// Try marking request as complete and return true if it works
			if (table == "NEWFoodRequest")
			{
				Debug.WriteLine("cdavcadcvadvad");
					// TODO: Don't use Delete_Request function in this case
					_MySQL.Delete_Request(
						"UPDATE NEWFoodRequests SET Completed = 'y' WHERE TimeOfRequest = @Time;", _timeofrequest);
					return true;

				
			}
			
			else if (table == "NEWTimedRequest")
			{
					Debug.WriteLine("cdsc");
					// TODO: Don't use Delete_Request function in this case
					_MySQL.Delete_Request(
						"UPDATE NEWTimedRequests SET Completed = 'y' WHERE TimeToComplete = @Time;", _timeofrequest);
					return true;
			
			}
			return false;
			
        }


        /// <summary>
        /// Show all food requests that aren't completed
        /// </summary>
        public static void Show_Requests()
        {          
            if (_MySQL.OpenConnection())
            {
                MySqlDataAdapter mySqlDataAdapter_Food = new MySqlDataAdapter(
                    // "SELECT U.UID, U.FirstName, U.LastName, Res.Room, Res.Section, Req.MealType, Req.HotOrCold, Req.MealName, Req.DateOfRequest, Req.TimeOfRequest, Req.Completed FROM NEWUsers U " +

                    "SELECT U.FirstName, U.LastName, Res.Room, Res.Section, Req.MealType, Req.HotOrCold, Req.MealName, Req.Completed, Req.DateOfRequest, Req.TimeOfRequest, U.UID FROM NEWUsers U " +
                    "INNER JOIN NEWResidents Res ON U.UID = Res.UID " +
                    "INNER JOIN NEWFoodRequests Req ON Res.UID = Req.UID " +
                    "WHERE Completed != 'y' OR Completed IS NULL;" // Only show uncompleted requests
                    , _MySQL.connection);
                DataTable1 = new DataTable();
                mySqlDataAdapter_Food.Fill(DataTable1);
				
				_MySQL.CloseConnection();
            }
            else
            {
                Console.WriteLine("Could not open connection");
            }
        }


        /// <summary>
        /// Show requests that must be done at a specific time
        /// </summary>
        public static void Show_Timed_Requests()
        {            
            if (_MySQL.OpenConnection())
            {
                // Get all requests for alarms and showers
                // Filter out requests that have already passed 
                // (ie; don't show a request for an alarm at 9:00 if it's already 10:00)
                MySqlDataAdapter mySqlDataAdapter_Timed = new MySqlDataAdapter(
                    "SELECT U.FirstName, U.LastName, Res.Room, Res.Section, Req.TypeOfRequest, Req.TimeToComplete " +
                    "FROM NEWUsers U " +
                    "INNER JOIN NEWResidents Res ON U.UID = Res.UID " +
                    "INNER JOIN NEWTimedRequests Req ON Res.UID = Req.UID " +
					"WHERE Completed != 'y' OR Completed IS NULL;"
					, _MySQL.connection);
                DataTable2 = new DataTable();
				

				mySqlDataAdapter_Timed.Fill(DataTable2);

                _MySQL.CloseConnection();
            }
            else
            {
                Console.WriteLine("Could not open connection");
            }
        }



        /// <summary>
        /// Used to display all alarms
        /// </summary>
        public static void Show_Alarms()
        {
            if (_MySQL.OpenConnection())
            {
                // Search for all alarms a specific user has made
                MySqlDataAdapter mySqlDataAdapter_Alarm = new MySqlDataAdapter(
                    "SELECT TimeToComplete FROM NEWTimedRequests " +
                    "WHERE TypeOfRequest = 'alarm' " +
                    "AND UID = '" + Mysql_User_Handler.User_ID + "';", _MySQL.connection);

                DataTable1 = new DataTable();
                mySqlDataAdapter_Alarm.Fill(DataTable1);

                _MySQL.CloseConnection();
            }
        }
        
        /// <summary>
        /// Deletes a given alarm. Notifies the caller if it was able
        /// to delete the alarm.
        /// </summary>
        public static bool Delete_Alarm(string time)
        {
            // Try deleting the alarm and return true if it works
            try
            {
                _MySQL.Delete_Request( "DELETE FROM NEWTimedRequests " +
                    "WHERE UID = '" + Mysql_User_Handler.User_ID + "' " +
                    " AND TimeToComplete = '" + time + "';", " ");
                   
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
