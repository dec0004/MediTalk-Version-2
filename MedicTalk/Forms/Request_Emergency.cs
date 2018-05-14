using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicTalk
{
	public class Request_Emergency
	{
		List<string> Parameters;
		List<string> ParameterValues;
		Mysql_Connect connect;
		Form1 form1;
		public Request_Emergency(Mysql_Connect _connect, Form1 _form1)
		{
			connect = _connect;
			form1 = _form1;
		}

		public void CallRequest()
		{
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Type_of");
			Parameters.Add("Choice");
			Parameters.Add("First_Name");
			Parameters.Add("Last_Name");
			Parameters.Add("Section");
			Parameters.Add("Room");
			ParameterValues = new List<string>();
			//ParameterValues.Add(form1.UserIDProperty);
			ParameterValues.Add("Emergency Request");
			ParameterValues.Add("Emergency");
			ParameterValues.Add(form1.FirstNameProperty);
			ParameterValues.Add(form1.LastNameProperty);
			ParameterValues.Add(form1.SectionProperty);
			ParameterValues.Add(form1.RoomProperty);
			connect.Insert("INSERT INTO Requests (Request_id, User_id, Type_of, Choice, First_Name, Last_Name, Section, Room) VALUES (Default, @Type_of, 'Emergency Request', 'Emergency', '@First_Name', '@Last_Name', '@Section', '@Room')", Parameters, ParameterValues);
			
		}

	}
}
