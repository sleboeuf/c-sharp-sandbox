using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3
{
    public class Driver
    {
        private IWebDriver driver;

        //Properties
        public int TimeOut 
        { get; set; }

        public int Retries
        { get; set; }

        public double Delay
        { get; set; }

        public int PageLoadTimeout
        { get; set; }
        
        //Constructors
        public Driver(string browser)
        {
            TimeOut = 90;
            Retries = 3;
            Delay = 0.3;
            PageLoadTimeout = 240;

            if( browser == "Chrome")
            {
                driver = new ChromeDriver();
            }


        }

        public Driver() : this("Chrome")
        {
        }

        //Methods

        public bool NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);

            return true;
        }

        public void CloseBrowser() 
        {
            driver.Close();
        }

    }
}
