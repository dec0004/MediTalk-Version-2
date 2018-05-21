using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MedicTalk
{
	
	public partial class Order_Food : Form
	{
		public HomePage homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		Request_Emergency _request_emerg;
		public System.Windows.Forms.DialogResult chosenResult;
		public string _mealType = "breakfast"; // The type of meal (Lunch, breakfast, etc)
        public string _HotOrCold;
        public string _chosenMealName;



        public Order_Food(HomePage _homePage, Mysql_Connect connect, Form1 _form1, Request_Emergency request_emerg, string mealType)
		{
			InitializeComponent();
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			_request_emerg = request_emerg;
			button1.BackgroundImageLayout = ImageLayout.Stretch;

			// Set meal type depending on what button the user clicked on the home page
			_mealType = mealType;

            // Change the text of the header so that it matches what meal the 
            // user wants (Breakfast, lunch, dinner, etc)
            MealType_Header.Text = mealType;

            // Start off with one checkbox checked so that some meals are already shown
            ColdCheckbox.Checked = true;
            Update_ComboxBox();
        }
        

     

        // Back button
		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}


        // Record what meal the resident has chosen
        private void MealSelectionBox_Changed(object sender, EventArgs e)
        {
            _chosenMealName = MealSelection.SelectedItem as string;
        }


        // What to do when cold checkbox is checked
        public void ColdCheckbox_Checked(object sender, EventArgs e)
        {
            _HotOrCold = "cold";
            HotCheckbox.Checked = false;
            WarmCheckbox.Checked = false;

            Update_ComboxBox();
        }


        // What to do when hot checkbox is checked
        public void HotCheckBoxChecked(object sender, EventArgs e)
        {
            _HotOrCold = "hot";
            ColdCheckbox.Checked = false;
            WarmCheckbox.Checked = false;

            Update_ComboxBox();
        }


        // What to do when hot checkbox is checked
		public void WarmCheckbox_Checked(object sender, EventArgs e)
        {
            _HotOrCold = "warm";
            ColdCheckbox.Checked = false;
            HotCheckbox.Checked = false;

            Update_ComboxBox();
        }



        // Update the combobox so that the correct food types are shown
        public void Update_ComboxBox()
        {
            this.MealSelection.Items.Clear();

            string query = "MealType = '" + _mealType + "' AND HotOrCold = '" + _HotOrCold + "';";

            List<string> _foods = new List<string>(_connect.Select(
                "NEWFood", "FoodName", query, 1));

            string[] listOfFoods = _foods.ToArray(); // Convert the list to an array so the combobox can display them

            // Have to remove the '/' in each string
            for (int i = 0; i < listOfFoods.Length; i++)
            {
                listOfFoods[i] = listOfFoods[i].Trim(new Char[] { '/' });
            }

            // Add to combo box
            this.MealSelection.Items.AddRange(listOfFoods);
        }


        // Once a user has submitted their request for food
        public void Submit_Clicked(object sender, EventArgs e)
        {
            Requests_Handler.Add_Food(_chosenMealName, _HotOrCold, _mealType);
            MessageBox.Show("Your request has been recorded");
        }

        // Once a user has entered extra information regarding their request
        private void Requests_Text_Changed(object sender, EventArgs e)
        {

        }

		private void button3_Click(object sender, EventArgs e)
		{
			chosenResult = MessageBox.Show("A nurse will be with you as soon as possible");
			_request_emerg.CallRequest();
		}


		private void button3_Click_2(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_request_emerg.CallRequest();
		}
	}
}
