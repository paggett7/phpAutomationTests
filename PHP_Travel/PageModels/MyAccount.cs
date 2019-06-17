using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Travel.PageModels
{
    public class MyAccount : Setup.SetupDriver
    {
        public static void ChooseAccountOptions(string accountOption)
        {
            //driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='" + accountOption + "']")).Click();
            string manageAccount = accountOption.ToLower();
            switch (manageAccount)
            {
                case "order history and details":
                case "order":
                case "history":
                case "details":
                case "order history":
                    driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='Order history and details']")).Click();
                    Helpers.CheckPageDisplayed("ORDER HISTORY");
                    break;
                case "my credit slips":
                case "credit slips":
                case "credit":
                case "slips":
                    driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='My credit slips']")).Click();
                    Helpers.CheckPageDisplayed("CREDIT SLIPS");
                    break;
                case "my addresses":
                case "addresses":
                    driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='My addresses']")).Click();
                    Helpers.CheckPageDisplayed("MY ADDRESSES");
                    break;
                case "my personal information":
                case "personal information":
                case "information":
                case "personal":
                    driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='My personal information']")).Click();
                    //need to create a check for this one
                    break;
                case "my wishlists":
                case "wishlists":
                case "wish":
                    driver.FindElement(By.XPath(@"//body[@id='my-account']//span[text()='My wishlists']")).Click();
                    Helpers.CheckPageDisplayed("MY WISHLISTS");
                    break;
            }
        }
    }
}
