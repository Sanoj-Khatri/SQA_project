using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.FormAutomate
{
    [TestClass]
    public class form_AutoItX : Execution
    {
        [TestMethod]
        public void FormAutomateAutoItX() {


            OpenUrl("https://demoqa.com/automation-practice-form");
            ButtonKey("{TAB 2}");
            EnetrTextAutoItX("Sanoj");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("khatri");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Sanoj@gamil.com");
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("03212325483");
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
            ButtonKey("{ENTER}");


        }

        [TestMethod]
        public void Test() {
            //Test Case


                OpenUrl("https://demoqa.com/automation-practice-form");
                InitilizeInputSimulator();
                TabKeyISimulator();
                TabKeyISimulator();
                EnetrTextISimulator("SANOJ");
                TabKeyISimulator();
                EnetrTextISimulator("Khatri");
                TabKeyISimulator();
                EnetrTextISimulator("sanoj@gmail.com");
                TabKeyISimulator();
                SpaceKeyISimulator();
                TabKeyISimulator();
                EnetrTextISimulator("033501232832");
                TabKeyISimulator();
                EnetrTextISimulator("24 april 2001");
                EnterKeyISimulator();
                TabKeyISimulator();
                EnetrTextISimulator("maths");
                TabKeyISimulator();
                SpaceKeyISimulator();
                TabKeyISimulator();
                TabKeyISimulator();
                TabKeyISimulator();
                TabKeyISimulator();
                EnetrTextISimulator("Karachi City ");
                TabKeyISimulator();
                EnetrTextISimulator("Uttar");
                TabKeyISimulator();
                TabKeyISimulator();
                EnetrTextISimulator("Lucknow");
                TabKeyISimulator();
                EnterKeyISimulator();



            

        }
    }
}