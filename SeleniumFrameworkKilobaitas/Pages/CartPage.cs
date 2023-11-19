using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

public class CartPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public CartPage(IWebDriver driver)
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
        string search = "Programa biurui Microsoft 365 Personal";
        var enterSearch = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
        enterSearch.SendKeys(search);
    }

    public void ClickSearch()
    {
        var clickSearch = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl39_searchBtn\"]"));
        clickSearch.Click();
    }

    public void MouseOverItem()
    {
        Actions actions = new Actions(driver);
        var overItem = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl44_UpdatePanel\"]/div[2]/div[2]/div/div"));
        actions.MoveToElement(overItem).Perform();
    }

    public void AddCart()
    {
        var addCart = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl44_UpdatePanel\"]/div[2]/div[2]/div/div/div[4]/button/span"));
        addCart.Click();
    }

    public void MouseOverCart()
    {
        Actions actions = new Actions(driver);
        var overCart = driver.FindElement(By.XPath("//*[@id=\"cartRound\"]"));
        actions.MoveToElement(overCart).Perform();
    }

    public void ClickBuy()
    {
        var clickBuy = driver.FindElement(By.XPath("//*[@id=\"priceLabel\"]/button"));
        clickBuy.Click();
    }
    
    public void ConfirmCart()
    {
        IWebElement element = driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody/tr/td[2]/span[2]"));
        string actualText = element.Text;
        string expectedText = "QQ2-00012";
        Assert.That(actualText, Is.EqualTo(expectedText));
    }

    public void DeleteCart()
    {
        var deleteCart = driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody/tr/td[6]/a[1]/i"));
        deleteCart.Click();

        // Switch to the alert dialog
        IAlert alert = driver.SwitchTo().Alert();

        // Accept the alert (click "OK")
        alert.Accept();
    }
}
