using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

public class LogoutPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LogoutPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
    // First way of logging out
    public void ClickLogOutButton()
    {
        var logoutButton = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl14_LogOut\"]/b"));
        logoutButton.Click();
    }
    // Second way of logging out
    public void MouseOverProfile()
    {
        Actions actions = new Actions(driver);
        var overProfile = driver.FindElement(By.XPath("//*[@id=\"sfHeadertop\"]/div[1]/div[1]/div[2]/div[1]/div/div/div[2]/div[3]/ul/li/a/b"));
        actions.MoveToElement(overProfile).Perform();
    }

    public void ClickContactInformation()
    {
        var contactInformation = driver.FindElement(By.XPath("//*[@id=\"sfHeadertop\"]/div[1]/div[1]/div[2]/div[1]/div/div/div[2]/div[3]/ul/li/ul/li[4]/a"));
        contactInformation.Click();
    }
    
    public void ClickLogOut()
    {
        var contactInformation = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl19_imgUserInfoSave\"]"));
        contactInformation.Click();
    }
}
