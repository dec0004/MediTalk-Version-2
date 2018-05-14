﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicTalk
{
    public partial class List_Of_Requests : Form
    {
        private Form1 form1;
        public Mysql_Connect _connect;

        public List_Of_Requests(Form1 form1, Mysql_Connect connect)
        {
            this.form1 = form1;
            InitializeComponent();
            _connect = connect;
        }

        // Load the list of requests on button click
        private void List_Of_Requests_Load(object sender, EventArgs e)
        {
            Display_Lists();
        }


        /// <summary>
        /// Used to display all requests onto a list
        /// </summary>
        private void Display_Lists()
        {
            // Show requests for food
            Requests_Handler.Show_Requests();
            RequestsList.DataSource = Requests_Handler.DataTable;

            // Show requests for wake up calls and showers
            Requests_Handler.Show_Timed_Requests();
            TimedRequestsList.DataSource = Requests_Handler.DataTable;
        }


        /// <summary>
        /// Signals that a request has been completed, therefore it no longer
        /// has to display on the list
        /// </summary>
        private void FoodRequest_Completed(object sender, DataGridViewCellEventArgs e)
        {
            // Get the values needed to identify each unique row
            string date = RequestsList.Rows[e.RowIndex].Cells[8].Value.ToString();
            string time = RequestsList.Rows[e.RowIndex].Cells[9].Value.ToString();
            string uid = RequestsList.Rows[e.RowIndex].Cells[10].Value.ToString();

            // Have to reformat the string to fix Visual studio's stupid crap
            // Visual studio formats date to: "MM/DD/YYYY HH:MM:SS" When it needs to be "YYYY-MM-DD"
            date = date.Replace("/", "-");
            date = date.Substring(0, date.IndexOf(" ")); // Remove everything after the space

            string[] _splitdate = date.Split('-'); // Split up d, m, y
            string[] _reverseddate = new string[3];

            _reverseddate[0] = _splitdate[2]; // Map date to correct area
            _reverseddate[1] = _splitdate[0]; // Map month to correct area
            _reverseddate[2] = _splitdate[1]; // Map day to correct area

            date = String.Join("-", _reverseddate); // Combine strings



            // If it was able to complete the request, reload the list
            if (Requests_Handler.Complete_Request(uid, date, time))
            {
                Display_Lists();
            }
        }

    }
}
