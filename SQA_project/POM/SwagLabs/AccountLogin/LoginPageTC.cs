using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{
    [TestClass]
    
    public  class LoginPageTC : Execution
    {
        LoginPage loginPage = new LoginPage();
        public TestContext TestContext { get; set; }

        #region Standard_User
        [TestMethod]
    
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public  void ValidLoginStander() {
           
            string url = TestContext.DataRow["url"].ToString();
            string standarUsername = TestContext.DataRow["stndrUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            TestContext.Properties.Add("url", url);
            TestContext.Properties.Add("stndrUsername", standarUsername);
            TestContext.Properties.Add("password", password);

            OpenUrl(url);
            loginPage.Login(standarUsername, password);
            


        }
        #endregion


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void LockedUserLogin()

        {
            string url = TestContext.DataRow["url"].ToString();
            string lockedUsername = TestContext.DataRow["lockedUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            OpenUrl(url);
          
            loginPage.Login(lockedUsername,password);
           

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void ProblemUserLogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            string problemUsername = TestContext.DataRow["problemUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();
           
            OpenUrl(url);
            loginPage.Login(problemUsername,password);
          

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void PerformanceGlitchUserLogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            string perfromanceUsername = TestContext.DataRow["perfromanceUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            
            OpenUrl(url);
            loginPage.Login(perfromanceUsername,password);
          

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void EmptyUserLogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            OpenUrl(url);
            loginPage.Login(null, password);
            
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void EmptyPasswordLogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            string perfromanceUsername = TestContext.DataRow["perfromanceUsername"].ToString();
           

            OpenUrl(url);
            loginPage.Login(perfromanceUsername,null);
            

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void EmptyLogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            OpenUrl(url);
            loginPage.Login(null , null);
            
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void InvalidLogin()
        {
            
            string url = TestContext.DataRow["url"].ToString();
            string invalidUser = TestContext.DataRow["invalidUser"].ToString();
            string invalidPaswd = TestContext.DataRow["invalidPassword"].ToString();
            OpenUrl(url);
           
            loginPage.Login(invalidUser,invalidPaswd);
           

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void LoginUpperCase()
        {
            string url = TestContext.DataRow["url"].ToString();
            string userUpperCase = TestContext.DataRow["userUpperCase"].ToString();
            string password = TestContext.DataRow["password"].ToString();
          
            loginPage.Login(userUpperCase,password);
          

        }



    }
}
