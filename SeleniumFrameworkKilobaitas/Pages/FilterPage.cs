using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Threading;

public class FilterPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public FilterPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    public void MouseOverSelection()
    {
        Actions actions = new Actions(driver);
        var overSelection = driver.FindElement(By.XPath("//*[@id=\"sm_megamenu_74\"]/span/span"));
        actions.MoveToElement(overSelection).Perform();
    }

    public void ClickSelection()
    {
        var clickSelection = driver.FindElement(By.XPath("//*[@id=\"sm_megamenu_menu55b0495451152\"]/div[1]/ul/li/div/div/table/tbody/tr/td[1]/div[2]/div[1]/a"));
        clickSelection.Click();
    }

    public void ClickRecommended()
    {
        var clickRecommended = driver.FindElement(By.XPath("//*[@id=\"TopFilter\"]/ol/dd[1]/li/a/span[1]"));
        clickRecommended.Click();
        Thread.Sleep(2000);
    }

    public void ConfirmFilters()
    {
        IWebElement attribute = driver.FindElement(By.XPath("//*[@id=\"layered-navigation\"]/div/div[2]/ol/li[1]/span[2]"));
        string actualAttribute = attribute.Text;
        string expectedAttribute = "Rekomenduojame";
        Assert.That(actualAttribute, Is.EqualTo(expectedAttribute));

        IWebElement manufacturer = driver.FindElement(By.XPath("//*[@id=\"layered-navigation\"]/div/div[2]/ol/li[2]/span[2]"));
        string actualManufacturer = manufacturer.Text;
        string expectedManufacturer = "KILOBAITAS";
        Assert.That(actualManufacturer, Is.EqualTo(expectedManufacturer));
    }
}