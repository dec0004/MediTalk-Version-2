using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MedicTalk
{

    // This class will handle all communication to the SQL server. Other classes
    // that need to communicate to the server will do so through this class.
    public class Mysql_Connect
	{
		private string _myConnectionString;
		public MySqlConnection connection;
		private string queryResult;
		private string rows;


        // Stores functionality required to connect to the database
        #region Connection related functions
        public Mysql_Connect()
		{
			_myConnectionString = "server=192.185.16.222;database=dec0004_MediTalk;uid=dec0004_access; pwd=321xar22j;";
			connection = new MySqlConnection(_myConnectionString);
		}

        // <summary>
        // Try connect to the server. If it can't connect, provide an error message
        // </summary>
        public bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
					case 0:
						Debug.WriteLine("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
						Debug.WriteLine("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}

        // <summary>
        // Try close connection to the server. If it can't, provide an error message
        // </summary>
        public bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				Debug.WriteLine(ex.Message);
				return false;
			}
		}

        #endregion //  //


        /// /////////////////////////////////////////////////////////////////////////

        // <summary>
        // Insert a request into the table
        // </summary>
        public void Insert_Request(string query)
        {

            MySqlCommand _command = new MySqlCommand();

            if (this.OpenConnection())
            {
                // Change the time zone to match Melbourne's. Need to do call 
                // this every time we establish a connection since we 
                // don't have super privilege in MySQL
                Change_Timezone(_command);
                
                _command.CommandText = query;
                _command.Connection = connection;

                Console.WriteLine(query);

                _command.ExecuteNonQuery(); // Execute the command
            }

            this.CloseConnection();
        }


        public void Insert_With_Params()
        {

        }

        /// <summary>
        /// Replaces a value in a column. 
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="columnName">Name of column being changed</param>
        /// <param name="oldValue">The old value that will be replaced</param>
        /// <param name="newValue">The </param>
        public void Update_Replace_Value(string UID, string tableName, string columnName, string oldValue, string newValue)
        {
            MySqlCommand _command = new MySqlCommand();

            if (this.OpenConnection())
            {
                // Add parameters and execute the command to MySQL database
                _command.Connection = connection;
                _command.CommandText = 
                    "Update " + tableName +
                    " SET " + columnName + " = @newValue " +
                    "WHERE UID = @UID AND " + columnName + " = @oldValue;";
                _command.Parameters.AddWithValue("@newValue", newValue);
                _command.Parameters.AddWithValue("@oldValue", oldValue);
                _command.Parameters.AddWithValue("@UID", UID);
                _command.ExecuteNonQuery();


                // Below code is used to log the command for debugging purposes. Outputs the command that's given to MySQL
                string query = _command.CommandText;
                foreach (MySqlParameter p in _command.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
                Console.WriteLine(query);
            }
            this.CloseConnection();
        }


        /// <summary>
        /// Deletes entries in the database. ColumnsToCheck and ColumnExpectedValues 
        /// array must be of equal length. 
        /// </summary>
        /// <param name="TableName">Name of table to alter</param>
        /// <param name="ColumnsToCheck">Which columns should be checked using WHERE clause</param>
        /// <param name="ColumnExpectedValues">Deletes entries that have this value in ColumnsToCheck</param>
        public void Delete_Entries(string uid, string TableName, string[] ColumnsToCheck, string[] ColumnExpectedValues)
        {
            // There must be an equal amount of entries for both ColumnsToCheck and ColumnExpectedValues
            if (ColumnsToCheck.Length != ColumnExpectedValues.Length)
            {
                throw new InvalidOperationException("The array lengths in the arguments for Delete_Entries must be equal length");
            }

            MySqlCommand _command = new MySqlCommand();

            if (this.OpenConnection())
            {
                // Add parameters and execute the command to MySQL database
                _command.Connection = connection;
                _command.CommandText = "DELETE FROM " + TableName + " WHERE ";
                _command.Parameters.AddWithValue("@UID", uid);

                // Get the column length
                int AmtOfColumns = ColumnsToCheck.Length;

                // Loop through and add parameter for each value so the statement looks like:
                // WHERE ....  Column1 = Value1, Column2 = Value2, etc, etc
                for (int i = 0;i < AmtOfColumns;i++)
                {
                    _command.CommandText += ColumnsToCheck[i] + " = @ColumnExpectedValue" + i.ToString();
                    _command.Parameters.AddWithValue("@ColumnExpectedValue" + i.ToString(), ColumnExpectedValues[i]);
                    if (i < AmtOfColumns - 1)
                    {
                        _command.CommandText += " AND ";
                    }
                }
                _command.ExecuteNonQuery(); // Execute the command

                // For logging purposes
                string query = _command.CommandText;
                foreach (MySqlParameter p in _command.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
                //Console.WriteLine(query);
            }
            this.CloseConnection();
        }

        #region Add_Entries_Unused
        /*
        /// <summary>
        /// Add entry to a database.
        /// </summary>
        /// <param name="tableName">Name of table</param>
        /// <param name="ColumnNames">Columns to insert values into</param>
        /// <param name="ColumnValue">Values for the columns</param>
        public void Add_Entries(string tableName, string[] ColumnNames, string[] ColumnValue)
        {
            // There must be an equal amount of entries for both ColumnsToCheck and ColumnExpectedValues
            if (ColumnNames.Length != ColumnValue.Length)
            {
                throw new InvalidOperationException("The array lengths in the arguments for Add_Entries must be equal length");
            }

            MySqlCommand _command = new MySqlCommand();

            if (this.OpenConnection())
            {
                // Add parameters and execute the command to MySQL database
                _command.Connection = connection;
                _command.CommandText = "INSERT INTO " + tableName;
                _command.Parameters.AddWithValue("@UID", Mysql_User_Handler.User_ID);

                // Get the column length
                int AmtOfColumns = ColumnNames.Length;

                // Loop through each value to insert
                _command.CommandText += " (";
                // Add column names to the MySQL statement
                for (int i = 0; i < AmtOfColumns; i++)
                {
                    _command.CommandText += ColumnNames[i];
                    
                    // Add comma if not the final column in the statement
                    if (i < AmtOfColumns - 1)
                    {
                        _command.CommandText += ", ";
                    }
                }
                _command.CommandText += ") VALUES (";

                // Add column values to the MySQL statement
                for (int i = 0; i < AmtOfColumns; i++)
                {
                    // If a date or time is inserted, don't insert as parameter
                    if (ColumnValue[i] == "CURTIME()" || ColumnValue[i] == "CURDATE()")
                    {

                    }

                    _command.CommandText += "@ColumnValue" + i.ToString();
                    _command.Parameters.AddWithValue("@ColumnValue" + i.ToString(), ColumnValue[i]);

                    if (i < AmtOfColumns - 1)
                    {
                        _command.CommandText += ", ";
                    }
                }

                _command.CommandText += ");";
                _command.ExecuteNonQuery(); // Execute the command

                // For logging purposes
                string query = _command.CommandText;
                foreach (MySqlParameter p in _command.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
                Console.WriteLine("NEW QUERY = " + query);
            }
            this.CloseConnection();
        }
        */

        #endregion


        // <summary>
        // Mark a request as complete. Once marked as completed, a request will no longer 
        // be visible
        // </summary>
        public void Delete_Request(string query, string timeOfRequest)
        {
			this.CloseConnection();
			string _timeofrequest = timeOfRequest;
            MySqlCommand _command = new MySqlCommand();
			_command.Parameters.Add(new MySqlParameter("Time", _timeofrequest));
			//Debug.WriteLine(_timeofrequest);
            if (this.OpenConnection())
            {
                _command.CommandText = query;
                _command.Connection = connection;

                Console.WriteLine(query);

                _command.ExecuteNonQuery(); // Execute the command
            }

            this.CloseConnection();
        }





        // <summary>
        // Used to insert an entry into the database
        // </summary>
        public void Insert(string _inputCommand, List<string> parameterKey, List<string> parameterValues)
		{

			MySqlCommand _command = new MySqlCommand();
	
			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;

				for (int i = 0; i < parameterKey.Count; i++)
				{
					//A list of parameters have to be supplied due to an insert statement always having
					//varying parameters
					//Console.Write("@" + parameterKey[i] + parameterValues[i]);
					
					_command.Parameters.AddWithValue("@" + parameterKey[i], parameterValues[i]);
					
				}

				_command.Connection = connection;

				_command.ExecuteNonQuery();

				this.CloseConnection();
			}
		}



        // <summary>
        // Counts amount of rows for a select statement
        // </summary>
		public string Count(string _inputCommand)
		{
			rows = null;
			MySqlCommand _command = new MySqlCommand();
			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;
				_command.Connection = connection;
				//MySqlDataReader _reader = _command.ExecuteReader();
				//while (_reader.Read())
				//	{
				int count = Convert.ToInt32(_command.ExecuteScalar());
				rows = count.ToString();
					//	rows += _reader[0];
						//rows = rows.Substring(0, 1);
					
			///	}
			}
			this.CloseConnection();
			return rows;
		}

        // <summary>
        // Used to update an entry in the database
        // </summary>
        public void Update(string table, string queryToRun)
		{
            MySqlCommand _command = new MySqlCommand();

            queryToRun = "UPDATE " + table + " " + queryToRun;
            
            if (this.OpenConnection())
            {
                _command.CommandText = queryToRun;
                _command.Connection = connection;

                _command.ExecuteNonQuery();
            }
            this.CloseConnection();
        }



        // <summary>
        // Checks if any rows of data exists for the given query.
        // </summary>
        public bool DataExists(string tableName, string statementToCheck)
        {
            MySqlCommand _command = new MySqlCommand();
            string query = "SELECT * FROM " + tableName + " WHERE " + statementToCheck + ";";
            bool dataExists = false; // Will be returned at the end
			Console.WriteLine("Checking");
			if (this.OpenConnection())
            {
                _command.CommandText = query;
                _command.Connection = connection;

               

                MySqlDataReader mysql_Reader = _command.ExecuteReader();
                
                
                if (mysql_Reader.HasRows)
                {
                    dataExists = true;
				}
            }

            this.CloseConnection(); // Must close connection after mysql_Reader returns the result
			Console.WriteLine(dataExists);
			return dataExists; // Return whether theres data or not.
        }


        /// <summary>
        /// Checks if data exists in database given the parameters.
        /// </summary>
        /// <param name="tableName">Name of table</param>
        /// <param name="columnNames">Name of all columns to check</param>
        /// <param name="ColumnExpectedValue">Expected values in each column</param>
        /// <returns></returns>
        public bool DataDoesExist(string tableName, string[] columnNames, string[] ColumnExpectedValue)
        {
            MySqlCommand _command = new MySqlCommand();
            bool dataExists = false; // Will be returned at the end

            if (this.OpenConnection())
            {
                _command.CommandText = "SELECT * FROM " + tableName + " WHERE ";
                _command.Connection = connection;

                for (int i = 0;i < columnNames.Length;i++)
                {
                    _command.CommandText += columnNames[i] + " = @ColumnExpectedValue" + i.ToString();
                    _command.Parameters.AddWithValue("@ColumnExpectedValue" + i.ToString(), ColumnExpectedValue[i]);

                    if (i < columnNames.Length - 1)
                    {
                        _command.CommandText += " AND ";
                    }
                    else
                    {
                        _command.CommandText += ";";
                    }
                }
                // For logging purposes
                string query = _command.CommandText;
                foreach (MySqlParameter p in _command.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
                Console.WriteLine(query);

                _command.ExecuteNonQuery(); // Execute the command

                MySqlDataReader mysql_Reader = _command.ExecuteReader();

                if (mysql_Reader.HasRows)
                {
                    dataExists = true;
                }
            }
            this.CloseConnection(); // Must close connection after mysql_Reader returns the result

            return dataExists; // Return whether theres data or not.
        }



        // <summary>
        // Used to select an entry/entries in the database. Returns the results as a list of strings
        // </summary>
        // Parameters - tableName - Table to search in
        // Parameters - columns - Columns to display
        // Parameters - statementToCheck - The statement to check after the WHERE in SQL
        // Parameters - expectedAmtOfColumns - The amount of columns the result should return
        public List<string> Select(string tableName, string nameOfColumns, string statementToCheck, int expectedAmtOfColumns)
        {
            MySqlCommand _command = new MySqlCommand();
            string query = "SELECT " + nameOfColumns + " FROM " + tableName + " WHERE " + statementToCheck + ";";
            List<string> result = new List<string>(); // Will store all the returned data

            if (this.OpenConnection())
            {
                _command.CommandText = query;
                _command.Connection = connection;

                Console.WriteLine(query);
                
                MySqlDataReader mysql_Reader = _command.ExecuteReader();

                // Only grab data if there's any available rows for the query
                if (mysql_Reader.HasRows)
                {
                    while (mysql_Reader.Read())
                    {
                        string row = ""; // Will store the row data, that will then be added to the list later
                        for (int i = 0; i < expectedAmtOfColumns; i++)
                        {
                            // Make the result a string of all columns seperated by a / 
                            row += mysql_Reader.GetString(i) + "/";
                        }

                        result.Add(row); // Add the row to the list
                    }
                }

            }

            Console.WriteLine(query);
            this.CloseConnection();

            return result;
        }



        // <summary>
        // Used to select an entry in the database
        // </summary>
        public string Select(string _inputCommand, string _expectedRows, List<string> _keywords, List<string> parameterKey, List<string> parameterValues)
		{
			queryResult = "";
			MySqlCommand _command = new MySqlCommand();
			
			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;
				
				for (int i = 0; i < parameterKey.Count; i++)
				{
					//A list of parameters have to be supplied due to a select statement always having
					//varying parameters
					if (parameterKey.Count != 0)
					{
						_command.Parameters.AddWithValue("@" + parameterKey[i], parameterValues[i]);
					}
				}
				
				_command.Connection = connection;
				
				//This condition checks if more than one row is expected to be returned so it can return all rows

				//if only one row is expected it returns the row with all the keywords required to be returned
				if (_expectedRows == "1")
				{
					MySqlDataReader _reader = _command.ExecuteReader();

					while (_reader.Read())
					{
							for (int i = 0; i < _keywords.Count(); i++)
							{
								queryResult += _reader[_keywords[i]] + "/";
							}
					}
				}
				else // if more than one row is epected it returns all rows
				{
					MySqlDataReader _reader = _command.ExecuteReader();

					while (_reader.Read())
					{
							for (int i = 0; i < 1; i++)
							{
								queryResult += _reader[_keywords[0]] + "/";
							}

					}
				}

			}
			this.CloseConnection();

			return queryResult.Remove(queryResult.Length - 1); ;
		}


        /// <summary>
        /// Delete an entry from the database
        /// </summary>
        public void Delete(string query)
        {
            MySqlCommand _command = new MySqlCommand();
            if (this.OpenConnection())
            {
                _command.CommandText = query;
                _command.Connection = connection;

                Console.WriteLine(query);

                _command.ExecuteNonQuery(); // Execute the command
            }

            this.CloseConnection();
        }

        /// <summary>
        /// Used to change the CURTIME() for mysq
        /// </summary>
        public void Change_Timezone(MySqlCommand _command)
        {
            string query = "SET time_zone = 'Australia/Melbourne';";

                _command.CommandText = query;
                _command.Connection = connection;

                _command.ExecuteNonQuery();

        }
    }
}
