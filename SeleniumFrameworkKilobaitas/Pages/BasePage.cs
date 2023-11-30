using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace SeleniumFrameworkKilobaitas.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
