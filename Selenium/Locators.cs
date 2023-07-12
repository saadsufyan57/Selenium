using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    public class Locators
    {

        IWebDriver driver;

        [SetUp] 
        public void SetUp() 
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //implicit wait for 5 seconds if an element does not found
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://knoccsapp-staging.azurewebsites.net/accounts/login";

        }

        [Test]

        public void Login()
        {
            TestContext.Progress.WriteLine("Test has been started");

            driver.FindElement(By.CssSelector("input[id=Email]")).SendKeys("saadsufyan57@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("User@1234");
            driver.FindElement(By.CssSelector("button[type=submit")).Click();



            //Thread.Sleep(2000);
            String errorMessage = driver.FindElement(By.ClassName("loginError")).Text;
            TestContext.Progress.WriteLine(errorMessage);

            //explicit wait - to wait for explicitly for a specific component
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementToBeClickable(driver.FindElement(By.CssSelector("button[type=submit"))));

            //IWebElement dashboardUrl = driver.FindElement(By.XPath("//div[@class='kncs-header-options']/ul/li/div/a"));

            //String dUrl = dashboardUrl.GetAttribute("href");
            //String expectedDashboarURL = "https://knoccsapp-staging.azurewebsites.net/dashboard";

            //Assert.AreEqual(expectedDashboarURL, dUrl);
            //TestContext.Progress.WriteLine(dUrl);
            driver.Quit();
        }

    }
}
