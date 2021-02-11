using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace Dev_Op_17._5._2020
{
    public class Home
    {
        //public Home()
        //{
        //}
        public void admin_button_click (IWebDriver wbdriver)
        {
            Thread.Sleep(1000);
            IWebElement saveButton = wbdriver.FindElement(By.XPath("//a[contains(.,'Administration')]"));
            saveButton.Click();
        }
        public void time_and_material_button_click(IWebDriver wbdriver)
        {
            IWebElement timeMaterial = wbdriver.FindElement(By.XPath("//a[@href='/TimeMaterial'][contains(.,'Time & Materials')]"));
            timeMaterial.Click();
        }

    }
}
