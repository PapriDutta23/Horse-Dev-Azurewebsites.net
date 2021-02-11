using System;
using System.Threading;
using Dev_Op_17._5._2020.Data__validity_Checking;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_Op_17._5._2020
{
	class UnitTest
	{
		//IWebDriver Wbdriver;
		

		//[SetUp]
		//public void LoginSteps()
		//{
			//Console.WriteLine("Hello World!");
			//Opening a new browser to open a new browser//
			//IWebDriver Wbdriver = new ChromeDriver();

			//creating an instance of the login page
			//Login loginpage = new Login();
			//loginpage.LogInSucess(Wbdriver);
		//}

		[Test]
		public void HomePage()
		{
			//Ceating an instance of a home page
			Home homepage = new Home();
			homepage.admin_button_click(Wbdriver);
			homepage.time_and_material_button_click(Wbdriver);

		}

		[Test]
		[TestCaseSource(typeof(TestDataClass), "TestCases")]
		public void CreateAndValidate(String CODE, String DESCRIPTION)
		{

			//Ceating an instance of a home page
			Home homepage = new Home();
			homepage.admin_button_click(Wbdriver);
			homepage.time_and_material_button_click(Wbdriver);


			//creating instance of time & material page
			TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

			time_material_page.createNewRecord(CODE , DESCRIPTION);

			//time_material_page.ValidateNewRecord();
			time_material_page.validateAnyRecord();




		}

		[Test]

		public void EditnValidate()

		{
			//Ceating an instance of a home page
			Home homepage = new Home();
			homepage.admin_button_click(Wbdriver);
			homepage.time_and_material_button_click(Wbdriver);

			// creating instance of time & material page
			TimeMaterial time_material_page = new TimeMaterial(Wbdriver);

			//time_material_page.EditNewRoecord();
			time_material_page.EditAnyRecord();

		}

		[Test]
		public void deleteRecord()
		{
			//Ceating an instance of a home page
			Home homepage = new Home();
			homepage.admin_button_click(Wbdriver);
			homepage.time_and_material_button_click(Wbdriver);

			//creating instance of time & material page
			TimeMaterial time_material_page = new TimeMaterial(Wbdriver);
			time_material_page.delete();
		}

		[Test]

		[TearDown]
		public void ClosingSteps()
		{
			Wbdriver.Quit();
		}

	}

}
	    
