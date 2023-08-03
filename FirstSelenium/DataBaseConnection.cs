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
    public class DataBaseConnection
    {
        [TestMethod]
        public void DataBaseConnectionTest()
        {
            OdbcConnection conn = new OdbcConnection();

            //conn.ConnectionString =  $"jdbc:mysql://rmgtestingserver:3333/projects""root" };
          
        }
    }
}
