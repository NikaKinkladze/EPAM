using OpenQA.Selenium;

namespace MyFramework.Pages
{
    public class EmailPage
    {
        private IWebDriver Webdriver;

        public EmailPage(IWebDriver driver)
        {
            Webdriver = driver;
        }

        public void GenerateEmail()
        {
            // Generating E-mail
            IWebElement generateEmail = Webdriver.FindElement(By.Id("login"));
            generateEmail.Click();
            generateEmail.SendKeys("epamtesting");
            generateEmail = Webdriver.FindElement(By.Id("refreshbut"));
            generateEmail.Click();
        }
        public void ClickOnRefreshButton()
        {
            IWebElement RefreshButton = Webdriver.FindElement(By.Id("refresh")); // Click on refresh button
            RefreshButton.Click();
        }
        public void ClickOnMail()
        {
            IWebElement email = Webdriver.FindElement(By.CssSelector("div.m:not([currentmail])"));
            var button = email.FindElement(By.CssSelector("button.lm"));
            button.Click();
        }
        public void SecondPrice()
        {
            IWebElement price2 = Webdriver.FindElement(By.Id("mailctn"));
            string price2Text = price2.Text;
            Assert.IsTrue(price2Text.Contains("4,024.56"));
            string price2Value = price2Text.Trim();
        }
        /*public void AssertPrices()
        {
            Assert.AreEqual(price1Value, price2Value);
        }*/
    }
}
