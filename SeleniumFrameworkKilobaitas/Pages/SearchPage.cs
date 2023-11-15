using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.SqlServer.Server;

public class SearchPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
    public SearchPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
    public void SelectSearch()
    {
        var selectSearch = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
        selectSearch.Click();
    }
    public void EnterSearch()
    {
        string search = "Kompiuteris";
        var enterSearch = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
        enterSearch.SendKeys(search);
    }

    public void ClickSearch()
    {
        var clickSearch = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl39_searchBtn\"]"));
        clickSearch.Click();
    }

    public void ConfirmSearch()
    {
        IWebElement element = driver.FindElement(By.XPath("//*[@id=\"TopFilter\"]/dt/span[1]"));
        string actualText = element.Text;
        string expectedText = "PAIEŠKOS REZULTATAI \"KOMPIUTERIS\"";
        Assert.That(actualText, Is.EqualTo(expectedText));
    }
}
