using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.HotelPage
{
    [TestClass]
    public  class RegistrerUser : Execution
    {

      


        //AutoIt
        [TestMethod]
        public void RegisterNewUser() {

            OpenUrl("https://adactinhotelapp.com/");
            ButtonKey("{TAB 7}");
            ButtonKey("{ENTER}");
            ThreadSleepWait(3);
            ButtonKey("{TAB 2}");
            EnetrTextAutoItX("sandaskha");

            ButtonKey("{TAB}");
            EnetrTextAutoItX("12365444");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("12365444");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("Sanoj Das ");
            ButtonKey("{TAB}");
            EnetrTextAutoItX("sanoj@gmail.com");
            ButtonKey("{TAB}");
            ThreadSleepWait(10);
            ButtonKey("{TAB}");
            ButtonKey("{SPACE}");
            ButtonKey("{TAB 2}");
            ButtonKey("{SPACE}");
            Screenshot();


        }

        //InputSimulator 
        [TestMethod]
        public void RegistrationFormISim()
        {
            OpenUrl("https://adactinhotelapp.com/");
            InitilizeInputSimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            TabKeyISimulator();
            EnterKeyISimulator();
            ThreadSleepWait(2);
            TabKeyISimulator();
            TabKeyISimulator();
            EnetrTextISimulator("Sanojdaskha");
            TabKeyISimulator();
            EnetrTextISimulator("12234546");
            TabKeyISimulator();
            EnetrTextISimulator("12234546");
            TabKeyISimulator();
            EnetrTextISimulator("Sanoj Das khatri");
            TabKeyISimulator();
            EnetrTextISimulator("sanojsa@gmail.com");
            TabKeyISimulator();
            ThreadSleepWait(10);
            TabKeyISimulator();
            SpaceKeyISimulator();
            TabKeyISimulator(); 
            TabKeyISimulator();
            EnterKeyISimulator();
            Screenshot();






        }


    }
}
