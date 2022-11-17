using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using OpenQA.Selenium.Chrome;
using SeleniumSample.Source.Pages;

namespace SeleniumSample.Test
{
    public class SearchTsoft


    {
        IWebDriver driver;

        [SetUp]
        public void initScrip()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }



        [Test]
        public void BuscarTsoft()
        {
            HomePageG hp = new HomePageG(driver);
            driver.Navigate().GoToUrl("https://www.google.com");
            hp.Buscar("Tsoft");
            hp.formContact("Daniel", "Hola@gmail.com", "+56966238582", "Chile", "Tsoft", "Esto es una prueba");
            hp.confirmarF();
            hp.waitP();
            Console.WriteLine(hp.errorV());
            Assert.AreEqual("The Captcha field cannot be blank. Please enter a value.", hp.errorV());
        }



        [TearDown]
        public void Cleanup() => driver.Quit();

    }
}

