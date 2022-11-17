using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSample.Source.Pages
{
    class Contact
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='elementor-element elementor-element-2537d859 elementor-nav-menu__align-right elementor-nav-menu--stretch elementor-nav-menu--dropdown-tablet elementor-nav-menu__text-align-aside elementor-nav-menu--toggle elementor-nav-menu--burger elementor-widget elementor-widget-nav-menu elementor-sticky']//ul[@id='menu-1-2537d859']//a[@class='elementor-item'][normalize-space()='CONTACTO']")]
        private IWebElement contact;

        [FindsBy(How = How.XPath, Using = "//input[@id='form-field-name']")]
        private IWebElement nameC;

        [FindsBy(How = How.XPath, Using = "//input[@id='form-field-email']")]
        private IWebElement emailC;

        [FindsBy(How = How.XPath, Using = "//input[@id='form-field-phone']")]
        private IWebElement telephoneC;

        [FindsBy(How = How.XPath, Using = "//input[@id='form-field-field_bb48715']")]
        private IWebElement countryC;

        [FindsBy(How = How.XPath, Using = "//input[@id='form-field-field_f8f7d61']")]
        private IWebElement companyC;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='form-field-message']")]
        private IWebElement commentsC;


        public Contact(IWebDriver drivers)
        {
            driver = drivers;
            PageFactory.InitElements(driver, this);

        }

        public void formContact(string name, string email, string telephone, string country, string compani, string comments)
        {
            nameC.SendKeys(name);
            emailC.SendKeys(email);
            telephoneC.SendKeys(telephone);
            countryC.SendKeys(country);
            companyC.SendKeys(compani);
            commentsC.SendKeys(comments);
        }
    }
}

