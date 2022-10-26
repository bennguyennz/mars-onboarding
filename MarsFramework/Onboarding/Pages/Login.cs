using Onboarding.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Onboarding.Utilities.CommonDriver;
using static Onboarding.Utilities.GlobalDefinitions;

namespace Onboarding.Pages
{
    class Login
    {
        #region Page objects
        private IWebElement SignInBtn => driver.FindElement(By.XPath("//a[@class='item']"));
        private IWebElement Email => driver.FindElement(By.Name("email"));
        private IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        #endregion

        public void LogInSteps()
        {
            //Populate excel data
            ExcelLib.PopulateInCollection(ExcelPath, "SignIn");

            //Click Signin button
            SignInBtn.Click();

            //Enter email
            Email.SendKeys(ExcelLib.ReadData(2, "Username"));

            //Enter password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Click Login button
            LoginBtn.Click();

            //This Thread.Sleep is for viewing successful login only. It can be deleted.
            Thread.Sleep(3);
        }
    }
}
