using System;
using CSCBlog.Core.Data.MySql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSCBlog.Tests.Core
{
    [TestClass]
    public class MySqlTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void DBConnect()
        {

            IMySqlDatabase iMySqlDatabase = new MySQLDatabase("DefaultConnection");
            //var result= iMySqlDatabase.QueryValue("", null);
            Assert.ThrowsException<ArgumentException>(() => { iMySqlDatabase.QueryValue("", null); }, "Command text cannot be null or empty.");
        }
    }
}
