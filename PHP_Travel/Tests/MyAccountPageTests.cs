using NUnit.Framework;
using PHP_Travel.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PHP_Travel.Tests
{
    class MyAccountPageTests : Setup.SetupDriver
    {
        [Test]
        public void LaunchOrderHistory()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            MyAccount.ChooseAccountOptions("Order");
            Thread.Sleep(5000);
        }

        [Test]
        public void LaunchCreditSlips()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            MyAccount.ChooseAccountOptions("Credit");
            Thread.Sleep(5000);
        }

        [Test]
        public void LaunchAddresses()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            MyAccount.ChooseAccountOptions("addresses");
            Thread.Sleep(5000);
        }

        [Test]
        public void LaunchPersonalInformation()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            MyAccount.ChooseAccountOptions("information");
            Thread.Sleep(5000);
        }

        [Test]
        public void LaunchWishlist()
        {
            LogonPage.Login("jp.automationuser@gmail.com", "Testing!@#");
            MyAccount.ChooseAccountOptions("wish");
            Thread.Sleep(5000);
        }
    }
}
