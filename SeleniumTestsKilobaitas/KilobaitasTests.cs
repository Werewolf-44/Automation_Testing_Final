using NUnit.Framework;
using OpenQA.Selenium;


namespace KilobaitasTests
{
    [TestFixture]
    public class KilobaitasTests : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestLoginPage()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.OpenWebsite();
            loginPage.ClickLogInButton();

            loginPage.EnterUsername();
            loginPage.EnterPassword();
            loginPage.ClickLoginButtonAgain();

            // Add assertions or additional steps if needed
            IWebElement element = driver.FindElement(By.Id("ctl10_lblUdpSageMesageDetail"));
            string actualText = element.Text;
            string expectedText = "Prisijungta";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
    }
}
