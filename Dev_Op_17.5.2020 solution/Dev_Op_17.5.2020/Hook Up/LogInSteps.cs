using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Dev_Op_17._5._2020.Hook_Up
{
    [Binding]
    public class LoginSteps
    {
        //Intialising the chromedriver and opening it
        private IWebDriver Wbdriver;
        public LoginSteps( )
        {
          //  this.Wbdriver = Wbdriver;
        }

          
        [Given(@"I have provided right user name")]
        public void GivenIHaveProvidedRightUserName()
        {
            Console.WriteLine("Hello World!");
            //Opening a new browser to open a new browser//
           Wbdriver = new ChromeDriver();

            //navigating user to open Dev-op website//
            Wbdriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            //Thread.Sleep(3000);

            //Find username element//
            IWebElement username = Wbdriver.FindElement(By.Id("UserName"));

            //writing username into the username testbox//
            username.SendKeys("hari");
        }

        [Given(@"I have right Password")]
        public void GivenIHaveRightPassword()
        {
            //Finding password into the password textbox//
            IWebElement password = Wbdriver.FindElement(By.Name("Password"));

            //writing password into the password textbox//
            password.SendKeys("123123");
        }
        
        [Then(@"I will direct to the home page and quit")]
        public void ThenIWillDirectToTheHomePageAndQuit()
        {
            //find loginbutton and then click
            IWebElement loginButton = Wbdriver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            loginButton.Click();

            //Quiting the driver
            Thread.Sleep(1000);
            Wbdriver.Quit();

        }
    }
}
