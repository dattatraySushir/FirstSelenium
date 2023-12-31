﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.ObjectRepository
{
    [TestCategory("smoke")]
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;

        [FindsBy(How =How.Name,Using = "pwd")]
        private IWebElement password;

        [FindsBy(How=How.Id,Using = "keepLoggedInCheckBox")]
        private IWebElement checkBox;

        [FindsBy(How=How.Id,Using = "loginButton")]
        private IWebElement loginButton;

        public LoginPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public void login(String un, string pwd)
        {
            username.SendKeys(un);
            password.SendKeys(pwd);
        }
       
        public void ClickCheckbox()
        {
            checkBox.Click();
        }
        public void ClickLoginButton()
        {
            loginButton.Click();
        }




    }
}
