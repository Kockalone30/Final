using FinalProject.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinalProject.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ItemTotal => driver.FindElement(By.ClassName("summary_subtotal_label"));
        public IWebElement Total => driver.FindElement(By.ClassName("summary_total_label"));

        public IWebElement ButtonFinish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));


        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(ItemTotal);
            element.SelectByText(text);
            SelectElement element1 = new SelectElement(Total);
            element1.SelectByText(text);
            SelectElement element2 = new SelectElement(OrderFinished);
            element2.SelectByText(text);
        }

    }
}
