using FinalProject.Driver;
using FinalProject.Pages;

namespace FinalProject.Test
{
    public class Tests
    {
        LoginPage loginPage;
        InventoryPage inventoryPage;
        CartPage cartPage;
        CheckoutPage checkoutPage;
        InfoPage infoPage;
        
           
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            inventoryPage = new InventoryPage();
            cartPage = new CartPage();
            checkoutPage = new CheckoutPage();
            infoPage = new InfoPage();
          


        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]



        public void TC01_SortProductByPriceAndBuy3Cheapest_ShouldBeSortedLowPriceAnd3CheapestProductBought()

        {

            loginPage.Login("standard_user", "secret_sauce");
            inventoryPage.SelectOption("Price (low to high)");
            inventoryPage.Onesie.Click();
            inventoryPage.BikeLight.Click();
            inventoryPage.T_Shirt.Click();

            Assert.That("3", Is.EqualTo(inventoryPage.Cart.Text));




        }
        [Test]








        public void TC02_AddAndRemove2ProductsFromCart_2ProductsShouldBeAddedAndRemovedFromCart()
        {


            loginPage.Login("standard_user", "secret_sauce");
            inventoryPage.Backpack.Click();
            inventoryPage.BikeLight.Click();
            inventoryPage.Cart.Click();
            cartPage.RemoveBackPack.Click();
            cartPage.RemoveBikeLight.Click();
            cartPage.GoToInventoryPage.Click();


            Assert.That(cartPage.EmptyCart.Displayed);



        }

        [Test]




        public void TC03_CheckItemTotalValue_ShouldBeConfirmed()
        {
            loginPage.Login("standard_user", "secret_sauce");
            inventoryPage.BikeLight.Click();
            inventoryPage.Backpack.Click();
            inventoryPage.Cart.Click();
            cartPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Uros");
            infoPage.LastName.SendKeys("Zivadinovic");
            infoPage.Zip.SendKeys("11000");
            infoPage.ButtonContinue.Submit();

            Assert.That("Item total: $39.98", Is.EqualTo(checkoutPage.ItemTotal.Text));

        }

        [Test]

        public void TC04CheckTotalValue_ValueShouldBeConfirmed()

        {

            loginPage.Login("standard_user", "secret_sauce");
            inventoryPage.BikeLight.Click();
            inventoryPage.Backpack.Click();
            inventoryPage.Onesie.Click();
            inventoryPage.Cart.Click();
            infoPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Uros");
            infoPage.LastName.SendKeys("Zivadinovic");
            infoPage.Zip.SendKeys("11000");
            infoPage.ButtonContinue.Submit();

            Assert.That("Total: $51.81", Is.EqualTo(checkoutPage.Total.Text));

        }

        [Test]

        public void TC05_BuyProducts_ShoppingShouldBeFinished()
        {
            loginPage.Login("standard_user", "secret_sauce");


            inventoryPage.Onesie.Click();
            inventoryPage.BikeLight.Click();
            cartPage.ShoppingCartClick.Click();
            infoPage.Checkout.Click();
            infoPage.FirstName.SendKeys("Uros");
            infoPage.LastName.SendKeys("Zivadinovic");
            infoPage.Zip.SendKeys("11000");
            infoPage.ButtonContinue.Click();
            checkoutPage.ButtonFinish.Click();
            checkoutPage.OrderFinished.Click();


            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(checkoutPage.OrderFinished.Text));

        }

    }



}










