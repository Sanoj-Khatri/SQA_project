using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  SQA_project.POM
{
    [TestClass]
    public class Execution : BasePage
    {
        //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        static public IWebDriver driver;
        public IWebDriver radiobutn;
      

        public TestContext testContext;
        public TestContext TestContext
        {
            set { testContext = value; }
            get { return testContext; }
        }
        [AssemblyInitialize]
        public static void AssemblyIntitialize(TestContext testContext) {
            LogReport(testContext.TestName);
        }

        [AssemblyCleanup]
        public static void AssemblClean() {
            extentReports.Flush();
        }
        [ClassInitialize]
       
        public void ClassInitialize()
        {

        }
        [ClassCleanup]
        public static void ClassCleanup() { }


        [TestInitialize]
        public void TestInitialize()
        {
            InitilizeChrome();
            //driver = new ChromeDriver();
            //driver = new EdgeDriver();
            //  driver.Url = "https://adactinhotelapp.com/";
            ////   driver.Url = "";
            //driver.Manage().Window.Maximize();
            //    Assert.AreEqual("", driver.Title(""));
           
        }
        [TestCleanup]
        public  void TestCleanup() {
          // QuitChrome();
        } 

    }
}
