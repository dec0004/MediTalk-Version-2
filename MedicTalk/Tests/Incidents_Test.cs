using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedicTalk;
using System.Windows.Forms;

namespace MedicTalk
{
    // These are tests that test whether the Incidents history feature
    // works as intender. These tests will drive the design
    // of the code written for these features
    [TestFixture]
    class Incidents_Test
    {
        public Mysql_Connect _mysql = new Mysql_Connect();




        // Staff should be able to add an incident report for a specified resident
        [Test]
        public void Staff_should_add_incidents()
        {
            string theIncident = "Resident refused to take their medicine";
            // It should only pass if the incident now exists in the database
            Assert.IsTrue(_mysql.DataExists(
                "Incidents", "UID = '" + Mysql_User_Handler.User_ID + 
                "' AND IncidentDescription = '" + theIncident + "';"));

            // Remove the test entry from the database
            _mysql.Delete("DELETE FROM Incidents where UID = '" + 
                Mysql_User_Handler.User_ID + "' AND IncidentDescription = '" + theIncident + "';");
        }



        // Staff should be able to update an incident report for a specified resident
        // Reason being that the staff may have need to add something extra for record keeping
        [Test]
        public void Staff_should_update_incident_details()
        {
            // First add a sample incident to the database. 
            Mysql_User_Handler.User_ID = "5"; // ID of test user
            string theIncident = "Resident refused to take their medicine";
            Incidents.Add_Incident(theIncident);

            // Change the description
            string updatedDesc = "Resident refused to take their medicine, SuperDrug. They became aggressive" +
                "when confronted by staff";

            // Update the entry
            Incidents.Update_Incident(Mysql_User_Handler.User_ID, theIncident, updatedDesc);

            // Test passes if the entry has changed
            Assert.IsTrue(_mysql.DataExists(
                "Incidents", "UID = '" + Mysql_User_Handler.User_ID +
                "' AND IncidentDescription = '" + updatedDesc + "';"));

            _mysql.Delete("DELETE FROM Incidents where UID = '" +
                Mysql_User_Handler.User_ID + "' AND IncidentDescription = '" + updatedDesc + "';");
        }



        // Staff should be able to see a list of the incidents for a specified resident
        // Create a few incident reports for the test user, and then test if the code
        // can find
        [Test]
        public void Staff_should_see_list_of_users_incidents()
        {

            // It should only pass if it finds the incident reports from the database
            Assert.Fail();
        }



        // Staff should be able to search for a resident by name.
        [Test]
        public void Staff_should_search_resident_by_name()
        {
            // Test should only pass if the program returns the name of the resident the user was searching for
            Assert.Fail();
        }



        // Staff should be able to see all incidents for a given time period (day, week, month, etc)
        [Test]
        public void Staff_should_search_by_date()
        {
            // Test should only pass if the program returns the incidents for a given time period and not before or after
            Assert.Fail();
        }
    }
}
