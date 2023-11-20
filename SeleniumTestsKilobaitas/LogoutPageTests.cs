using NUnit.Framework;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class LogoutPageTests : KilobaitasWebDriverFactory
    {
        //Testing first way of logging out
        [Test]
        public void TestLogoutPage()
        {
            // Use LoginHelper to perform login before testing logout
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            // Now test the logout functionality
            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.ClickLogOutButton();
        }

        ////Testing second way of logging out
        [Test]
        public void TestLogoutPage_2()
        {
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.MouseOverProfile();
            logoutPage.ClickContactInformation();
            logoutPage.ClickLogOut();
        }
    }

}