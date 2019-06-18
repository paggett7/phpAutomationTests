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

        public class MenuToolbar
        {
            public static void Women()
            {
                driver.FindElement(By.XPath("//a[@title='Women']")).Click();
            }

            public static void Dresses()
            {

                driver.FindElements(By.XPath("//a[@title='Dresses' and @class='sf-with-ul']")).Last().Click();
            }

            public static void TShirts()
            {

                driver.FindElement(By.XPath("//li[@class='']//a[ @title='T-shirts']")).Click();
            }
        }
    }
}
