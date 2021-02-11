using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Dev_Op_17._5._2020.Hook_Up
{
    [Binding]
    public class TimeAndMaterialSteps

    {
        //Opening the driver and intialisation of the chrome driver
        // IWebDriver Wbdriver;
        IWebDriver Wbdriver = new ChromeDriver();

        [Given(@"I have logged in the Turn Up successfully")]
        public void GivenIHaveLoggedInTheTurnUpSuccessfully()
        {
            Console.WriteLine("Hello World!");
            //creating an instance of the login page
            Login loginpage = new Login();
            loginpage.LogInSucess(Wbdriver);
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            //Ceating an instance of a home page
            Home homepage = new Home();
            homepage.admin_button_click(Wbdriver);
            homepage.time_and_material_button_click(Wbdriver);


        }

        [When(@"I create a new time and material")]
        public void WhenICreateANewTimeAndMaterial()
        {

            //creating instance of time & material page
            TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

            time_material_page.createNewRecord("GARRY", "INTELLIGENT");


        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            Wbdriver.Quit();


        }

        [When(@"I have created new record")]
        public void WhenIHaveCreatedNewRecord()
        {
            //creating instance of time & material page
            TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

            time_material_page.createNewRecord("TOM", "SINGING");


        }

        
        [When(@"I have edited the new record")]
        public void WhenIHaveEditedTheNewRecord()
        {
            //creating instance of time & material page
            TimeMaterial time_material_page = new TimeMaterial(Wbdriver);
            time_material_page.EditNewRoecord();
            
        }


        [When(@"I create multiple time and material recodrs with below (.*) , (.*)")]
        public void WhenICreateMultipleTimeAndMaterialRecodrsWithBelow(string p1 , string p2)
        {
            //creating instance of time & material page
            TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

            time_material_page.createNewRecord(p1 , p2);


        }

        [Then(@"The record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {
            Wbdriver.Quit();
        }
               
        [When(@"I go the record which I want to delete")]
        public void WhenIGoTheRecordWhichIWantToDelete()
        {
            //creating instance of time & material page
            TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

            //deleting any record from any page(here i have choosen 6 th record from 3 rd page thats why for loop goes upto int i=3
            time_material_page.deleteAnyRecord();


        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            Wbdriver.Quit();
        }











    }
}





