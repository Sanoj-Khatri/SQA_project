using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{
    [TestClass]
    public class HomePageMethod : Execution
    {


        //LoginPage login = new LoginPage();
           
        [TestMethod]
      
        public   void HomePageTC() {
            LoginPageTC loginll = new LoginPageTC();
            loginll.ValidLoginStander();
           
        }

    }
}