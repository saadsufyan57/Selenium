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
    class FunctionalTesting
    {
        IWebDriver driver;
        [SetUp] 
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = ("https://knoccsapp-staging.azurewebsites.net/accounts/login");

        }

        [Test]

        public void dropdown()
        {
            driver.FindElement(By.CssSelector("input[id=Email]")).SendKeys("saadsufyan57@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("User@123");
            driver.FindElement(By.CssSelector("button[type=submit")).Click();


            driver.FindElement(By.XPath("//div[@class='kncs-header-options']/ul/li[3]/div/a")).Click();

            driver.FindElement(By.XPath("//button[@data-target='#firstModal']")).Click();

            //IWebElement dropdown = driver.FindElement(By.XPath("//app-company-create/div/div/div/div[2]/div/div/form/div/div[6]/mat-form-field/div/div/div/mat-select/div"));
            //IWebElement dropdown = driver.FindElement(By.ClassName("ng-tns-c119-138"));

            driver.FindElement(By.XPath("//app-company-create/div/div/div/div[2]/div/div/form/div/div[6]/mat-form-field/div/div/div/mat-select/div")).Click();
            driver.FindElement(By.XPath("//mat-option[2]")).Click();
            //SelectElement s = new SelectElement(dropdown);
            //s.SelectByIndex(2);









        }
    }
}


