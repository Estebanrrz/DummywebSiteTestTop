using Framework;
using System.Globalization;

namespace DummyWebSiteTests
{
    [TestClass]
    public class SortTests : BaseTests
    {

        [TestMethod]
        public void VerifyItemsOnInventoryAreSortedCorrectly()
        {
            // Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.TypeUsername(User);
            loginPage.TypePassword(Password);
            loginPage.ClickLoginButton();
            Assert.IsTrue(Driver.Url.Contains("inventory"));
            InventoryPage inventoryPage = new InventoryPage(Driver);
            List<string> current = inventoryPage.GetItemNames();
            Assert.IsTrue(current.SequenceEqual(current.OrderBy(x => x)), "The Items names are not ordered ascending");
            inventoryPage.SelectSortOrderByNameZtoAInventory();
            List<string> current2 = inventoryPage.GetItemNames();
            Assert.IsTrue(current2.SequenceEqual(current2.OrderByDescending(x => x)), "The Items names are not ordered descending");
        }
    }
}
