using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Report ScreenShot")]
    public class ScreenSHotReports
    {
       static IWebDriver driver;
       [TestMethod]
        public void WebScreenShot()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            IWebElement element=driver.FindElement(By.Name("pwd"));
            element.SendKeys("manager");
            driver.FindElement(By.Id("loginButton")).Click();
            //element.Submit();
          var Screenshot= WebScreenshot("WebScreenShot");
            

        }
        [TestMethod]
        public static String WebScreenshot(string name)
        {
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
           var source= screenshot.GetScreenshot();
            source.SaveAsFile("D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\ScreenShots\\"+name+".png",ScreenshotImageFormat.Png);
            return name;

        }
    }
}
