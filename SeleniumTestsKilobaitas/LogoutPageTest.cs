using NUnit.Framework;
namespace LogoutPageTest
{
    [TestFixture]
    public class LogoutPageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestLogoutPage()
        {
            // Use LoginHelper to perform login before testing logout
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            // Now test the logout functionality
            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.ClickLogOutButton();

            // Add assertions or additional steps if needed
        }
    }

}
