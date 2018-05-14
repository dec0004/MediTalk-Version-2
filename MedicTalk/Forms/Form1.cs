using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MedicTalk
{
    // Log in form

	public partial class Form1 : Form
	{
		HomePage _HomePage;
        List_Of_Requests _requestsList;
		private string User_Name;
		private string Password;
		public string _firstName;
		public string _lastName;
		public string _room;
		public string _section;
		public Mysql_Connect _connect;

		public Form1()
		{
			InitializeComponent();
			_connect = new Mysql_Connect();
			_firstName = "";
			_lastName = "";
			_room = "";
			_section = "";
		}

       // #region Unimportant functions
        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Password_Textbox_Changed(object sender, EventArgs e)
        {

        }


	

	

        private void Login_Click(object sender, EventArgs e)
        {
			User_Name = Username_Textbox.Text;
			Password = Password_Textbox.Text;


			if (User_Name == "" || Password == "")
			{
				MessageBox.Show("You must enter both a password and username");
			}
			else
			{
                // Try logging in, if it doesn't work, inform the user that
                // they've entered an incorrect username or password.
                if (!Mysql_User_Handler.Login(User_Name, Password))
                {
                    MessageBox.Show("Invalid Credentials");
                }
                else
                {

                    if (Mysql_User_Handler.UserType == "staff")
                    {
                        _requestsList = new MedicTalk.List_Of_Requests(this, _connect);
                        this.Hide();
                        _requestsList.Show();
                    }
                    else if (Mysql_User_Handler.UserType == "resident")
                    {
                        _HomePage = new MedicTalk.HomePage(this, _connect);
                        this.Hide();
                        _HomePage.Show();
                    }
                }
		
			}
		}



		public void Logout()
		{
	
				this.Show();
				_HomePage = null;
			
		}







		public string PasswordProperty
		{
			get
			{
				return Password;
			}
			set
			{
				Password = value;
			}
		}

		public string UserNameProperty
		{
			get
			{
				return User_Name;
			}
			set
			{
				User_Name = value;
			}
		}

		public string RoomProperty
		{
			get
			{
				return _room;
			}
		}


		public string SectionProperty
		{
			get
			{
				return _section;
			}
		}
		public string FirstNameProperty
		{
			get
			{
				return _firstName;
			}
		}

		public string LastNameProperty
		{
			get
			{
				return _lastName;
			}
		}

    }
}
