using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Op_17._5._2020.BaseClass
{
    public class BaseClass : CommonDrivers
    {
        //common driver to pass the driver accross pages
        //public static IWebDriver Wbdriver;
      //  public static Iwebdriver Wbdriver 
        [OneTimeSetUp]

        //browser factory to set up run tests via multiple browser
        public void OpenBrowser(IWebDriver Wbdriver)
        {
            Wbdriver = new ChromeDriver();
            //creating an instance of the login page
            var loginpage = new Login();
            loginpage.LogInSucess(Wbdriver);

        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            Wbdriver.Quit();
        }
    }
}
