using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
namespace SeleniumSample.Source.Pages
{
	public class HomePageG
	{
        private IWebDriver drivers;

        [FindsBy(How = How.XPath, Using = "//input[@title='Buscar']")]
        private IWebElement inputBusqueda;

        [FindsBy(How = How.XPath, Using = "//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']")]
        private IWebElement btnBusqueda;

        [FindsBy(How = How.XPath, Using = "//h3[normalize-space()='HOME - TSOFT - Make IT Real']")]
        private IWebElement FirstLink;

        [FindsBy(How = How.XPath, Using = "//div[@class='elementor-element elementor-element-2537d859 elementor-nav-menu__align-right elementor-nav-menu--stretch elementor-nav-menu--dropdown-tablet elementor-nav-menu__text-align-aside elementor-nav-menu--toggle elementor-nav-menu--burger elementor-widget elementor-widget-nav-menu elementor-sticky']//ul[@id='menu-1-2537d859']//a[@class='elementor-item'][normalize-space()='CONTACTO']")]
        private IWebElement btnContact;

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

        [FindsBy(How = How.XPath, Using = "//span[@role='alert']")]
        private IWebElement errorCont;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement summitC;

        public HomePageG(IWebDriver driver)
        {
            drivers = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Buscar(string searchtext)
        {
            inputBusqueda.SendKeys(searchtext);
            inputBusqueda.Submit();
            FirstLink.Click();
            btnContact.Click();
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

        public void confirmarF()
        {
            summitC.Click();
        }

        public string errorV()

        {
            string text = errorCont.Text;
            return text;
        }

        public void waitP()
        {
            WebDriverWait wait = new WebDriverWait(drivers, TimeSpan.FromSeconds(10));
            IWebElement esError = wait.Until(ExpectedConditions.ElementToBeClickable(errorCont));
        }


    }
}

