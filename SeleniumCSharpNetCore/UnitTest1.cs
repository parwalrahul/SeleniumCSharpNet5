using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//div[@class='o-con'][normalize-space()='Celery']")).Click();
            Console.WriteLine("Setup 1");
            Assert.Pass();
        }
    }
}