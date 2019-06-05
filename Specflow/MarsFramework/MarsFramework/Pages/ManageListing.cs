using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    /*
    The ManageListing Class
    Contains all methods on Managing the Services Listed 
    */
    /// <summary>
    ///  The ManageListing Class
    ///  Contains all methods on Managing the Services Listed
    /// </summary>
    class ManageListing
    {
        public ManageListing()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 

        //Identify table body
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table")]
        private IWebElement tableElement { get; set; }//*[@id='listing-management-section']/div[2]/div[1]/table

        //Identify ManageListing Tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement ManageListingTab { get; set; }//*[@id="account-profile-section"]/div/section[1]/div/a[3]

        //Identify Share Skill button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareSkillBtn { get; set; }

        //Identify Next Page button
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div/button[4]")]
        private IWebElement NextPageBtn { get; set; }

        #endregion

        /// <summary>
        /// Redirects to ManageListing Page
        /// </summary>
        internal void ViewManageListingPage()
        {
            ManageListingTab.Click();

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Performs an action <paramref name="action"/> on a particular service specidfied in the excel sheet data and returns the result
        /// </summary>
        /// <returns>
        /// If the record exists in the table or the current page, depending on the action
        /// </returns>
        /// <param name="action">The paricular action to be performed: View,Edit,Delete </param>
        internal string PerformAction(string action)
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            Thread.Sleep(1000);

            // Access Listing Table

            string Category = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            string Title = GlobalDefinitions.ExcelLib.ReadData(2, "Title");

            int rowNo = FindRowNo(Category, Title);

            if (rowNo == 0)
            {
                return "Unable to Find the record";
            }
            if (action == "View")
            {
                //Click View Icon
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + rowNo + "]/td[8]/i[1]")).Click();
            }
            else if (action == "Edit")
            {
                //Click Edit Icon
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + rowNo + "]/td[8]/i[2]")).Click();
            }
            else if (action == "Delete")
            {
                //Click Delete Icon
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + rowNo + "]/td[8]/i[3]")).Click();
                Thread.Sleep(1000);

                //Model View Confirm Yes
                GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]")).Click();

                //Check If the removed record exist in tableview
                bool IsExist = ValidateRecordInTable(Category, Title);
                return IsExist.ToString();
            }

            return GlobalDefinitions.driver.Title;
        }

        /// <summary>
        /// Checks if a particular record exisits in the table with Category <paramref name="Category"/> and Title <paramref name="Title"/> of the service 
        /// </summary>
        /// <returns>
        /// If the record exists in the table with true/false value
        /// </returns>
        /// <param name="Category">The category of the particular service to check</param>
        /// <param name="Title">The title of the particular service to check </param>
        internal bool ValidateRecordInTable(string Category, string Title)
        {
            Thread.Sleep(3000);

            bool IsExist = false;

            int row = FindRowNo(Category, Title);

            if (row != 0)
            {
                IsExist = true;
            }

            return IsExist;
        }
        

        /// <summary>
        /// Finds the rowno of a service in the listing
        /// </summary>
        /// <returns>
        /// The rowno of the the found service in the table
        /// </returns>
        /// <param name="Category">The category of the particular service to check</param>
        /// <param name="Title">The title of the particular service to check </param>
        /// <exception cref="Exception">Thrown when no record is found and reached the end of the pages
        /// </exception>
        private int FindRowNo(string Category, string Title)
        {
            bool isExist = false;

            int rowNo;


            do
            {
                rowNo = 1;

                Thread.Sleep(1000);

                IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                foreach (IWebElement row in tableRow)
                {

                    IList<IWebElement> rowTD = row.FindElements(By.TagName("td"));

                    if (rowTD.Count > 2)
                    {
                        if (rowTD[1].Text.Equals(Category) && rowTD[2].Text.Equals(Title))
                        {
                            //Searching Record Found
                            return rowNo;
                        }

                        rowNo++;
                    }
                }
                if (!isExist)
                {
                    try
                    {
                        if (NextPageBtn.Enabled)
                        {
                            NextPageBtn.Click();
                        }
                        else
                        {
                            throw new Exception("End of records");
                        }
                    }
                    catch (Exception e)
                    {
                        break;
                    }

                }

            } while (!isExist);

            return 0;
        }
        
        /// <summary>
        /// Redirects to the Service Listing Page
        /// </summary>
        internal void ViewShareSkillPage()
        {
            Thread.Sleep(1000);

            ShareSkillBtn.Click();
            
            Thread.Sleep(1000);
        }
        
    }
}
