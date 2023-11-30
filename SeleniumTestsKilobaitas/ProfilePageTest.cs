using NUnit.Framework;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class ProfilePageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestProfilePage()
        {
            string expectedName = "Ernestas";
            string expectedLastName = "Švedas";
            string expectedEmail = "ernestas.4test@gmail.com";

            // Use LoginHelper to perform login before testing logout
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            // Now test the profile functionality
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.MouseOverProfile();
            profilePage.ClickContactInformation();

            Assert.That(profilePage.GetName(), Is.EqualTo(expectedName));
            Assert.That(profilePage.GetLastName(), Is.EqualTo(expectedLastName));
            Assert.That(profilePage.GetEmail(), Is.EqualTo(expectedEmail));
        }
    }

}