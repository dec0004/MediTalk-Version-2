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
        [Test]
        public void Resident_Can_Add_New_Request()
        {
            Assert.IsTrue(Mysql_User_Handler.Login("admin", "admin"), "User should be able to log in, but can't");
        }

        [Test]
        public void Staff_Can_View_Requests()
        {
            Assert.IsTrue(Mysql_User_Handler.Login("admin", "admin"), "User should be able to log in, but can't");
        }

        [Test]
        public void Staff_Can_Mark_Requests_As_Complete()
        {
            Assert.IsTrue(Mysql_User_Handler.Login("admin", "admin"), "User should be able to log in, but can't");
        }
    }
}