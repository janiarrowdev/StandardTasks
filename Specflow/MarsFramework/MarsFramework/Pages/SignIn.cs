﻿using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            StartLogin();

            InputLoginDetails();

            validateLogin();
        }

        public void StartLogin()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            string url = Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url");
            Console.WriteLine(url);
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);

            //Click on Sign In tab
            SignIntab.Click();
            Thread.Sleep(500);
        }

        public void InputLoginDetails()
        {
            //Enter the data in Username textbox
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Username"));
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            LoginBtn.Click();
            Thread.Sleep(2500);
        }

        public bool validateLogin()
        {
            string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a")).Text;
            bool success = false;
            Console.WriteLine(text);
            if (text == "Mars Logo")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
                success = true;
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Unsuccessful");
            }

            return success;
        }
    }
}