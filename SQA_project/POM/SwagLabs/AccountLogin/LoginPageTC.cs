using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{
    [TestClass]
    public partial class LoginPageTC : Execution
    {
        LoginPage loginPage = new LoginPage();
        [TestMethod]
        public void ValidLoginStander() {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "standard_user";
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();


        }
        [TestMethod]
        public void LockedUserLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "locked_out_user";
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();

        }
        [TestMethod]
        public void ProblemUserLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "problem_user";
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();

        }
        [TestMethod]
        public void PerformanceGlitchUserLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "performance_glitch_user";
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();

        }
        [TestMethod]
        public void EmptyUserLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = null;
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();

        }

        [TestMethod]
        public void EmptyPasswordLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "standard_user";
            loginPage.password = null;
            loginPage.Login();
            QuitChrome();

        }
        [TestMethod]
        public void EmptyLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = null;
            loginPage.password = null;
            loginPage.Login();
            QuitChrome();

        }

        [TestMethod]
        public void InvalidLogin()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "standard";
            loginPage.password = "122113212";
            loginPage.Login();
            QuitChrome();

        }
        [TestMethod]
        public void LoginUpperCase()
        {
            OpenUrl("https://www.saucedemo.com/");
            loginPage.username = "STANDARD_USER";
            loginPage.password = "secret_sauce";
            loginPage.Login();
            QuitChrome();

        }



    }
}
