using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Inventory Page on POM
    /// </summary>
    public class InventoryPage : BasePage
    {
        public InventoryPage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string XPATH_ITEM_BY_NAME_PARTIAL = "//div[contains(@class,'inventory_item_name')][contains(text(),'{0}')]/ancestor::div[@class='inventory_item']";
        private const string XPATH_ADD_TO_CART_BUTTON = ".//button[contains(@class,'btn_inventory')]";
        private const string XPATH_SHOPPING_CART_BUTTON = "//a[contains(@class,'shopping_cart_link')]";
        private const string XPATH_COUNT_SHOPPING_CART = "//div[@id='shopping_cart_container']/a/span";
        private const string XPATH_ITEM_PRICE = ".//div[@class='inventory_item_price']";
        private const string XPATH_SORT_DROPDOWN = "//*[@class='product_sort_container']";
        private const string XPATH_SORT_ZA_OPTION = "//option[@value='za']";
        private const string XPATH_ITEM_NAME_GENERIC = "//div[contains(@class,'inventory_item_name')]";
        #endregion
        #region Methods
        public void ClickShoppingCartButton() => Driver.FindElement(By.XPath(XPATH_SHOPPING_CART_BUTTON)).Click();
        public string GetNumberOfItemsOnShoppingCart() => Driver.FindElement(By.XPath(XPATH_COUNT_SHOPPING_CART)).Text;

        /// <summary>
        /// Get all the items names on the page
        /// </summary>
        /// <returns>List<string> with the names</returns>
        public List<string> GetItemNames()
        {
            var itemNames = new List<string>();
            var items = Driver.FindElements(By.XPath(XPATH_ITEM_NAME_GENERIC));
            foreach (var item in items)
            {
                itemNames.Add(item.Text);
            }
            return itemNames;
        }
        /// <summary>
        ///  Select Sort Order by Name A to Z
        /// </summary>
        public void SelectSortOrderByNameZtoAInventory()
        {
            Driver.FindElement(By.XPath(XPATH_SORT_DROPDOWN)).Click();
            Driver.FindElement(By.XPath(XPATH_SORT_ZA_OPTION)).Click();
        }
        /// <summary>
        /// Add Item to Cart by Item Name
        /// </summary>
        /// <param name="itemName">Item to add to the cart</param>
        public void AddItemToCart(string itemName)
        {
            var item = Driver.FindElement(By.XPath(string.Format(XPATH_ITEM_BY_NAME_PARTIAL, itemName)));
            item.FindElement(By.XPath(XPATH_ADD_TO_CART_BUTTON)).Click();
        }

        /// <summary>
        /// Get Item Price by Item Name
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public string GetItemPrice(string itemName)
        {
            var item = Driver.FindElement(By.XPath(string.Format(XPATH_ITEM_BY_NAME_PARTIAL, itemName)));
            return item.FindElement(By.XPath(XPATH_ITEM_PRICE)).Text;
        }

        /// <summary>
        /// Get Number of items added to the cart 
        /// </summary>
        /// <returns></returns>
        public string GetNumberOfItemsInCart()
        {
            return Driver.FindElement(By.XPath(XPATH_COUNT_SHOPPING_CART)).Text;
        }
        #endregion
    }
}
