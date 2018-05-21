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
	class Order_Food_Test
	{
		public HomePage _home;
		public Form1 _form1;
		public Mysql_Connect _mysql;
		public string count;
		public string newCount;
		public Order_Food _food;
		public Request_Emergency _requestEmergency;


		//Test that user can see options for breakfast change

		[Test]
		public void Test_breakfast_Shows()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_requestEmergency = new MedicTalk.Request_Emergency(_mysql, _form1);
			_food = new Order_Food(_home, _mysql, _form1, _requestEmergency, "breakfast");
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			//Check cold
			_food.ColdCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[1], "Oatmeal");

			//Check Warm
			_food.WarmCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[1], "Oatmeal");
			
			//Check Hot
			_food.HotCheckBoxChecked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[1], "English breakfast");
			

		}

		//Test that user can see options for lunch change

		[Test]
		public void Test_lunch_Shows()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_requestEmergency = new MedicTalk.Request_Emergency(_mysql, _form1);
			_food = new Order_Food(_home, _mysql, _form1, _requestEmergency, "lunch");
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			//Check cold
			_food.ColdCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Egg salad sandwich");
			
			//Check Warm
			_food.WarmCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Egg salad sandwich");

			//Check Hot
			_food.HotCheckBoxChecked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Lasagna");

	
		}

		[Test]
		public void Test_Dinner_Shows()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_requestEmergency = new MedicTalk.Request_Emergency(_mysql, _form1);
			_food = new Order_Food(_home, _mysql, _form1, _requestEmergency, "dinner");
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			//Check cold
			_food.ColdCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Turkey sandwhich");

			//Check Warm
			_food.WarmCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Turkey sandwhich");

			//Check Hot
			_food.HotCheckBoxChecked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Pizza");


		}

		[Test]
		public void Test_Drink_Shows()
		{
			_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_requestEmergency = new MedicTalk.Request_Emergency(_mysql, _form1);
			_food = new Order_Food(_home, _mysql, _form1, _requestEmergency, "drink");
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";

			//Check cold
			_food.ColdCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Milk");

			//Check Warm
			_food.WarmCheckbox_Checked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Milk");

			//Check Hot
			_food.HotCheckBoxChecked(new object(), EventArgs.Empty);
			_food.Update_ComboxBox();
			Assert.AreEqual(_food.MealSelection.Items[0], "Coffee");


		}

		[Test]
		public void Test_Option_Can_Be_Chosen()
		{
		_form1 = new Form1();
			_mysql = new Mysql_Connect();
			_home = new HomePage(_form1, _mysql);
			_requestEmergency = new MedicTalk.Request_Emergency(_mysql, _form1);
			_food = new Order_Food(_home, _mysql, _form1, _requestEmergency, "breakfast");
			_home.form1.UserIDProperty = "0";
			_home.form1.PasswordProperty = "43r4";
			_home.form1.UserNameProperty = "edcfdf";
			_food._mealType = "breakfast"; // The type of meal (Lunch, breakfast, etc)
			_food._HotOrCold = "hot";
			_food._chosenMealName = "English breakfast";
			_form1.Username_Textbox.Text = "resident";
			_form1.Password_Textbox.Text = "resident";
			_form1.UserNameProperty = "resident";
			_form1.PasswordProperty = "resident";
			_form1.Login_Click(new object(), EventArgs.Empty);
			//Check cold
			_food.Submit_Clicked(new object(), EventArgs.Empty);
			Assert.AreEqual(_food.chosenResult, DialogResult.None);


		}
	}
}