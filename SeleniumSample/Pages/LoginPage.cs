using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace SeleniumSample.Pages
{

    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement txtUsername => Driver.FindElement(By.XPath("//input[@id='UserName']"));

        IWebElement txtPassowrd => Driver.FindElement(By.XPath("//input[@id='Password']"));

        IWebElement txtLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPassowrd.SendKeys(password);
            txtLogin.Submit();
        }
    }
}

