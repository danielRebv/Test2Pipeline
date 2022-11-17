using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace SeleniumSample.Pages
{
    //HomePage
    public class HomePage
    {

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.XPath("//a[@id='loginLink']"));

        IWebElement lnkEmpoyeeDetails => Driver.FindElement(By.XPath("//a[normalize-space()='Employee Details']"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsEmployeeDetailsExist() => lnkEmpoyeeDetails.Displayed;



    }
}

