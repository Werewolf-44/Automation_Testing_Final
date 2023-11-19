using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsKilobaitas
{
    [TestFixture]
    public class CartPageTest : KilobaitasWebDriverFactory
    {
        [Test]
        public void TestCartPage()
        {
            LoginHelper loginHelper = new LoginHelper(driver);
            loginHelper.PerformLogin();

            CartPage cartPage = new CartPage(driver);
            cartPage.SelectSearch();
            cartPage.EnterSearch();
            cartPage.ClickSearch();
            cartPage.MouseOverItem();
            cartPage.AddCart();
            cartPage.MouseOverCart();
            cartPage.ClickBuy();
            cartPage.ConfirmCart();
            cartPage.DeleteCart();
        }
    }
}
