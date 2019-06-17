using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Travel
{
    public class Helpers : Setup.SetupDriver
    {
        public static void CheckPageDisplayed(string pageTitle)
        {
            var page = driver.FindElement(By.CssSelector("h1.page-heading")).Text;

            Assert.IsTrue(page == pageTitle);
        }
    }
}
