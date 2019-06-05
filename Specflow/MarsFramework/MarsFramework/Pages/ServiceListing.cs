using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarsFramework.Global;
using System.Threading;
using AutoItX3Lib;
using System.Text.RegularExpressions;
using System.IO;

namespace MarsFramework.Pages
{
    /*
    The ServiceListing Class
    Contains all methods for performing Share Skill
    */
    /// <summary>
    ///  The ServiceListing Class
    /// Contains all methods for performing Share Skill
    /// </summary>
    class ServiceListing
    {
        public ServiceListing()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 

        //Identify Title Textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Identify Description Textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Identify Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement Category { get; set; }

        //Identify SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategory { get; set; }

        //Identify Tags Textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement Tags { get; set; }

        //Identify Service Type Hourly Based Radio Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement ServiceTypeHourlyBased { get; set; }

        //Identify Service Type One-off Radio Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement ServiceTypeOneOff { get; set; }

        //Identify Location Type OnSite Radio Button
        [FindsBy(How = How.Name, Using = "locationType")]
        private IWebElement LocationTypeOnSite { get; set; }

        //Identify Location Type Online Radio Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationTypeOnline { get; set; }

        //Identify Available Days Start Date
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDate { get; set; }

        //Identify Available Days End Date
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDate { get; set; }

        //Identify Available Days-Sun Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        private IWebElement SunCheckBox { get; set; }

        //Identify Available Days-Mon Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        private IWebElement MonCheckBox { get; set; }

        //Identify Available Days-Tue Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]
        private IWebElement TueCheckBox { get; set; }

        //Identify Available Days-Wed Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]
        private IWebElement WedCheckBox { get; set; }

        //Identify Available Days-Thurs Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")]
        private IWebElement ThursCheckBox { get; set; }

        //Identify Available Days-Fri Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")]
        private IWebElement FriCheckBox { get; set; }

        //Identify Available Days-Sat Check box
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input")]
        private IWebElement SatCheckBox { get; set; }


        //Identify Available Days-Sun Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        private IWebElement SunStartTime { get; set; }

        //Identify Available Days-Mon Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        private IWebElement MonStartTime { get; set; }

        //Identify Available Days-Tue Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        private IWebElement TueStartTime { get; set; }

        //Identify Available Days-Wed Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        private IWebElement WedStartTime { get; set; }

        //Identify Available Days-Thurs Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        private IWebElement ThursStartTime { get; set; }

        //Identify Available Days-Fri Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")]
        private IWebElement FriStartTime { get; set; }

        //Identify Available Days-Sat Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")]
        private IWebElement SatStartTime { get; set; }

        //Identify Available Days-Sun End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        private IWebElement SunEndTime { get; set; }

        //Identify Available Days-Mon End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        private IWebElement MonEndTime { get; set; }

        //Identify Available Days-Tue End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        private IWebElement TueEndTime { get; set; }

        //Identify Available Days-Wed End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        private IWebElement WedEndTime { get; set; }

        //Identify Available Days-Thurs End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        private IWebElement ThursEndTime { get; set; }

        //Identify Available Days-Fri End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")]
        private IWebElement FriEndTime { get; set; }

        //Identify Available Days-Sat End Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")]
        private IWebElement SatEndTime { get; set; }

        //Identify Skill Trade Exchange Radio Button
        [FindsBy(How = How.Name, Using = "skillTrades")]
        private IWebElement SkillTradeExchange { get; set; }

        //Identify Skill Trade Credit Radio Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement SkillTradeCredit { get; set; }

        //Identify Skill Exchange Tags Textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTags { get; set; }

        //Identify ChargeAmount Textbox
        [FindsBy(How = How.Name, Using = "charge")]
        private IWebElement ChargeAmount { get; set; }

        //Identify Work Samples Upload Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSampleUpload { get; set; }

        //Identify IsActive Radio Button
        [FindsBy(How = How.Name, Using = "isActive")]
        private IWebElement IsActive { get; set; }

        //Identify IsHidden Radio Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement IsHidden { get; set; }

        //Identify Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement Save { get; set; }

        //Identify Cancel Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[2]")]
        private IWebElement Cancel { get; set; }



        #endregion

        /// <summary>
        /// Saves the service record details given in the excel sheet data for given number of records <paramref name="RecordNo"/> and 
        /// returns data if record successfully saved
        /// </summary>
        /// <returns>
        /// If the record exists in the table
        /// </returns>
        /// <param name="RecordNo">The number of records to be saved as int Value </param>
        internal string SaveNew(int RecordNo)
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceListing");
            Thread.Sleep(1000);

            //Record Row No Starts with 2 in the DataSet
            RecordNo += 2;

            //Enter Title
            string TitleInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "Title");
            Title.SendKeys(TitleInput);

