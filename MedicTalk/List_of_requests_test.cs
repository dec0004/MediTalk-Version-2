using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedicTalk;
using MySql.Data.MySqlClient;

namespace MediTalk
{
	// This class is responsible for testing all the functionality required
	// to connect the user to the application and database.
	[TestFixture]
	class List_of_requests_test
	{
		static Mysql_Connect _MySQL;
		private int food_request_number;
		private int shower_request_number;
		private System.Media.SoundPlayer player;
		private int food_request_count;
		private int shower_request_count;

		// Test that user can connect with correct credentials
		// Must return true for test to pass
		[Test]
		public void Should_Connect_If_User_Enters_NamePass()
		{
		}

		[Test]
		public void Nofication_for_new_food()
		{
			food_request_number = 0;
			_MySQL = new Mysql_Connect();
			player = new System.Media.SoundPlayer();
			player.SoundLocation = @"Resources/ding-sound-effect_2.wav";
			player.Load();
			food_request_count = int.Parse(_MySQL.Count("SELECT COUNT(*) FROM NEWFoodRequests"));

			if (food_request_number < food_request_count)
			{

				player.Play();
				food_request_number = food_request_count;
			}

			Assert.AreEqual(17, food_request_number);


		}
		/*
		[Test]
		public void Nofication_for_new_timed_request()
		{
			shower_request_number = 0;
			_MySQL = new Mysql_Connect();
			player = new System.Media.SoundPlayer();
			player.SoundLocation = @"C:\Users\Jordan\Documents\Swinburne\DTAP\MediTalk2\MediTalk-Version-2\MedicTalk\Resources/ding-sound-effect_2.wav";
			player.Load();
			shower_request_count = int.Parse(_MySQL.Count("SELECT COUNT(*) FROM NEWTimedRequests"));


			if (shower_request_number < shower_request_count)
			{
				player.Play();
				shower_request_number = shower_request_count;
			}

		}*/

	}
}
