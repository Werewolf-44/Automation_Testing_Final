using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumFrameworkKilobaitas.Pages;

public class ProfilePage : BasePage
{
    public ProfilePage(IWebDriver driver) : base(driver) { }

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

    public void ConfirmContactInformation()
    {
        IWebElement name = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl19_FirstName\"]"));
        string actualName = name.GetAttribute("value");
        string expectedName = "Ernestas";
        Assert.That(actualName, Is.EqualTo(expectedName));

        IWebElement lastName = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl19_LastName\"]"));
        string actualLastName = lastName.GetAttribute("value");
        string expectedLastName = "Švedas";
        Assert.That(actualLastName, Is.EqualTo(expectedLastName));

        IWebElement email = driver.FindElement(By.XPath("//*[@id=\"lytA_ctl19_Email\"]"));
        string actuallEmail = email.GetAttribute("value");
        string expectedEmail = "ernestas.4test@gmail.com";
        Assert.That(actuallEmail, Is.EqualTo(expectedEmail));
    }
}