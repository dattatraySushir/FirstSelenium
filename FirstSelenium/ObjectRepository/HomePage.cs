using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.ObjectRepository
{/// <summary>
/// THis class is going to provide the elements of the homepage
/// </summary>
    public class HomePage
    {
        /// <summary>
        /// The decleration of the webElements using findsBy.
        /// </summary>
        
        [FindsBy(How = How.Id, Using = "logoutLink")]
        public IWebElement logoutButton { get; set; }


        [FindsBy(How= How.XPath,Using = "//div[@id='container_tt']")]
        private IWebElement timeTrack;
        [FindsBy(How = How.XPath,Using = "//div[@id='container_tasks']")]
        private IWebElement task;
        [FindsBy(How = How.XPath,Using = "//div[@id='container_reports']")]
        private IWebElement reports;
        [FindsBy(How = How.XPath,Using = "//div[@id='container_users']")]
        private IWebElement users;
        /// <summary>
        /// Initalization with the constructor by using pagefactory. initelements
        /// </summary>
        /// <param name="driver"></param>
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        /// <summary>
        /// The business logic for the further implementation and optimise the code in the test scripts.
        /// </summary>
        
        public By GetLogoutButton()
        {
            By locator =By.Id("logoutButton");
            return locator;
        }


        public void ClickLogout()
        {
            logoutButton.Click();
        }
        /// <summary>
        /// This me going to click on the Time-Track
        /// </summary>
        public void ClickTimeTrack()
        {
            timeTrack.Click();
        }
        /// <summary>
        /// This method is going to click on the tasks
        /// </summary>
        public void ClickTasks()
        {
            task.Click();
        }
        /// <summary>
        /// This method is going to click on the reports.
        /// </summary>
        public void ClickReports()
        {
            reports.Click();
        }
        /// <summary>
        /// This method is going to click on the users.
        /// </summary>
        public void ClickUsers()
        {
            users.Click();
        }


    }
}
