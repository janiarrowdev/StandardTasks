using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[2]")]
        private IWebElement ProfileEdit { get; set; }

        //Click on language tab 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        private IWebElement LanguageTab { get; set; }

        //Click on Edit Availability 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement EditAvailabilityIcon { get; set; }
        
        //Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Part Time option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]")]
        private IWebElement AvailabilityPartTimeOpt { get; set; }

        //Click on Availability Full Time option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]")]
        private IWebElement AvailabilityFullTimeOpt { get; set; }
        
        //Click on Current Availability 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")]
        private IWebElement CurrentAvailability { get; set; }
        
        //Click on Edit Availability Hour Icon
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement EditAvailabilityHoursIcon { get; set; }
        
        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]")]
        private IWebElement AvailabilityHoursOpt1 { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]")]
        private IWebElement AvailabilityHoursOpt2 { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]")]
        private IWebElement AvailabilityHoursOpt3 { get; set; }

        //Click on Current Availability Hour 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")]
        private IWebElement CurrentAvailabilityHours { get; set; }



        //Click on Edit Earn Tareget Icon
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement EditEarnTargetIcon { get; set; }

        //Click on Earn Tareget dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select")]
        private IWebElement EarnTarget { get; set; }

        //Click on Earn Tareget Option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[2]")]
        private IWebElement EarnTargetOpt1 { get; set; }

        //Click on Earn Tareget Option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]")]
        private IWebElement EarnTargetOpt2 { get; set; }

        //Click on Earn Tareget Option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]")]
        private IWebElement EarnTargetOpt3 { get; set; }

        //Click on Current Earn Tareget Option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")]
        private IWebElement CurrentEarnTarget { get; set; }
        
        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How =How.XPath,Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")]
        private IWebElement ChooseLangOpt { get; set; }//*[@id="account-profile-section"]


        //Choose Language Level on drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLangLevel { get; set; }
        
        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Languages Table
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table")]
        private IWebElement LangTable { get; set; }

        //Update Language Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement UpdateLangBtn { get; set; }

        //Update Language row
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]")]
        private IWebElement UpdateLangRecord { get; set; }

        //Update Language name
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement UpdateLangName { get; set; }

        //Delete Language button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]")]
        private IWebElement DelteLangRecord { get; set; }

        

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

       
        #endregion

        public void ViewLanguageTab()
        {
            LanguageTab.Click();

            Thread.Sleep(400);
        }

        public void AddLanguage(int count)
        {
            
           for(int i = 0; i< count; i++)
            {
                try
                {
                    AddNewLangBtn.Click();
                    Thread.Sleep(500);

                    //Add Language
                    //Excel sheet must be updated accordingly
                    AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(i + 2, "Language"));

                    //Click on Language Level
                    ChooseLangLevel.Click();
                    Thread.Sleep(500);

                    ChooseLangOpt.Click();
                    Thread.Sleep(1000);

                    //Click on Add button
                    AddLang.Click();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
            }
           
        }

        public void UpdateLanguage()
        {
            //Click on update record 
            UpdateLangRecord.Click();
            Thread.Sleep(500);
            
            //Clear the field and update the Language
            UpdateLangName.Clear();
            UpdateLangName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Click on Add button
            UpdateLangBtn.Click();
            
        }

        public void UpdateLanguageLevel()
        {
            //Click on update record 
            UpdateLangRecord.Click();
            Thread.Sleep(500);
            
            //Click on Language Level
            ChooseLangLevel.Click();
            Thread.Sleep(500);

            ChooseLangOpt.Click();
            Thread.Sleep(1000);

            //Click on Add button
            UpdateLangBtn.Click();

        }

        public void DeleteLanguage()
        {
            IList<IWebElement> tableRow = LangTable.FindElements(By.TagName("tbody"));

            int RowNo = 0;

            foreach (IWebElement row in tableRow)
            {
                RowNo++;

                IList<IWebElement> rowTD = row.FindElements(By.TagName("td"));

                if (rowTD[0].Text.Equals("Spanish"))
                {
                    //Click on delete button
                    DelteLangRecord.Click();
                }
            }
        }

        public bool CheckLanguageTable(string Qry)
        {
            try
            {
                IList<IWebElement> tableRow = LangTable.FindElements(By.TagName("tbody"));

                foreach (IWebElement row in tableRow)
                {
                    IList<IWebElement> rowTD = row.FindElements(By.TagName("td"));

                    if (rowTD[0].Text.Equals(Qry))
                    {

                        Thread.Sleep(500);
                        return true;

                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            

            return false;
        }

        public int GetNoOfLanguagesListed()
        {
            IList<IWebElement> tableRow = LangTable.FindElements(By.TagName("tbody"));

            return tableRow.Count;
            
        }

        public void ClickEditAvailability()
        {
            Thread.Sleep(500);

            EditAvailabilityIcon.Click();
            
            Thread.Sleep(1000);
        }

        public void UpdateAvailability()
        {
            AvailabilityTime.Click();

            Thread.Sleep(1000);

            string AvailTime = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime");

            if (AvailTime.Equals("Full Time"))
            {
                AvailabilityFullTimeOpt.Click();
            }
            else
            {
                AvailabilityPartTimeOpt.Click();
            }
           

            Thread.Sleep(500);
        }

        public string ValidateAvailability()
        {
            return CurrentAvailability.Text;
            
        }

        public void ClickEditAvailHours()
        {
            Thread.Sleep(500);

            EditAvailabilityHoursIcon.Click();

            Thread.Sleep(1000);
        }

        public void UpdateAvailabilityHours()
        {
            AvailabilityHours.Click();

            Thread.Sleep(1000);

            string OptionNo = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableHours");

            if (OptionNo.Equals("1"))
            {
                AvailabilityHoursOpt1.Click();
            }
            else if (OptionNo.Equals("2"))
            {
                AvailabilityHoursOpt2.Click();
            }
            else
            {
                AvailabilityHoursOpt3.Click();
            }
            
            Thread.Sleep(500);
        }

        public string ValidateAvailabilityHours()
        {
            return CurrentAvailabilityHours.Text;

        }

        public void ClickEditEarnTarget()
        {
            Thread.Sleep(500);

            EditEarnTargetIcon.Click();

            Thread.Sleep(1000);
        }

        public void UpdateEarnTarget()
        {
            EarnTarget.Click();

            Thread.Sleep(1000);

            string OptionNo = GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget");

            if (OptionNo.Equals("1"))
            {
                EarnTargetOpt1.Click();
            }
            else if (OptionNo.Equals("2"))
            {
                EarnTargetOpt2.Click();
            }
            else
            {
                EarnTargetOpt3.Click();
            }
            
            Thread.Sleep(500);
        }

        public string ValidateEarnTarget()
        {
            return CurrentEarnTarget.Text;

        }
    }
}