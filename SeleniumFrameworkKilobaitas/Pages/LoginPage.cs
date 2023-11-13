﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;
    readonly string username = "ernestas.4test@gmail.com";
    readonly string password = "Testavimas44,,";


    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    public void OpenWebsite()
    {
        driver.Navigate().GoToUrl("https://www.kilobaitas.lt");
    }

    public void ClickLogInButton()
    {
        var loginButton = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl08_LogIn\"]/b"));
        loginButton.Click();
        Thread.Sleep(1000);
    }
    public void EnterUsername()
    {
        var enterUsername = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl08_UserName\"]"));
        enterUsername.SendKeys(username);
    }

    public void EnterPassword()
    {
        var enterPassword = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl08_Password\"]"));
        enterPassword.SendKeys(password);
    }

    public void ClickLoginButtonAgain()
    {
        var loginButtonAgain = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl08_LoginButton\"]"));
        loginButtonAgain.Click();
    }
}