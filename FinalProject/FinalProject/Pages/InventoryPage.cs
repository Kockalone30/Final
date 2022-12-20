using FinalProject.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinalProject.Pages
{
    public class InventoryPage
    {
        private IWebDriver driver = WebDrivers.Instance;



        public IWebElement Onesie => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement T_Shirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Backpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));

        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_link"));



        public string ProductUrL = ("https://www.saucedemo.com/inventory.html");

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
    }
}
