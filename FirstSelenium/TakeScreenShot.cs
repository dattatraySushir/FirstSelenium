using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstSelenium
{
    [TestClass]
    public class TakeScreenShot1
    {
        [TestMethod]
        [TestCategory("ScreenShot")]
        public void TakingScreenShot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            ITakesScreenshot sh = (ITakesScreenshot)driver;
            var src = sh.GetScreenshot();
            src.SaveAsFile("D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\Program\\datta.png", ScreenshotImageFormat.Png);
        }
    }
}
