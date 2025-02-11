using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class TestChrome
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Standard web driver instance
            IWebDriver browser = new ChromeDriver();
            //IWebDriver browser = new FirefoxDriver();
            //IWebDriver browser = new EdgeDriver();

            //Set implicit wait
            browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            browser.Url = "http://www.google.com";

            //Find the Search text box UI Element
            IWebElement element = browser.FindElement(By.Name("q"));
      

            //Search
            element.SendKeys("books");

            // this sends an Enter to the element
            element.SendKeys(Keys.Enter);

            //Wait for page to load
            //System.Threading.Thread.Sleep(5 * 1000); //Wait 5-sec
            new WebDriverWait(browser, TimeSpan.FromSeconds(5)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            //Test if main page displayed
            element = browser.FindElement(By.Id("main"));

            //check the page title
            var pageTitle = browser.Title;

            //Read #images on the page
            var listImages = browser.FindElements(By.TagName("img"));

            //call quit, instead of close
            browser.Quit();

            //Print #Images to Debug output window
            Debug.Write("Chrome #Images = ");
            Debug.WriteLine(listImages.Count);


        }
    }
}
