using AventStack.ExtentReports;
using FirstSelenium.TestReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("DatabaseConnection")]
    public class ConnectionToDB1 :BaseClassReports
    {
        [TestMethod]
        public void DBConnection()
        {
            extentTest = extentReports.CreateTest(TestContext.TestName);
            string connectionstring = "Driver={MySQL ODBC 8.1 Unicode Driver};Server=rmgtestingserver:3333;Database=projects;User=root@%;Password=root;";
            OdbcConnection connection = new OdbcConnection(connectionstring);
            string query = "select * from project";
            connection.Open();
            OdbcCommand command = new OdbcCommand(query, connection);   
            var tables=command.ExecuteReader();
            Console.WriteLine(tables);
            while(tables.Read())
            {
                extentTest.Log(Status.Info, tables[0].ToString() + " " + tables[1].ToString() + " " + tables[2].ToString() + " " + tables[3].ToString());
                Console.WriteLine(tables[0].ToString() + " " + tables[1].ToString() + " " + tables[2].ToString() + " " + tables[3].ToString());
            }
            connection.Close();
        }
    }
}
