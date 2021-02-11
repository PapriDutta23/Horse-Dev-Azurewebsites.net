using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_Op_17._5._2020
{
    public class Login 
    {
		//IWebDriver Wbdriver = new ChromeDriver();
		//public Login()
		//{

		//}

	//	public Login(IWebDriver Wbdriver)
	//	{
	//		this.Wbdriver = Wbdriver;
	//	}

		public void LogInSucess(IWebDriver Wbdriver)
		{
			//navigating user to open Dev-op website//
			Wbdriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
			//Thread.Sleep(3000);

			//Find username element//
			IWebElement username = Wbdriver.FindElement(By.Id("UserName"));
			//writing username into the username testbox//
			username.SendKeys("hari");

			//Finding password into the password textbox//
			IWebElement password = Wbdriver.FindElement(By.Name("Password"));
			//writing password into the password textbox//
			password.SendKeys("123123");
			//Thread.Sleep(3000);

			//find loginbutton and then click
			IWebElement loginButton = Wbdriver.FindElement(By.XPath("//input[@class='btn btn-default']"));
			loginButton.Click();

		}
	}
}
