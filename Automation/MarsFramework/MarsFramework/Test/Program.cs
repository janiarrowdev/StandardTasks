using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework
{
    /*
       The main class with test cases
       Contains all the test cases performing tests on Profile, Share Skill and ManageListing
       */
    /// <summary>
    /// The main <c>Program</c> class.
    /// Contains all the test cases performing tests on Profile, Share Skill and ManageListing
    /// </summary>
    /// 
    public class Program
    {

        [TestFixture]
        class Service : Global.Base
        {
            /// <summary>
            /// Tests Save New Skill in to the Listing
            /// </summary>
            [Test]
            [Category("SkillListing")]
            public void SaveNewService()
            {
                //Allocate the number of services to be saved
                int NoOfServices = 2;

                ServiceListing ServiceListingObj = new ServiceListing();

                for (int i = 0; i < NoOfServices; i++)
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Save New Service");

                    // Open Share Skill Page
                    if (i == 0)
                    {
                        Profile profilePG = new Profile();
                        profilePG.ViewShareSkillPage();
                    }
                    else
                    {
                        ManageListing manageListingObj = new ManageListing();
                        manageListingObj.ViewShareSkillPage();
                    }

                    try
                    {
                        // Save New Service Listing

                        string ActualResult = ServiceListingObj.SaveNew(i);

                        //If Shared succesfully, the record should display in ManageListings Page
                        string ExpectedResult = "True";

                        Assert.AreEqual(ExpectedResult, ActualResult);

                        // Screenshot
                        String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "ShareSkill_" + i);
                        test.Log(LogStatus.Info, "Share Skill Successfully_" + i + ": " + img);
                    }
                    catch (Exception e)
                    {
                        Base.test.Log(LogStatus.Error, "Error in Shared Skill Save : " + e.Message);
                    }

                }
            }

            /// <summary>
            /// Tests View option for a particular Service 
            /// </summary>
            [Test]
            [Category("SkillListing")]
            public void ViewServiceListing()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("View A Listing");

                // View A Service Listing
                ManageListing ManageListingObj = new ManageListing();
                ManageListingObj.ViewManageListingPage();

                try
                {
                    string ActualResult = ManageListingObj.PerformAction("View");

                    //If Action Performed succesfully, page redirects to Service Detail Page
                    string ExpectedResult = "Service Detail";

                    Assert.AreEqual(ExpectedResult, ActualResult);

                    // Screenshot
                    String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "View Service");
                    test.Log(LogStatus.Info, "View Service Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in View Service : " + e.Message);
                }

            }

            /// <summary>
            /// Tests Edit option for a particular Service 
            /// </summary>
            [Test]
            [Category("SkillListing")]
            public void EditServiceListing()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Edit A Listing");

                // Edit A Service Listing
                ManageListing ManageListingObj = new ManageListing();
                ManageListingObj.ViewManageListingPage();

                try
                {
                    string ActualResult = ManageListingObj.PerformAction("Edit");

                    //If Action Performed succesfully, page redirects to Service Listing Page
                    string ExpectedResult = "ServiceListing";

                    Assert.AreEqual(ExpectedResult, ActualResult);

                    // Screenshot
                    String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Edit Service");
                    test.Log(LogStatus.Info, "Edit Service Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in Edit Service : " + e.Message);
                }

                //Edit the Service
                ServiceListing serviceListingObj = new ServiceListing();
                //serviceListingObj.SaveNew();
            }

            /// <summary>
            /// Tests Delte option for a particular Service 
            /// </summary>
            [Test]
            [Category("SkillListing")]
            public void DeleteServiceListing()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Delete A Listing");

                // Remove a Service Listing
                ManageListing ManageListingObj = new ManageListing();
                ManageListingObj.ViewManageListingPage();

                try
                {
                    string ActualResult = ManageListingObj.PerformAction("Delete");

                    //If Action Performed succesfully, record cannot be found from ListingManagement
                    string ExpectedResult = "False";

                    Assert.AreEqual(ExpectedResult, ActualResult);

                    // Screenshot
                    string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Delete Service");
                    test.Log(LogStatus.Info, "Delete Service Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in Delete Service : " + e.Message);
                }

            }

            /// <summary>
            /// Tests Register Page
            /// </summary>
            [Test]
            public void RegisterNewMember()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Register New Member");

                try
                {
                    SignUp signupObj = new SignUp();

                    string ActualResult = signupObj.register();

                    //If Action Performed succesfully, record cannot be found from ListingManagement
                    string ExpectedResult = "Mars Logo";

                    Assert.AreEqual(ExpectedResult, ActualResult);

                    // Screenshot
                    string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Register New");
                    test.Log(LogStatus.Info, "User Registered Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in User Register : " + e.Message);
                }

            }

            /// <summary>
            /// Tests Add New Language
            /// </summary>
            [Category("Profile")]
            [Test]
            public void AddLanguage()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add Language");

                try
                {
                    Profile profileObj = new Profile();
                    profileObj.AddLanguage();

                    //If Action Performed succesfully, record can be found from Language table
                    string ExpectedResult = "Spanish";

                    Assert.IsTrue(profileObj.CheckLanguageTable(ExpectedResult));

                    // Screenshot
                    string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Add Language");
                    test.Log(LogStatus.Info, "Language Added Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in Add Language : " + e.Message);
                }

            }

            /// <summary>
            /// Tests Update Language
            /// </summary>
            [Category("Profile")]
            [Test]
            public void UpdateLanguage()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Update Language");

                try
                {
                    Profile profileObj = new Profile();
                    profileObj.UpdateLanguage();

                    //If Action Performed succesfully, record can be found from Language table
                    string ExpectedResult = "Spanish";

                    Assert.IsTrue(profileObj.CheckLanguageTable(ExpectedResult));

                    // Screenshot
                    string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Add Language");
                    test.Log(LogStatus.Info, "Language Updated Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in Updated Language : " + e.Message);
                }

            }


            /// <summary>
            /// Tests Delete Language
            /// </summary>
            [Category("Profile")]
            [Test]
            public void DeleteLanguage()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Delete Language");

                try
                {
                    Profile profileObj = new Profile();
                    profileObj.DeleteLanguage();

                    //If Action Performed succesfully, record can not be found from Language table
                    string ExpectedResult = "Spanish";

                    Assert.IsFalse(profileObj.CheckLanguageTable(ExpectedResult));

                    // Screenshot
                    string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Add Language");
                    test.Log(LogStatus.Info, "Language Deleted Successfully" + img);
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Error, "Error in delete Language : " + e.Message);
                }

            }
            
        }
    }
}