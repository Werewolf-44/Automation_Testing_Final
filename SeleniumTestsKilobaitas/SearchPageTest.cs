using NUnit.Framework;

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