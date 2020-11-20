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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            Driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//div[@class='o-con'][normalize-space()='Celery']")).Click();
            Console.WriteLine("Sample Test Message to test the Git Commit Feature");
            Assert.Pass();
        }
    }
}