            //Enter Description
            string DescriptionInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "Description");
            Description.SendKeys(DescriptionInput);

            //Select Category
            string CategoryInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "Category");

            if (!("" == CategoryInput || null == CategoryInput))
            {
                ValidateCategory(CategoryInput);
                var selectCategory = new SelectElement(Category);
                selectCategory.SelectByText(CategoryInput);
                Thread.Sleep(1000);
            }

            //Select SubCategory
            string SubCategoryInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "SubCategory");

            if (!("" == SubCategoryInput || null == SubCategoryInput))
            {
                ValidateSubCategory(SubCategoryInput);
                var selectSubCatElement = new SelectElement(SubCategory);
                selectSubCatElement.SelectByText(SubCategoryInput);
                Thread.Sleep(500);
            }


            //Add tags
            //Multiple Tag values are supported using ',' seperater under the Tags column
            var TagsInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "Tags");
            string[] Inputs = TagsInput.Split(',');

            foreach (var tag in Inputs)
            {
                Tags.SendKeys(tag);
                Tags.SendKeys(Keys.Enter);
                Thread.Sleep(200);
            }

            //Select Service Type
            var ServiceTypeInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "ServiceType");

            if (!("" == ServiceTypeInput || null == ServiceTypeInput))
            {
                ValidateServiceType(ServiceTypeInput);
                if (ServiceTypeInput == "Hourly basis service")
                {
                    ServiceTypeHourlyBased.Click();
                }
                else
                {
                    ServiceTypeOneOff.Click();
                }
                Thread.Sleep(500);
            }


            //Select Location Type
            var LocationTypeInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "LocationType");

            if (!("" == LocationTypeInput || null == LocationTypeInput))
            {
                ValidateLocationType(LocationTypeInput);

                if (LocationTypeInput == "On-site")
                {
                    LocationTypeOnSite.Click();
                }
                else
                {
                    LocationTypeOnline.Click();
                }
                Thread.Sleep(500);
            }


            //Enter available days
            var StartDateInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "StartDate");
            var StartMonthInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "StartMonth");
            var StartYearInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "StartYear");
            var EndDateInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "EndDate");
            var EndMonthInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "EndMonth");
            var EndYearInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "EndYear");
            var AvailDaysInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "AvailableDays");
            var StartTimeInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "StartTime");
            var EndTimeInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "EndTime");

            if (StartDateInput != "")
            {
                StartDate.SendKeys(StartMonthInput);
                Thread.Sleep(200);
                StartDate.SendKeys(StartDateInput);
                Thread.Sleep(200);
                StartDate.SendKeys(StartYearInput);
                Thread.Sleep(500);
            }
            if (EndDateInput != "")
            {
                EndDate.SendKeys(EndMonthInput);
                Thread.Sleep(200);
                EndDate.SendKeys(EndDateInput);
                Thread.Sleep(200);
                EndDate.SendKeys(EndYearInput);
                Thread.Sleep(500);
            }

            string[] Days = AvailDaysInput.Split(',');

            foreach (var AvailDay in Days)
            {
                switch (AvailDay)
                {
                    case "Sun":
                        SunCheckBox.Click();
                        SunStartTime.SendKeys(StartTimeInput);
                        SunEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Mon":
                        MonCheckBox.Click();
                        MonStartTime.SendKeys(StartTimeInput);
                        MonEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Tue":
                        TueCheckBox.Click();
                        TueStartTime.SendKeys(StartTimeInput);
                        TueEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Wed":
                        WedCheckBox.Click();
                        WedStartTime.SendKeys(StartTimeInput);
                        WedEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Thur":
                        ThursCheckBox.Click();
                        ThursStartTime.SendKeys(StartTimeInput);
                        ThursEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Fri":
                        FriCheckBox.Click();
                        FriStartTime.SendKeys(StartTimeInput);
                        FriEndTime.SendKeys(EndTimeInput);
                        break;
                    case "Sat":
                        SatCheckBox.Click();
                        SatStartTime.SendKeys(StartTimeInput);
                        SatEndTime.SendKeys(EndTimeInput);
                        break;
                }
                Thread.Sleep(300);
            }

            //Select Skill Trade
            var SkillTradeInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "SkillTrade");

            if (!("" == SkillTradeInput || null == SkillTradeInput))
            {
                ValidateSkillTradeOption(SkillTradeInput);

                if (SkillTradeInput == "Skill-exchange")
                {
                    SkillTradeExchange.Click();
                    Thread.Sleep(500);

                    //Add Skill Exchange Tags
                    //Multiple Tag values are supported using ',' seperater under the Skill Exchange Tags column
                    var SkillExTagsInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "SkillExchangeTags");

                    if (SkillExTagsInput != "")
                    {
                        string[] SkillExTags = SkillExTagsInput.Split(',');

                        foreach (var skill in SkillExTags)
                        {
                            SkillExchangeTags.SendKeys(skill);
                            SkillExchangeTags.SendKeys(Keys.Enter);
                            Thread.Sleep(300);
                        }
                    }
                }
                else
                {
                    SkillTradeCredit.Click();
                    Thread.Sleep(500);

                    //Add Skill Trade Credit Amount
                    var SkillCreditAmountInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "SkillTradeCredit");
                    Thread.Sleep(500);

                    if (SkillCreditAmountInput != "")
                    {
                        ChargeAmount.SendKeys(SkillCreditAmountInput);
                        Thread.Sleep(500);
                    }
                }

            }

            //Add Work Samples

            var WorkSampleInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "WorkSamples");
            if (WorkSampleInput != "")
            {
                WorkSampleUpload.Click();

                AutoItX3 autoItX3 = new AutoItX3();
                autoItX3.WinActivate("File Upload");
                Thread.Sleep(200);
                autoItX3.Send(@WorkSampleInput);
                Thread.Sleep(500);
                autoItX3.Send("{ENTER}");
                Thread.Sleep(1000);
            }

            //Select Active Status
            var ActiveInput = GlobalDefinitions.ExcelLib.ReadData(RecordNo, "Active");

            if (!("" == ActiveInput || null == ActiveInput))
            {
                ValidateActiveOption(ActiveInput);
                if (ActiveInput == "Active")
                {
                    IsActive.Click();
                }
                else
                {
                    IsHidden.Click();
                }
                Thread.Sleep(500);
            }

            //Save Service Details
            Save.Click();
            Thread.Sleep(2000);

            //Check the saved record in the listings
            ManageListing manageListing = new ManageListing();
            bool IsExist = manageListing.ValidateRecordInTable(CategoryInput, TitleInput);
            return IsExist.ToString();
        }

        /// <summary>
        /// Checks if the category input <paramref name="CategoryInput"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when category is an invalid option from options given in the dropdown list.
        /// </exception>
        /// <param name="CategoryInput">The category name to be selected as a string </param>
        private void ValidateCategory(string CategoryInput)
        {
            SelectElement element = new SelectElement(Category);
            IList<IWebElement> elementList = element.Options;
            bool IsValid = false;

            foreach (var Elem in elementList)
            {
                if (CategoryInput.Equals(Elem.Text))
                {
                    IsValid = true;
                    break;
                }
            }

            if (!IsValid)
            {
                throw new Exception("Selected Category Unavailable");
            }
        }

        /// <summary>
        /// Checks if the subcategory input <paramref name="SubCategoryInput"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when subcategory is an invalid option from options given in the dropdown list.
        /// </exception>
        /// <param name="SubCategoryInput">The subcategory name to be selected as a string </param>
        private void ValidateSubCategory(string SubCategoryInput)
        {
            SelectElement element = new SelectElement(SubCategory);
            IList<IWebElement> elementList = element.Options;
            bool IsValid = false;

            foreach (var Elem in elementList)
            {
                if (SubCategoryInput.Equals(Elem.Text))
                {
                    IsValid = true;
                    break;
                }
            }

            if (!IsValid)
            {
                throw new Exception("Selected SubCategory Unavailable");
            }


        }

        /// <summary>
        /// Checks if the service type <paramref name="TypeInput"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when service type is an invalid option from options given in the page
        /// </exception>
        /// <param name="TypeInput">The service type name to be selected as a string </param>
        private void ValidateServiceType(string TypeInput)
        {
            if (!(TypeInput.Trim().Equals("Hourly basis service") || TypeInput.Trim().Equals("One-off service")))
            {
                throw new Exception("Invalid Service Type Selected");
            }
        }

        /// <summary>
        /// Checks if the location type <paramref name="TypeInput"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when location type is an invalid option from options given in the page
        /// </exception>
        /// <param name="TypeInput">The location type name to be selected as a string </param>
        private void ValidateLocationType(string TypeInput)
        {
            if (!(TypeInput.Trim().Equals("On-site") || TypeInput.Trim().Equals("Online")))
            {
                throw new Exception("Invalid Location Type Selected");
            }
        }

        /// <summary>
        /// Checks if the skill trade option <paramref name="SkillTradeInput"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when skill trade input is an invalid option from options given in the page
        /// </exception>
        /// <param name="SkillTradeInput">The Skill trade option name to be selected as a string </param>
        private void ValidateSkillTradeOption(string SkillTradeInput)
        {
            if (!(SkillTradeInput.Trim().Equals("Skill-exchange") || SkillTradeInput.Trim().Equals("Credit")))
            {
                throw new Exception("Invalid SkillTrade Selected");
            }

        }

        /// <summary>
        /// Checks if the Active status input <paramref name="ActiveStatus"/> is valid
        /// </summary>
        /// <exception cref="Exception">Thrown when Active Status input is an invalid option from options given in the page
        /// </exception>
        /// <param name="ActiveStatus">The status option name to be selected as a string </param>
        private void ValidateActiveOption(string ActiveStatus)
        {
            if (!(ActiveStatus.Trim().Equals("Active") || ActiveStatus.Trim().Equals("Hidden")))
            {
                throw new Exception("Invalid Active Status Selected");
            }

        }

      
    }
}
