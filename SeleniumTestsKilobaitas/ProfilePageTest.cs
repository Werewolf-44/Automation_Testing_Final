using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class ProfilePageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestProfilePage()
        {
            // Use LoginHelper to perform login before testing logout
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            // Now test the profile functionality
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.MouseOverProfile();
            profilePage.ClickContactInformation();
            profilePage.ConfirmContactInformation();
        }
    }

}
