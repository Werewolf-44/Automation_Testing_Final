using OpenQA.Selenium;

namespace SeleniumFrameworkKilobaitas.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected Common common;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.common = new Common(driver);
        }
    }
}
