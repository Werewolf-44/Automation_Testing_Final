using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;

namespace SeleniumFrameworkKilobaitas
{
    public class Common
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        internal Common(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement GetElement(By locator)
        {
            return driver.FindElement(locator);
        }

        internal void MoveMouseToElement(By locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }

        internal void ClickElement(By locator)
        {
            GetElement(locator).Click();
        }

        internal string GetAttribute(By locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }
    }
}
