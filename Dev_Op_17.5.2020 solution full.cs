using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_Op_17._5._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Opening a new browser to open a new browser//
            IWebDriver Wbdriver = new ChromeDriver();

			// navigating user to open Dev-op website//
			//navigating user to open Dev-op website//
			Wbdriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

			//Find username element//
			IWebElement username = Wbdriver.FindElement(By.Id("UserName"));

			//writing username into the username testbox//
			username.SendKeys("hari");

			//Finding password into the password textbox//
			IWebElement password = Wbdriver.FindElement(By.Name("Password"));

			//writing password into the password textbox//
			password.SendKeys("123123");

			//find loginbutton and then click
			IWebElement loginButton = Wbdriver.FindElement(By.XPath("//input[@class='btn btn-default']"));
			loginButton.Click();

			//find the administration button and then click//
			IWebElement adminButton = Wbdriver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')] "));
			adminButton.Click();

			//finding time and material button and then click//
			IWebElement timeMaterial = Wbdriver.FindElement(By.XPath("//a[@href='/TimeMaterial'][contains(.,'Time & Materials')]"));
			timeMaterial.Click();

			//CreateNew button and then click//
			IWebElement createNew = Wbdriver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
			createNew.Click();

			//Find Code button 
			IWebElement Code = Wbdriver.FindElement(By.Id("Code"));
			Code.SendKeys("123");

			//Find description button and entering value//
			IWebElement description = Wbdriver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
			description.SendKeys("Purple");

			//Finding pricePerUnit and entering value//
			IWebElement pricePerUnit = Wbdriver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
			pricePerUnit.SendKeys("3000");

			//finding  save button and then click
			IWebElement saveButton = Wbdriver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
			saveButton.Click();


			//finding last page button and then click
			IWebElement lastPage = Wbdriver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e'][contains(.,'Go to the last page')]"));
			Thread.Sleep(3000);
			lastPage.Click();
			
		}
    }
}