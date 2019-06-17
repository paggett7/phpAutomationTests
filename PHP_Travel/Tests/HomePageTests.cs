using NUnit.Framework;
using OpenQA.Selenium;
using PHP_Travel.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PHP_Travel.Tests
{
    class HomePageTests : Setup.SetupDriver
    {
        [Test]
        public void Login()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            Thread.Sleep(5000);
        }
    }
}
