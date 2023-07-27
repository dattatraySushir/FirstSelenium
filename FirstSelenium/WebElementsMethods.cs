using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace FirstSelenium
{
    [TestClass]
    public class WebElementsMethods
    {
        [TestMethod]
        public void TagNameProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
           IWebElement element= driver.FindElement(By.XPath("//a[text()='Gmail']"));
            String tagname = element.TagName;
            Console.WriteLine(tagname);
        }
        [TestMethod]
        public void TextProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            String text = element.Text;
            Console.WriteLine(text);
        }
        [TestMethod]
       public void EnabledProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.amazon.in/";
           IWebElement element= driver.FindElement(By.Id("twotabsearchtextbox"));
            bool enabled = element.Enabled;
            Console.WriteLine("In this we can get the element is working or not "+enabled);
        }
        [TestMethod]
        public void SelectedProperty()
            {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Id("keepLoggedInCheckBox")).Click();
            IWebElement element = driver.FindElement(By.Id("keepLoggedInCheckBox"));
            bool checkbox=element.Selected;
            Console.WriteLine("The checkbox is selected or not " + checkbox);

        }

        [TestMethod]
        public void LocationProperty()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element = driver.FindElement(By.Name("username"));
           Point loc= element.Location;
            Console.WriteLine(loc);
        }
        [TestMethod]
        public void SizeProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element = driver.FindElement(By.Name("username"));
           Size sz= element.Size;
            Console.WriteLine(sz);
        }
        [TestMethod]
        public void DispalyProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element=driver.FindElement(By.Id("[id='headerContainer']"));
           bool disp= element.Displayed;
            Console.WriteLine("The message is getting printed or not " + disp); ;
        }
        [TestMethod]
        public void ClearProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("username")).Clear();
        }
        [TestMethod]
        public void SendkeysProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url= "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
        }
        [TestMethod]
        public void SubmitProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("Admin");
            element.Submit();
        }
        [TestMethod]
        public void ClickProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.Click();    
        }
      

    }
}
