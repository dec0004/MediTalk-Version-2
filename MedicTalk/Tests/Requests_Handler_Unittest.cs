using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedicTalk;

namespace MediTalk
{
    [TestFixture]
    class Requests_Handler_Unittest
    {
        public HomePage _home; // From for the resdient's homepage
        public Form1 _form1; // Login form
        public Mysql_Connect _mysql;
        public Order_Food _food; // Form for food orders
        Mysql_Connect mysql_handler = new Mysql_Connect(); // The class that handles mysql functions


        // Test if the resident can add a new request
        [Test]
        public void Resident_Can_Add_New_Request()
        {
            _form1 = new Form1();
            _mysql = new Mysql_Connect();
            _home = new HomePage(_form1, _mysql);
            _food = new Order_Food(_home, _mysql, _form1, null, "breakfast");

            // The type of meal (Lunch, breakfast, etc). For the purpose of this unit test
            // a new mealtype and mealname called 'test' was created.
            _food._mealType = "test";
            _food._HotOrCold = "hot";
            _food._chosenMealName = "test";

            _form1.Username_Textbox.Text = "resident";
            _form1.Password_Textbox.Text = "resident";
            _form1.UserNameProperty = "resident";
            _form1.PasswordProperty = "resident";

            // Simulate the user clicking on login, to ensure the Login_Click method works
            _form1.Login_Click(new object(), EventArgs.Empty);

            // Simulate the user clicking on submit, to ensure the Submit_Clicked method works
            _food.Submit_Clicked(new object(), new EventArgs());
            // Check to see if the order is now in the database.
            Assert.IsTrue(mysql_handler.DataExists(
                "NEWFoodRequests", "UID = '5' AND MealType = 'test' AND MealName = 'test';"));

            // Now delete the entry, so that this test can be re-tested again at a later time
            mysql_handler.Delete("DELETE FROM NEWFoodRequests WHERE UID = 5 AND MealType = 'test' AND MealName = 'test'");
        }
    }
}