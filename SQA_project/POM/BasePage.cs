using AutoIt;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace SQA_project.POM
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static InputSimulator Isimulator;
        public void InitilizeChrome() {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void InitilizeInputSimulator() { 
        Isimulator = new InputSimulator();
        }

        #region InputSimulator Methods
        public void TabKeyISimulator()
        {
            Isimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
        }
        public void EnterKeyISimulator()
        {
            Isimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
        public void SpaceKeyISimulator()
        {
            Isimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
        }

        public void EnetrTextISimulator(string txt)
        {
            Isimulator.Keyboard.TextEntry(txt);
        }
        #endregion


        public void EnterText(By by, string value) 
        {

            try
            {
                driver.FindElement(by).SendKeys(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Elemnt not Find" + ex.Message);
            }


        }
        public void Click(By by) 
        {
            driver.FindElement(by).Click(); 
        }
        public static void ThreadSleepWait(int second) {
            Thread.Sleep(second * 1000);
        }
        public void OpenUrl(string url) {
            driver.Url = url;
        }

        public string GetElementText(By by) {
            string text;
             try { text = driver.FindElement(by).Text; }
            catch
            {
                try { text = driver.FindElement(by).GetAttribute("value"); }
                catch { text = driver.FindElement(by).GetAttribute("innerHTML"); }
                
            }
            return text;

        }
        public String GetElementState(By by) {
            String elemnetState = driver.FindElement(by).GetAttribute("Disable");
            if (elemnetState == null) { elemnetState = "enabled"; }
            else if (elemnetState == "true") { 
            elemnetState = "disabled";
            }

            return elemnetState;
        }
        public static String ExcuteJavaScipt(String javascriptCode) {
            string value = null;
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                value = (string)js.ExecuteScript(javascriptCode);
            }
            catch(Exception) { 
            
            }

            return value;
        
        }
        public void RadioButton(By by) {
            
            driver.FindElement(by).Click();
        }

        // Verify the CheckBox Method 
        public void CheckBox(By by) {
            bool _checked;
            driver.FindElement(by).Click();
            IWebElement element = driver.FindElement(by);
            _checked = element.Selected;
            if (_checked == true)
            {
                element.Click();
            }
            else {

            }
        }
        #region AutoItX
        public void ButtonKey(string keyname)
        {
            AutoItX.Send(keyname);
        }
        public void EnetrTextAutoItX(string name)
        {
            AutoItX.Send(name);

        }
        public void SleepAutoItX(int sec)
        {
            Thread.Sleep(sec * 1000);
        }
        #endregion
        public void Screenshot()
        {
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHMMSS");
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@"screenshot_" + currentDateTime + ".png", ScreenshotImageFormat.Png);
        }

        public void ClickIJava(By by ) {
            var btn_element = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", btn_element);
        }

        public void QuitChrome() { 
        driver.Quit();
        }
        //Extent Report
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;
        public static void LogReport(string testcase) {
            extentReports = new ExtentReports();
            dirpath = @"C:\TestExecutionReports\"+ testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extentReports.AttachReporter(htmlReporter);

        }
        public static void TakeScreenShot(Status status, string stepDetail)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string screenshotPath = Path.Combine(dirpath, "Screenshots");
            Directory.CreateDirectory(screenshotPath);
            string screenshotFile = Path.Combine(screenshotPath, $"{DateTime.Now:yyyyMMddHHmmssfff}.png");
            screenshot.SaveAsFile(screenshotFile, ScreenshotImageFormat.Png);

            exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotFile).Build());
        }

        //Auto IT

    }
}
/*
 * Capture SS
 * Click using JS 
 * Enter Text using JS
 * implicit Wait 
 * ScrollUp 
 * Scroll Down
 * Scroll To Element 
 * Drop Down 
 * Radio Button 
 * Check Box(if disable/endable)
 * iframe 
 * IAlert (3types)
 * Window handle(New window, New Tab)
 * Asseration (Maximum)
 * Read CSV
 * Read XML 
 * Multiplr Broswers

        //Click using JS
        //Enter Test using JS
        //Implicit Wait
        //Scroll Down
        //Scroll Up
        //Scroll to Element
        //Drop Down 
        //Radio Button
        //Check Box (if disabled/enabled)
        //iframes
        //IAlerts (All 3 Types)
        //Window Handle (New Window, New Tab)
        //Assertion (Maximum)
        //Read CSV
        //Read XML
        //Multiple Browsers
        //Browser Options
*/


/*
 * /txt -> text box
//btn -> button
//cb -> combo box
//chk -> check box
//rd -> radio btn
//lbl -> Label
//msg -> message
//grd -> grid
//tgbtn -> toggle button
//dt -> date time
//df -> date field
//Menu -> Menu (Map)
//ddl -> drop down list

For Alerts
//btnAlertOk
//btnAlertClose
//msgAlert*/