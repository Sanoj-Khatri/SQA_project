using AutoIt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.NotePad
{
    [TestClass]
    public  class Notepad 
    {
        [TestMethod]
        public void Notepad_AutoIT()
        {
            
            
            AutoItX.Run("notepad.exe", "");

            AutoItX.WinWaitActive("Untitled - Notepad");
            AutoItX.Send("I'm in SANOJ");
            AutoItX.WinWaitActive("*Untitled - Notepad");
            IntPtr winHandle = AutoItX.WinGetHandle("*Untitled - Notepad");
        }
    }
}
