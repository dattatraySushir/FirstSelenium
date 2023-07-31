using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.TestScripts
{
    [TestClass]
    public class FetchDataFromExcel
    {
        string path = "D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\Resources\\TestData.xlsx";
        public string ExcelDataFectch(string sheetname, int row, int cell)
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile(path);
            string data = sheet.Workbook.Worksheets.ByName(sheetname).Cell(row, cell).ToString();
            int maxrow = sheet.Workbook.Worksheets.ByName(sheetname).NotEmptyRowMax;
            sheet.Close();
            return data;
        }
        [TestMethod]
        [TestCategory("Excelfetch")]
        public void ExcelDataPrint()
        {
            for(int i = 0; i < 2; i++) {
                Console.WriteLine(ExcelDataFectch("Acti",i,0));
            }
        }
    }
  
}
