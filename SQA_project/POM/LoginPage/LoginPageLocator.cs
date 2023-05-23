using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.LoginPage
{
    public class LoginPageLocator
    {
        By txtUsername = By.Id("username");
        By txtPassword = By.Id("password");
        By btnLogin = By.Id("Login");
    }
}
