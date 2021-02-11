using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Dev_Op_17._5._2020
{
    class TimeMaterial
    {
        private IWebDriver Wbdriver;
        

       // public TimeMaterial(IWebDriver Wbdriver)
        //{
           // this.Wbdriver = Wbdriver;
        //}

        public void createNewRecord(string CODE, string DESCRPTION)
        {
            Thread.Sleep(1000);
            //Finding the create new button and then click
            IWebElement createNew = Wbdriver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
            createNew.Click();

            //Find Code button 
            IWebElement Code = Wbdriver.FindElement(By.Id("Code"));
            Code.SendKeys(CODE);

            //Find description button and entering value//
            IWebElement description = Wbdriver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
            description.SendKeys(DESCRPTION);
            //Thread.Sleep(3000);

            //Finding pricePerUnit and entering value//
            Thread.Sleep(1000);
            IWebElement price = Wbdriver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            price.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Wbdriver;
            js.ExecuteScript("document.getElementById(\"Price\").value='9000'");

            //finding  save button and then click
            IWebElement saveButton = Wbdriver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            saveButton.Click();
            //Thread.Sleep(3000);

        }

        

        public void ValidateNewRecord()
        {
            //Finding last button and then click
            Thread.Sleep(1500);
            IWebElement lastbtn = Wbdriver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        //Finding the first cell and third cell  elements of the last page of the table

                        var firstcell2 = Wbdriver.FindElement(By.XPath("//td[contains(.,'CODE')]")).Text;
                        var thirdcell2 = Wbdriver.FindElement(By.XPath("//td[@role='gridcell'][contains(.,'DESCRIPTION')]")).Text;

                        //logic to check the new record
                        if (firstcell2 == "JACK" && thirdcell2 == "NICE")
                        {
                            Console.WriteLine("Edit new record Test Passed");

                        }

                    }

                }
            }

            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }



        public void validateAnyRecord()
        {
            //find the next button
            Thread.Sleep(1000);
            IWebElement nxtButton = Wbdriver.FindElement(By.XPath("//a[@title='Go to the next page']"));

            //iteration from 1 st page to last page lets say page no 10000

            for (int j = 0; j <= 1000; j++)
            {
                int Z = 0;
                for (int i = 1; i <= 10; i++)
                {
                    //Thread.Sleep(1300);
                    IWebElement firstcell = Wbdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                    IWebElement thirdcell = Wbdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]"));

                    if (firstcell.Text == "good" && thirdcell.Text == "bengali")
                    {
                        Console.WriteLine("The data is valid and in the row is {0}", i);
                        //Console.ReadKey();
                        Z = 1;
                        break;

                    }
                }

                if (Z == 1)
                { break; }
                nxtButton.Click();

            }

        }

        public void EditNewRoecord()
        {
            // Finding last button and then click
            Thread.Sleep(1500);
            IWebElement lastbtn = Wbdriver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            lastbtn.Click();

            //Finding edit button and then click
            Thread.Sleep(1000);
            IWebElement edit = Wbdriver.FindElement(By.XPath("(//a[@class='k-button k-button-icontext k-grid-Edit'][contains(.,'Edit')])[4]"));
            edit.Click();

            //createNewRecord("Sumit", "Whitish");
            //Finding code button , click and clear
            IWebElement code2 = Wbdriver.FindElement(By.XPath("//input[@id='Code']"));
            code2.Click();
            code2.Clear();
            code2.SendKeys("Sumit");

            //Finding description button,click and clear
            IWebElement descrptn2 = Wbdriver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
            descrptn2.Click();
            descrptn2.Clear();
            descrptn2.SendKeys("Whitish");

            //Finding price per unit  button , click and clear
            Thread.Sleep(1000);
            IWebElement pricePerUnit = Wbdriver.FindElement(By.XPath("//input[@tabindex='0']"));
            pricePerUnit.Click();
            //          pricePerUnit.Clear();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Wbdriver;
            js.ExecuteScript("document.getElementById(\"Price\").value='9000'");

            //Finding save button and then click
            IWebElement save2 = Wbdriver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            save2.Click();

        }

        public void EditAnyRecord()
        {
            //find the next button
            Thread.Sleep(1000);
            IWebElement nxtButton = Wbdriver.FindElement(By.XPath("//a[@title='Go to the next page']"));

            for (int j = 1; j <= 2; j++)
            {
                nxtButton.Click();

            }

            Thread.Sleep(1000);
            //Finding the edit button and then click and clear
            IWebElement editbtn = Wbdriver.FindElement(By.XPath("(//a[@class='k-button k-button-icontext k-grid-Edit'])[9]"));
            editbtn.Click();

            //Finding code button , click and clear
            IWebElement code2 = Wbdriver.FindElement(By.XPath("//input[@id='Code']"));
            code2.Click();
            code2.Clear();
            code2.SendKeys("goodman");

            //Finding description button,click and clear
            IWebElement descrptn2 = Wbdriver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
            descrptn2.Click();
            descrptn2.Clear();
            descrptn2.SendKeys("Indian");

            //Finding price per unit  button , click and clear
            Thread.Sleep(1000);
            IWebElement pricePerUnit = Wbdriver.FindElement(By.XPath("//input[@tabindex='0']"));
            pricePerUnit.Click();
            //          pricePerUnit.Clear();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Wbdriver;
            js.ExecuteScript("document.getElementById(\"Price\").value='9000'");

            //Finding save button and then click
            IWebElement save2 = Wbdriver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            save2.Click();
            // Thread.Sleep(3000);

        }

        //  public void edit_Button()
        // {
        //Finding edit button and then click
        //  Thread.Sleep(2000);
        //  IWebElement edit = Wbdriver.FindElement(By.XPath("(//a[contains(.,'Edit')])[1]"));
        // edit.Click();

        //     //Identifying typeCode button and then sending keys
        //       IWebElement typeCode = Wbdriver.FindElement(By.XPath("(//span[contains(.,'select')])[4]"));
        //         typeCode.Click();
        //         typeCode.SendKeys("Material");


        //Identify code button and then click and sending data
        //  Thread.Sleep(1000);
        //  IWebElement code = Wbdriver.FindElement(By.XPath("(//input[@type='text'])[2]"));
        // code.Click();
        // code.Clear();
        // code.SendKeys("333");

        //Identify description button,click and sending data
        // Thread.Sleep(1000);
        //  IWebElement description = Wbdriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
        // description.Click();
        // description.Clear();
        // description.SendKeys("hard");

        //Identify price per unit button ,click and then then sending data
        // Thread.Sleep(1000);
        // IWebElement price = Wbdriver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
        // price.Click();
        // IJavaScriptExecutor js = (IJavaScriptExecutor)Wbdriver;
        // js.ExecuteScript("document.getElementById(\"Price\").value='3030'");

        //finding  save button and then click
        // IWebElement saveButton = Wbdriver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
        // saveButton.Click();
        //Thread.Sleep(3000);


        // }

        public void delete()

        {
            //Finding the webelement and then click
            Thread.Sleep(1000);
            IWebElement deleteButton = Wbdriver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            deleteButton.Click();

            //Finding the alert button

            IAlert alertButton = Wbdriver.SwitchTo().Alert();
            string alert_message = alertButton.Text;

            {
                if (alert_message.Equals("Are you sure you want to delete it"))
                {
                    Console.WriteLine("Correct message");
                }
                else
                {
                    Console.WriteLine("Incorrect message");
                }
            }
            alertButton.Accept();
        }


        public void deleteAnyRecord()
        {
            //find the next button and then click
            Thread.Sleep(1000);
            IWebElement nxtButton = Wbdriver.FindElement(By.XPath("//a[@title='Go to the next page']"));
            

            for (int j = 1; j <= 3; j++)
            {
                nxtButton.Click();

            }

            try
            {
               
                {
                    //finding the 6 rd  row from top
                    IWebElement thirdrow = Wbdriver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[6]"));

                    //finding the code of the 6 th row
                    var code = Wbdriver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[6]/td[1]")).Text;

                    //finding the description of the 6 th row
                    var desc = Wbdriver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[6]/td[3]"));
                    Console.WriteLine(desc.Text);
                                        
                  //    Assert.That(code, Is.EqualTo("RosePlant"));
                  //    Assert.That(desc, Is.EqualTo("EnglishRose"));
                                        
                    {
                        //Finding the  delete button and then click
                        Thread.Sleep(1000);
                        IWebElement deleteButton6 = Wbdriver.FindElement(By.XPath("(//a[contains(.,'Delete')])[6]"));
                        deleteButton6.Click();

                        //Finding the alert button
                        IAlert alertButton6 = Wbdriver.SwitchTo().Alert();
                        string alert_message = alertButton6.Text;
                        {
                            if (alert_message.Equals("Are you sure you want to delete it"))
                            {
                                Console.WriteLine("Correct message");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect message");
                            }
                        }
                        alertButton6.Accept();
                    }

                }
             
            }

            catch(Exception )
            {
                  Console.WriteLine("Test Failed");
                  //AssertionException();
            }


        }

        private void AssertionException()
        {
            throw new NotImplementedException();
        }
    }



}






