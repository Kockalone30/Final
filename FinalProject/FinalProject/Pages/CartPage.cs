using FinalProject.Driver;
using OpenQA.Selenium;

namespace FinalProject.Pages
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ShoppingCartClick => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_link"));
        public IWebElement RemoveBackPack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemoveBikeLight => driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        public IWebElement GoToInventoryPage => driver.FindElement(By.Id("continue-shopping"));
        public IWebElement EmptyCart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_link"));

        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));

    }
}
