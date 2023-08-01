using Bytescout.Spreadsheet;
using FirstSelenium.GenericLibraries;
using FirstSelenium.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.TestScripts
{
    [TestClass]
    [TestCategory("DataPractise")]
    public class LoginTest : Baseclass
    {

       
        [TestMethod]
        // [DataTestMethod]
        //  [DataRow("admin","manager")]
        // [DataRow("trainee", "trainee")]
        [DynamicData(nameof(Names), DynamicDataSourceType.Method)]

        public void LoginToApp1(string username, string password)
        {

           // FetchDataFromExcel excelfetch = new FetchDataFromExcel();
            //string username = excelfetch.ExcelDataFectch("Acti", 0, 0);
          //  string password = excelfetch.ExcelDataFectch("Acti", 1, 0);
            LoginPage loginpage= new LoginPage(driver);
            loginpage.login(username,password);
            loginpage.ClickCheckbox();
            loginpage.ClickLoginButton();
           
        }
        public static IEnumerable<object[]> Names()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\TestData\\TestData.xlsx");
            var sheet = spreadsheet.Workbook.Worksheets["Acti"];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;

            for (int i = 0; i <= maxrow; i++)
            {
                string username = sheet.Cell(i, 0).ToString();
                string password = sheet.Cell(i, 1).ToString();
                //  string position=sheet.Cell(i,2).ToString();
                yield return new object[] { username, password };
            }
        }


    }
}
