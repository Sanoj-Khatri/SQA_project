using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{
    [TestClass]
    public class HomePageTC : HomePageLoctore
    {
        LoginPage loginPage = new LoginPage();

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                  @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]

        public void PageFliter() {

            string url = TestContext.DataRow["url"].ToString();
            string standarUsername = TestContext.DataRow["stndrUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            OpenUrl(url);
            loginPage.Login(standarUsername, password);

            Click(filter);
            Click(filter_az);
            Click(filter);
            Click(filter_za);
            Click(filter);
            Click(filter_high_low);
            Click(filter_low_high);

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Sanojgopi\source\repos\SQA_project\SQA_project\XMLFile1.xml", "Login", DataAccessMethod.Sequential)]
        public void Logout()
        {
            string url = TestContext.DataRow["url"].ToString();
            string standarUsername = TestContext.DataRow["stndrUsername"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            OpenUrl(url);
            loginPage.Login(standarUsername, password);
            Click(dropdown_btn);
            Click(logout);

        }


    }
}