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
	class HomePageTest
	{
		public HomePage _homePage;
		public Form1 _form1;
		public Mysql_Connect _mysql;

		[Test]
		public void Should_allow_general_assistance_to_work()
		{
			_form1 = new MedicTalk.Form1();
			_mysql = new MedicTalk.Mysql_Connect();
			_homePage = new HomePage(_form1, _mysql);
			_homePage.button10.PerformClick();
			Assert.AreEqual(_homePage.result, true);
			
		}
	}
}
