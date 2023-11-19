using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class FilterPageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestFilterPage()
        {
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            FilterPage filterPage = new FilterPage(driver);
            filterPage.MouseOverSelection();
            filterPage.ClickSelection();
            filterPage.ClickRecommended();
            filterPage.ConfirmFilters();
        }
    }
}
