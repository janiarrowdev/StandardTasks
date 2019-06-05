using System;
using System.Threading;
using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.Test;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.StepDef
{
    [Binding]
    public class FeatureStepDef : Program
    {
        SignIn loginobj;
        SignUp obj;

        Profile profileObj;
        
        ManageListing ManageListingObj;
        ServiceListing ServiceListingObj;

        //Add New Language

        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            profileObj = new Profile();
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            profileObj.ViewLanguageTab();
        }
       
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            profileObj.AddLanguage(1);
        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            bool Expected = true;
            bool ActualResult = profileObj.CheckLanguageTable("Spanish");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Added");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to add language");
            }
        }

        //Edit an existing Language

        [When(@"I edit the language")]
        public void WhenIEditTheLanguage()
        {
            profileObj.UpdateLanguage();
        }

        [Then(@"the updated language should be displayed on my listings")]
        public void ThenTheUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            bool Expected = true;
            bool ActualResult = profileObj.CheckLanguageTable("Spanish");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Updated");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to update language");
            }
        }

        //Edit a level of an existing Language

        [When(@"I edit the level on the language")]
        public void WhenIEditTheLevelOnTheLanguage()
        {
            profileObj.UpdateLanguageLevel();
        }

        [Then(@"the updated level should be displayed on my listings")]
        public void ThenTheUpdatedLevelShouldBeDisplayedOnMyListings()
        {
            bool Expected = true;
            bool ActualResult = profileObj.CheckLanguageTable("Fluent");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Level Updated");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to update language level");
            }

        }

        //Delete language

        [When(@"I delete an existing language")]
        public void WhenIDeleteAnExistingLanguage()
        {
            profileObj.DeleteLanguage();
        }

        [Then(@"that language should be removed on my listings")]
        public void ThenThatLanguageShouldBeRemovedOnMyListings()
        {
            bool Expected = false;
            bool ActualResult = profileObj.CheckLanguageTable("Spanish");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Removed Successfully");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to remove language");
            }

        }

        //Add multiple languages

        [When(@"I add four new languages")]
        public void WhenIAddFourNewLanguages()
        {
            profileObj.AddLanguage(4);
        }

        [Then(@"I should not be able to add more languages")]
        public void ThenIShouldNotBeAbleToAddMoreLanguages()
        {
            profileObj.AddLanguage(1);
        }

        //Add languages without language level

        [When(@"I add a language without giving the language level")]
        public void WhenIAddALanguageWithoutGivingTheLanguageLevel()
        {
            profileObj.AddLanguage(1);
        }

        [Then(@"the record should not be in the listing")]
        public void ThenTheRecordShouldNotBeInTheListing()
        {
            bool Expected = false;
            bool ActualResult = profileObj.CheckLanguageTable("");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Removed Successfully");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to remove language");
            }
        }

        //Add languages without language name

        [When(@"I select the language level without giving a language name")]
        public void WhenISelectTheLanguageLevelWithoutGivingALanguageName()
        {
            profileObj.AddLanguage(1);
        }

        //Add languages with empty spaces

        [When(@"I add a language entering empty space")]
        public void WhenIAddALanguageEnteringEmptySpace()
        {
            profileObj.AddLanguage(1);
        }
        
      
        //Update Availability
     
        [Given(@"I clicked on the edit button in Availability")]
        public void GivenIClickedOnTheEditButtonInAvailability()
        {
            profileObj = new Profile();
            profileObj.ClickEditAvailability();
        }

        [When(@"I change the Availability")]
        public void WhenIChangeTheAvailability()
        {
            profileObj.UpdateAvailability();
        }

        [Then(@"that changed Availability should be displayed in my profile page")]
        public void ThenThatChangedAvailabilityShouldBeDisplayedInMyProfilePage()
        {
            string Expected = "Full Time";

            string Actual = profileObj.ValidateAvailability();

            try
            {
                Console.WriteLine(Actual);
                Assert.AreEqual(Expected, Actual);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Update hours

        [Given(@"I clicked on the edit button in Hours")]
        public void GivenIClickedOnTheEditButtonInHours()
        {
            profileObj = new Profile();
            profileObj.ClickEditAvailHours();
        }


        [When(@"I change the Hours")]
        public void WhenIChangeTheHours()
        {
            profileObj.UpdateAvailabilityHours();
        }

        [Then(@"that changed Hours should be displayed in my profile page")]
        public void ThenThatChangedHoursShouldBeDisplayedInMyProfilePage()
        {
            string Expected = "More than 30hours a week";

            string Actual = profileObj.ValidateAvailabilityHours();

            try
            {
                Console.WriteLine(Actual);
                Assert.AreEqual(Expected, Actual);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Update Earn Target

        [Given(@"I clicked on the edit button in Earn Target")]
        public void GivenIClickedOnTheEditButtonInEarnTarget()
        {
            profileObj = new Profile();
            profileObj.ClickEditEarnTarget();
        }
        
        [When(@"I change the Earn Target")]
        public void WhenIChangeTheEarnTarget()
        {
            profileObj.UpdateEarnTarget();
        }

        [Then(@"that modified Earn Target should be displayed in my profile page")]
        public void ThenThatModifiedEarnTargetShouldBeDisplayedInMyProfilePage()
        {
            string Expected = "More than $1000 per month";

            string Actual = profileObj.ValidateEarnTarget();

            try
            {
                Console.WriteLine(Actual);
                Assert.AreEqual(Expected, Actual);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Share New Skill

        [Given(@"I clicked on the share skill on the profile page")]
        public void GivenIClickedOnTheShareSkillOnTheProfilePage()
        {
            ManageListingObj = new ManageListing();
            ManageListingObj.ViewShareSkillPage();
        }

        [When(@"I save the skill details")]
        public void WhenISaveTheSkillDetails()
        {
            ServiceListingObj = new ServiceListing();
            ServiceListingObj.SaveNew(1);
        }

        [Then(@"that skill should be displayed in my listing")]
        public void ThenThatSkillShouldBeDisplayedInMyListing()
        {
            bool Expected = true;
            bool ActualResult = ManageListingObj.ValidateRecordInTable("MyTestTile", "Business");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Skill Added");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to Add Skill");
            }

        }
        //Update Manage Listing

        [Given(@"I clicked on the ManageListing tab")]
        public void GivenIClickedOnTheManageListingTab()
        {
            ManageListingObj = new ManageListing();
            ManageListingObj.ViewManageListingPage();
        }
        
        [When(@"I update the selected skill in the listing")]
        public void WhenIUpdateTheSelectedSkillInTheListing()
        {
            ManageListingObj.PerformAction("Edit");
        }

        [Then(@"that updated skill should be displayed in my listing")]
        public void ThenThatUpdatedSkillShouldBeDisplayedInMyListing()
        {
            bool Expected = true;
            bool ActualResult = ManageListingObj.ValidateRecordInTable("MyTestTile2", "Business");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Skill Updated Successfully");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to Add Skill");
            }
        }

        //Delete Skill Listing

        [When(@"I delete the selected skill in the listing")]
        public void WhenIDeleteTheSelectedSkillInTheListing()
        {
            ManageListingObj.PerformAction("Delete");
        }

        [Then(@"that skill should not be displayed in my listing")]
        public void ThenThatSkillShouldNotBeDisplayedInMyListing()
        {
            bool Expected = false;
            bool ActualResult = ManageListingObj.ValidateRecordInTable("MyTestTile", "Business");

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Skill Removed Successfully");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to Remove Skill");
            }
        }


        //Sign In
        //Make sure to update the resource file IsLogin property
        //Ex: IsLogin : Customize

        [Given(@"I clicked on the Sign In button on home page")]
        public void GivenIClickedOnTheSignInButtonOnHomePage()
        {
            loginobj = new SignIn();
            loginobj.StartLogin();
        }

        [When(@"I add Username and Password")]
        public void WhenIAddUsernameAndPassword()
        {
            loginobj.InputLoginDetails();
        }

        [Then(@"it should redirect to profile page")]
        public void ThenItShouldRedirectToProfilePage()
        {
            bool Expected = true;
            bool ActualResult = loginobj.validateLogin();
            Console.WriteLine(ActualResult);
            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Login Success");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to Login");
            }

        }

        //Register 
        //Make sure to update the resource file IsLogin property
        //Ex: IsLogin : Customize

        [Given(@"I clicked on the Join button on home page")]
        public void GivenIClickedOnTheJoinButtonOnHomePage()
        {
            obj = new SignUp();
            obj.StartRegister();
        }
        
        [When(@"I fill up the registration details and join")]
        public void WhenIFillUpTheRegistrationDetailsAndJoin()
        {
            obj.FillForm();
        }

        [Then(@"it should redirect to the profile page")]
        public void ThenItShouldRedirectToTheProfilePage()
        {
            bool Expected = true;
            bool ActualResult = obj.ValidateRegister();

            try
            {
                Assert.AreEqual(Expected, ActualResult);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Successfully Registered");
            }
            catch (Exception e)
            {
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Failed to Register");
            }
        }
    }
}
