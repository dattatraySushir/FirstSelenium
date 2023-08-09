using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Fetching the data from the CSV file")]
    public class FetchingDataFromCSV : DataDrivernCsvFile
    {
        public const string csvpath = "D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\DataStored.csv";
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", csvpath, "DataStored#csv", DataAccessMethod.Sequential)]
        
        public void GetdataFromCSV()
        {
            
            Console.WriteLine(TestContext.DataRow["password"]);
           /* Console.WriteLine(TestContext.DataRow[1]);
            Console.WriteLine(TestContext.DataRow[2]);*/
           
        }
    }
}
