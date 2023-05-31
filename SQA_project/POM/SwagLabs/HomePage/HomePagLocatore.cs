using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{

    public class  HomePageLoctore : Execution

    {
        public  By dropdown_btn = By.Id("react-burger-menu-btn");
        public By all_Items = By.Id("inventory_sidebar_link");
        public By about =  By.Id("about_sidebar_link");
        public By logout = By.Id("logout_sidebar_link");
        public By reset =  By.Id("reset_sidebar_link");
        public By cross_btn = By.Id("react-burger-cross-btn");
        public By filter = By.ClassName("product_sort_container");
        public By filter_az = By.CssSelector("#header_container > div.header_secondary_container > div > span > select > option:nth-child(2)");
        public By filter_za = By.CssSelector("#header_container > div.header_secondary_container > div > span > select > option:nth-child(3)");
        public By filter_low_high = By.CssSelector("#header_container > div.header_secondary_container > div > span > select > option:nth-child(3)");
        public By filter_high_low = By.CssSelector("#header_container > div.header_secondary_container > div > span > select > option:nth-child(4)");
        
    }
}
