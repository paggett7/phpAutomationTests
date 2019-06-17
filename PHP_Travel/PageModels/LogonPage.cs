using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PHP_Travel.PageModels
{
    public class LogonPage : Setup.SetupDriver
    {
        public static void Login(string email, string password)
        {
            driver.FindElement(By.CssSelector(".login")).Click();
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("passwd")).SendKeys(password);
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }
    }
}
