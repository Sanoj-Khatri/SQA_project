using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.FormAutomate
{
    [TestClass]
    public  class FormB : Execution
    {
        [TestMethod]
        public void FormBAutomate() {
            OpenUrl("https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407");
            InitilizeInputSimulator();
            
            TabKeyISimulator();
            EnetrTextISimulator("SANOJ");
            TabKeyISimulator();

            EnetrTextISimulator("Khatri");
            TabKeyISimulator();

            EnetrTextISimulator("033232328237");
            TabKeyISimulator();

            EnetrTextISimulator("Pakistan");
            TabKeyISimulator();
            EnetrTextISimulator("Karachi");
            TabKeyISimulator();
            EnetrTextISimulator("sanoj@gmail.com");
            TabKeyISimulator();
            SpaceKeyISimulator();
            TabKeyISimulator();
            SpaceKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            SpaceKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            EnterKeyISimulator();
            EnetrTextISimulator("Afternoon");
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            EnterKeyISimulator();
           
            //TabKeyISimulator();
            //TabKeyISimulator();
            //EnterKeyISimulator();
           // EnterKeyISimulator();
            //TabKeyISimulator();
            //TabKeyISimulator();
            //TabKeyISimulator();
            //EnterKeyISimulator();
        }

        [TestMethod]
        public void FormBAutoItX() {
            OpenUrl("https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Sanoj");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Khatri");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("032563336252");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Pakistan");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Karachi");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("sanoj@gmail.com");
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB}");
            ButtonKey("{TAB}");
            ButtonKey("{ENTER}");
            EnetrTextAutoItX("Afternoon");
            ButtonKey("{TAB 5}");
            ButtonKey("{ENTER}");

            

        }
    }
}
