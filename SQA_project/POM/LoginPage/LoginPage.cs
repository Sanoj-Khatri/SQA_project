using AutoIt;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace SQA_project.POM.LoginPage
{
    [TestClass]
    public class LoginPage : Execution
    { 
        [TestMethod]
        //Task 2
        public void BroswerOption()
        {
            //string expected = "Invalid Login details or Your Password might have expired.";
            //string actual = "Invalid Login details or Your Password might have expired.";
            ChromeOptions options = new ChromeOptions();
            // EdgeOptions options = new EdgeOptions();

            // options.AddArguments("headless");
            //options.AddArguments("incognito");
            //options.AddArguments("-start-maximized");

            //IWebDriver driver = new ChromeDriver(options);
            //IWebDriver driver2 = new EdgeDriver(options);
            //driver.Url = "https://adactinhotelapp.com/";
            //InitilizeChrome();
            OpenUrl("https://adactinhotelapp.com/");
            By username = By.Id("username");
            By password = By.Id("password");
            By loginbtn = By.Id("login");
            EnterText(username, "AmirImam");
            EnterText(password, "bnsdkjkjasbdwsd");
            Click(loginbtn);
          //  Assert.AreEqual(expected, actual);

            Screenshot();


          //  QuitChrome();
        }
        //AutoItX.Send("{TAB 3}");
        //AutoItX.Send("AmirImam");
        //AutoItX.Send("{TAB}");
        //AutoItX.Send("AmirImam");
        //AutoItX.Send("{ENTER}");
        ////AutoItX.Send("{TAB}");
        ////Thread.Sleep(2000);
        ////AutoItX.MouseClick();

       

        [TestMethod]
        public void FromAutomateAutoItX() {
           
            
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("FromAutomateAutoItX");
    
            OpenUrl("https://demoqa.com/automation-practice-form");
            string path = @"C:\TestExecutionReports\";
            ButtonKey("{TAB 2}");
            EnetrTextAutoItX("Sanoj");

            TakeScreenShot(Status.Pass," UserName");
            exChildTest.Log(Status.Pass, "User", MediaEntityBuilder.CreateScreenCaptureFromPath(path + "filename1.png").Build());
           
            
            ButtonKey("{TAB}");
            EnetrTextAutoItX("khatri");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Sanoj@gamil.com");


            TakeScreenShot(Status.Pass, " Email");
            exChildTest.Log(Status.Pass, "Email", MediaEntityBuilder.CreateScreenCaptureFromPath(path + "filename2.png").Build());
           
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("0321232845743");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("22 april 2001");
            ButtonKey("{ENTER}");
            EnetrTextAutoItX("maths");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB 4}");
            EnetrTextAutoItX("Hyderabad Sindh");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Rajastan");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Noida");
            TakeScreenShot(Status.Pass, "City");
            exChildTest.Log(Status.Pass, "Enetr Password", MediaEntityBuilder.CreateScreenCaptureFromPath(path + "filename4.png").Build());
            ButtonKey("{ENTER}");
            QuitChrome();
        }
    }
}