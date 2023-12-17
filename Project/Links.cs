using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;



namespace Selenium
{
    class Links
    {
        static void Main(string[] args)
            {
                // Replace with the actual path to your file containing links
                string filePath = "C:\\Users\\Muhammad Saad Sufyan\\OneDrive\\Desktop\\links.txt";

                // Read links from the file
                string[] links = System.IO.File.ReadAllLines(filePath);

                // Validate links
                ValidateLinks(links);
            }

            static void ValidateLinks(string[] links)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                IWebDriver driver = new ChromeDriver();

                foreach (string link in links)
                {
                    try
                    {
                        driver.Navigate().GoToUrl(link);
                        // Check if the page title contains "404" for broken links
                        if (!driver.Title.Contains("404"))
                        {
                            Console.WriteLine($"Link '{link}' is valid.");
                        }
                        else
                        {
                            Console.WriteLine($"Link '{link}' is broken.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Link '{link}' is broken. Error: {ex.Message}");
                    }
                }

                driver.Quit();
            }
    }
}
