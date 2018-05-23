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
            // Add the incident
            Incidents.Add_Incident("5", theIncident);
            // It should only pass if the incident now exists in the database
            string[] columnsToCheck = { "UID", "IncidentDescription"};
            string[] columnValues = { "5", theIncident};

            Assert.IsTrue(_mysql.DataDoesExist("Incidents", columnsToCheck, columnValues));

            // Remove the test entry from the database
            _mysql.Delete_Entries("5", "Incidents", columnsToCheck, columnValues);
        }



        // Staff should be able to update an incident report for a specified resident
        // Reason being that the staff may have need to add something extra for record keeping
        [Test]
        public void Staff_should_update_incident_details()
        {
            // First add a sample incident to the database. 
            string theIncident = "Resident refused to take their medicine";

            // User ID is 5
            Incidents.Add_Incident("5", theIncident);

            // Change the description
            string updatedDesc = "Resident refused to take their medicine, SuperDrug. They became aggressive" +
                " when confronted by staff";

            // Update the entry
            Incidents.Update_Incident("5", theIncident, updatedDesc);
           
            string[] columnNames = { "UID", "IncidentDescription" };
            string[] columnExpectedValues = { "5", updatedDesc };

            // Test passes if the entry has changed
            Assert.IsTrue(_mysql.DataDoesExist("Incidents", columnNames, columnExpectedValues));

            // Delete once done
            _mysql.Delete_Entries("5", "Incidents", columnNames, columnExpectedValues);
        }



        // Staff should be able to see a list of the incidents for a specified resident
        // Create a few incident reports for the test user, and then test if the code
        // can find
        [Test]
        public void Staff_should_see_list_of_users_incidents()
        {
            // It should only pass if it finds the incident reports from the database
            Assert.IsTrue(Incidents.Get_Incidents_By_Name("resident"));
        }



        // Staff should be able to search for a resident by name. This test will test the functionality
        // of the GUI.
        [Test]
        public void Staff_should_search_resident_by_name()
        {
            // Add an incident before hand
            string theIncident = "Resident dropped item on their foot.";
            Incidents.Add_Incident("5", theIncident);

            // Test should only pass if the program returns the name of the resident the user was searching for
            Assert.IsTrue(Incidents.Get_Incidents_By_Name("resident"));

            // Delete the entry once done
            string[] columnNames = { "UID", "IncidentDescription" };
            string[] columnExpectedValues = { "5", theIncident };
            _mysql.Delete_Entries("5", "Incidents", columnNames, columnExpectedValues);
        }



        // Staff should be able to see all incidents for a given time period (day, week, month, etc)
        [Test]
        public void Staff_should_search_by_date()
        {
            // Test should only pass if the program returns the incidents for a given time period and not before or after
            Assert.IsTrue(Incidents.Get_Incidents_By_Date("2018-05-23"));
        }
    }
}
