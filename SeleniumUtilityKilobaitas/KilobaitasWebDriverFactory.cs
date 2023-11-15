using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class KilobaitasWebDriverFactory
{
    protected IWebDriver driver;
    protected LoginHelper loginHelper;  // Change the variable name

    [SetUp]
    public void SetupTest()
    {
        driver = new ChromeDriver();
        loginHelper = new LoginHelper(driver);  // Change the variable assignment
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TeardownTest()
    {
        try
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                // Capture screenshot on test failure
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
            }
        }
        finally
        {
            // Close the browser, even if the test fails
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
