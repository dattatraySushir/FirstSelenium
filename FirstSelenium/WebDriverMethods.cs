using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using static System.Net.WebRequestMethods;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("WebdriverMethods")]
    public class WebDriverMethods
    {
      //  [TestMethod]
        public void UrlProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

        }



      // [TestMethod]
        public void GetTittleProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Console.WriteLine(driver.Title);
        }
      //  [TestMethod]
        public void FindElememntProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            driver.FindElement(By.Id("APjFqb")).SendKeys("datta sushir");
        }
      //  [TestMethod]
        public void FindElementsProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
           ReadOnlyCollection<IWebElement> element= driver.FindElements(By.XPath("//div[@id='Alh6id']/child::div/child::div/child::ul/child::li"));
        }
       // [TestMethod]
        public void PageSourceProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);
        }
       // [TestMethod]
        public void CurrentWindowHandleProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string window = driver.CurrentWindowHandle;
            Console.WriteLine(window);

        }
       // [TestMethod]
        public void CurrentWindowHandlesProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement element=driver.FindElement(By.XPath("//a[text()='Images']"));
            Actions actions =new  Actions(driver);
            actions.MoveToElement(element).ContextClick().Build().Perform();


            KeyboardSimulator keybordSimulator = new KeyboardSimulator(new InputSimulator());
            keybordSimulator.KeyPress(VirtualKeyCode.DOWN);
            keybordSimulator.KeyPress(VirtualKeyCode.RETURN);



            ReadOnlyCollection<string> windowId=driver.WindowHandles;
            foreach (string id in windowId)
            {
                Console.WriteLine(id);
            }

        }
       // [TestMethod]
        public void CloseProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            driver.Close();
        }
      //  [TestMethod]
        public void QuitProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Images']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).ContextClick().Build().Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }
       // [TestMethod]
        public void NavigateProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().Refresh();
        }
       // [TestMethod]
        public void ManageProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }
       // [TestMethod]
        public void SwitchToProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
           driver.SwitchTo().Window("datta");
        }

    }
}
