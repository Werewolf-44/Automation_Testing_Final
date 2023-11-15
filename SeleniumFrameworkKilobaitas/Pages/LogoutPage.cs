using OpenQA.Selenium;
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

    public void ClickLogOutButton()
    {
        var loginButton = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl14_LogOut\"]/b"));
        loginButton.Click();
    }
}
