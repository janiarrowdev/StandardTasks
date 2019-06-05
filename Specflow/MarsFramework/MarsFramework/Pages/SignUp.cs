﻿using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SignUp
    {
        public SignUp()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement Join { get; set; }

        //Identify FirstName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/input")]
        private IWebElement FirstName { get; set; }

        //Identify LastName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/input")]
        private IWebElement LastName { get; set; }

        //Identify Email Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[3]/input")]
        private IWebElement Email { get; set; }

        //Identify Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[4]/input")]
        private IWebElement Password { get; set; }

        //Identify Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[5]/input")]
        private IWebElement ConfirmPassword { get; set; }

        //Identify Term and Conditions Checkbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[6]/div/div/input")]
        private IWebElement Checkbox { get; set; }

        //Identify join button
        [FindsBy(How = How.XPath, Using = "//*[@id='submit-btn']")]
        private IWebElement JoinBtn { get; set; }
        #endregion

        public void StartRegister()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");
            
            //Navigate to the Url
            string url = Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url");
            Console.WriteLine(url);
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);

            //Click on Join 
            Join.Click();
        }
            
        public void FillForm()
        {
            //Enter FirstName
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Checkbox.Click();

            //Click on join button to Sign Up
            JoinBtn.Click();
        }

        internal string register()
        {
            StartRegister();

            FillForm();

            return Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a")).Text;
            
        }

        public bool ValidateRegister()
        {
            string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a")).Text;
            bool success = false;

            if (text == "Mars Logo")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Signup Successful");
                success = true;
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Signup Unsuccessful");
            }

            return success;
        }
    }
}