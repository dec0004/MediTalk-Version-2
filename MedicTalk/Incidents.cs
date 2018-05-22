using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicTalk
{
    /// <summary>
    /// This class handles everything to do with incidents.
    /// Functionality will include searching for residents, searching for
    /// incidents given a timeframe, searching for incidents given a resident's
    /// name, and the ability to add an incident.
    /// </summary>
    public static class Incidents
    {
        static private Mysql_Connect _mysql = new Mysql_Connect();

        /// <summary>
        /// Add an incident for a given resident
        /// </summary>
        public static void Add_Incident(string incidentDesc)
        {
            // Insert the incident
            _mysql.Insert_Request(
                "INSERT INTO Incidents (UID, DateOfIncident, TimeOfIncident, IncidentDescription) " +
                "VALUES ('" + Mysql_User_Handler.User_ID + "', CURDATE(), CURTIME(), '" + 
                incidentDesc + "');");
        }

        public static void Add_Incident_Params(string incidentDesc)
        {

        }

        /// <summary>
        /// Find all incidents given the date values
        /// </summary>
        public static void Get_Incidents_By_Date()
        {

        }


        /// <summary>
        /// Method that searches for a specific resident
        /// </summary>
        public static void Search_Name()
        {

        }

        /// <summary>
        /// Searches the database for all the incidents to do
        /// with a specific resident
        /// </summary>
        public static void Get_Incidents_By_Name()
        {

        }

        /// <summary>
        /// Updates the incident's details.
        /// </summary>
        /// instigatorID is the ID of the person who caused the incident.
        public static void Update_Incident(string instigatorID, string oldIncidentDesc, string updatedIncidentDesc)
        {
            // Update the entry by finding the old incident description and updating it
            _mysql.Update("Incidents", "SET IncidentDescription = '" + updatedIncidentDesc + 
                "' WHERE UID = '" + instigatorID + "' AND IncidentDescription = '" + oldIncidentDesc + "';");
        }
    }
}
