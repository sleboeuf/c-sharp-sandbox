using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3
{
    class NUnitExample
    {
        IWebDriver driver;
        Driver myDriver;

        [SetUp]
        public void startBrowser()
        {
            myDriver = new Driver();
            //driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            myDriver.NavigateToURL("http://www.facebook.com");
            //driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            myDriver.CloseBrowser();
            //driver.Close();
        }

    }
}
