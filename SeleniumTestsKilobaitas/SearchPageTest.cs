using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class SearchPageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestSearchPage()
        {
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            SearchPage searchPage = new SearchPage(driver);
            searchPage.SelectSearch();
            searchPage.EnterSearch();
            searchPage.ClickSearch();
            searchPage.ConfirmSearch();
        }
    }
}
