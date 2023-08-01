using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Attributes
{
    [TestClass]
    [TestCategory("Dynamic Data source")]
    public class DynamicData1
    {
        [TestMethod]
        [DynamicData(nameof(Names),DynamicDataSourceType.Method)]
        public void  DynamicData(string names, string values)
        {
            Console.WriteLine($"Attributes are {names} is at {values}");

        }
        public static IEnumerable<object[]> Names()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\TestData\\TestData.xlsx");
            var  sheet=spreadsheet.Workbook.Worksheets["datta"];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;
            
            for(int i=0; i <= maxrow; i++) {
            string name=sheet.Cell(i,0).ToString();
                string value=sheet.Cell(i,1).ToString();
              //  string position=sheet.Cell(i,2).ToString();
                yield return new object[] { name, value };
            }
        }

    }
}
