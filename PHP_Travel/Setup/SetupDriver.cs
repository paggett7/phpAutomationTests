using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Travel.Setup
{
    public class SetupDriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver(@"C:\ChromeDriver\74");
            driver.Url = "http://automationpractice.com";
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
