using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MedicTalk
{
    // Used to store incidents 
    public class RecordedIncident
    {
        public string User_id;
        public string First_name;
        public string Last_name;
        public string Incident_description;
        public string Incident_date;
        public string Incident_time;
    }

    /// <summary>
    /// This class handles everything to do with incidents.
    /// Functionality will include searching for residents, searching for
    /// incidents given a timeframe, searching for incidents given a resident's
    /// name, and the ability to add an incident.
    /// </summary>
    public static class Incidents
    {
        static private Mysql_Connect _mysql = new Mysql_Connect();

        // Used to store details of incidents.
        static public List<RecordedIncident> ListOfIncidents;



        /// <summary>
        /// Creates a new list for recorded incidents, and then
        /// adds each individual incident details to the incidents list
        /// </summary>
        /// <param name="mysql_Reader">The MySQLReader that's retrieved the data</param>
        public static void Populate_Incidents_List(MySqlDataReader mysql_Reader)
        {
            // Create a new list. Old lists will be overwritten as they will
            // no longer be useful
            ListOfIncidents = new List<RecordedIncident>();

            // Populate the list with as many entries that were returned
            while (mysql_Reader.Read())
            {
                RecordedIncident incident = new RecordedIncident();
                incident.User_id = mysql_Reader.GetString(0);
                incident.First_name = mysql_Reader.GetString(1);
                incident.Last_name = mysql_Reader.GetString(2);
                incident.Incident_date = mysql_Reader.GetString(3);
                incident.Incident_time = mysql_Reader.GetString(4);
                incident.Incident_description = mysql_Reader.GetString(5);

                ListOfIncidents.Add(incident);
            }
        }


        /// <summary>
        /// Add an incident to the database
        /// </summary>
        /// <param name="IncidentDesc">String describing the incident that occured</param>
        public static void Add_Incident(string uid, string IncidentDesc)
        {
            MySqlCommand _command = new MySqlCommand();

            if (_mysql.OpenConnection())
            {
                _mysql.Change_Timezone(_command); // Change time zone to match Melb

                //Add parameters and execute the command to MySQL database
                _command.CommandText = "" +
                    "INSERT INTO Incidents (UID, DateOfIncident, TimeOfIncident, IncidentDescription) " +
                    "VALUES (@UID, CURDATE(), CURTIME(), @IncidentDescription);";
                _command.Parameters.AddWithValue("@UID", uid);
                _command.Parameters.AddWithValue("IncidentDescription", IncidentDesc);

                _command.ExecuteNonQuery(); // Execute the command
            }
            _mysql.CloseConnection();
        }



        /// <summary>
        /// Find all incidents given for 1 day
        /// </summary>
        public static bool Get_Incidents_By_Date(string date)
        {
            bool exists = false;
            MySqlCommand _command = new MySqlCommand();

            if (_mysql.OpenConnection())
            {
                //Add parameters and execute the command to MySQL database
                _command.CommandText =
                    "SELECT U.UID, U.FirstName, U.LastName, I.DateOfIncident, I.TimeOfIncident, I.IncidentDescription " +
                    "FROM NEWUsers U " +
                    "INNER JOIN Incidents I ON U.UID = I.UID " +
                    "WHERE I.DateOfIncident = @date;";
                _command.Parameters.AddWithValue("@date", date);
                _command.Connection = _mysql.connection;

                // Get data from database
                MySqlDataReader mysql_Reader = _command.ExecuteReader();

                if (mysql_Reader.HasRows)
                {
                    Populate_Incidents_List(mysql_Reader);
                    exists = true;
                }
            }

            _mysql.CloseConnection();
            return exists;
        }

        /// <summary>
        /// Find all incidents given between start and end dates
        /// </summary>
        public static bool Get_Incidents_By_Dates(string startdate, string enddate)
        {
            bool exists = false;
            MySqlCommand _command = new MySqlCommand();

            if (_mysql.OpenConnection())
            {
                //Add parameters and execute the command to MySQL database
                _command.CommandText =
                    "SELECT U.UID, U.FirstName, U.LastName, I.DateOfIncident, I.TimeOfIncident, I.IncidentDescription " +
                    "FROM NEWUsers U " +
                    "INNER JOIN Incidents I ON U.UID = I.UID " +
                    "WHERE I.DateOfIncident >= @startdate AND I.DateOfIncident <= @enddate;";
                _command.Parameters.AddWithValue("@startdate", startdate);
                _command.Parameters.AddWithValue("@enddate", enddate);
                _command.Connection = _mysql.connection;



                // Get data from database
                MySqlDataReader mysql_Reader = _command.ExecuteReader();

                if (mysql_Reader.HasRows)
                {
                    Populate_Incidents_List(mysql_Reader);
                    exists = true;
                }
            }

            _mysql.CloseConnection();
            return exists;
        }


        /// <summary>
        /// Method that searches for a specific resident
        /// </summary>
        public static void Search_Name(string name)
        {

        }

        /// <summary>
        /// Searches the database for all the incidents to do
        /// with a specific resident
        /// </summary>
        /// <param name="usersName">Username of user who's histories being searched</param>
        /// <returns></returns>
        public static bool Get_Incidents_By_Name(string usersName)
        {
            bool exists = false;
            MySqlCommand _command = new MySqlCommand();

            if (_mysql.OpenConnection())
            {
                //Add parameters and execute the command to MySQL database
                _command.CommandText =
                    "SELECT U.UID, U.FirstName, U.LastName, I.DateOfIncident, I.TimeOfIncident, I.IncidentDescription " +
                    "FROM NEWUsers U " +
                    "INNER JOIN Incidents I ON U.UID = I.UID " +
                    "WHERE U.UserName = @username;";
                _command.Parameters.AddWithValue("@username", usersName);
                _command.Connection = _mysql.connection;
                
                // Get data from database
                MySqlDataReader mysql_Reader = _command.ExecuteReader();

                if (mysql_Reader.HasRows)
                {
                    Populate_Incidents_List(mysql_Reader);
                    exists = true;
                }    
            }

            _mysql.CloseConnection();
            return exists;
        }


        /// <summary>
        /// Updates the incident's details.
        /// </summary>
        /// instigatorID is the ID of the person who caused the incident.
        public static void Update_Incident(string instigatorID, string oldIncidentDesc, string updatedIncidentDesc)
        {
            _mysql.Update_Replace_Value(instigatorID,"Incidents", "IncidentDescription", oldIncidentDesc, updatedIncidentDesc);
        }
    }
}
