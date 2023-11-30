using OpenQA.Selenium;
using SeleniumFrameworkKilobaitas.Pages;

public class ProfilePage : BasePage
{
    public ProfilePage(IWebDriver driver) : base(driver) { }

    By profile = By.XPath("//*[@id=\"sfHeadertop\"]/div[1]/div[1]/div[2]/div[1]/div/div/div[2]/div[3]/ul/li/a/b");
    By contactInformation = By.XPath("//*[@id=\"sfHeadertop\"]/div[1]/div[1]/div[2]/div[1]/div/div/div[2]/div[3]/ul/li/ul/li[4]/a");
    By name = By.XPath("//*[@id=\"lytA_ctl19_FirstName\"]");
    By lastName = By.XPath("//*[@id=\"lytA_ctl19_LastName\"]");
    By email = By.XPath("//*[@id=\"lytA_ctl19_Email\"]");

    public void MouseOverProfile()
    {
        common.MoveMouseToElement(profile);
    }

    public void ClickContactInformation()
    {
        common.ClickElement(contactInformation);
    }

    public string GetName()
    {
        return common.GetAttribute(name, "value");
    }

    public string GetLastName()
    {
        return common.GetAttribute(lastName, "value");
    }

    public string GetEmail()
    {
        return common.GetAttribute(email, "value");
    }
}