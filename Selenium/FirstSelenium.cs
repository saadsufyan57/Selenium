using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    public class FirstSelenium
    {
        //settings global scope of all drivers instance name
        IWebDriver driver;
        IWebDriver driver1;
        IWebDriver driver2;


        [SetUp]
        public void StartBrowser()
        {
            //initializing all three browsers from library of drivers
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());



            driver = new ChromeDriver(); //depends of chromerdriver.exe
            driver1 = new FirefoxDriver(); //depends of geckodriver.exe
            driver2 = new EdgeDriver(); //depends on edgebrowser.exe



            driver.Manage().Window.Maximize();
            driver1.Manage().Window.Maximize();
            driver2.Manage().Window.Maximize();

        }

        [Test]

        public void Test3()
        {

            //open on chrome
            TestContext.Progress.Write("Test Started For Chrome");
            driver.Url = "https://knoccsapp-staging.azurewebsites.net/accounts/login";
            var title = driver.Title;
            TestContext.Progress.Write(title);
            TestContext.Progress.Write(driver.Url);
            //driver.Close();


            //open on firefox
            TestContext.Progress.Write("Test Started For FireFox");
            driver1.Url = "https://knoccsapp-staging.azurewebsites.net/accounts/login";
            var title1 = driver1.Title;
            TestContext.Progress.Write(title1);
            TestContext.Progress.Write(driver1.Url);
            //driver.Close();


            //open on edge
            TestContext.Progress.Write("Test Started for Edge");
            driver2.Url = "https://knoccsapp-staging.azurewebsites.net/accounts/login";
            var title2 = driver2.Title;
            TestContext.Progress.Write(title2);
            TestContext.Progress.Write(driver2.Url);
            //driver.Close();

        }

    }
}
