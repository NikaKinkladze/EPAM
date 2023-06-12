using OpenQA.Selenium;

namespace MyFramework.Pages
{
    public class HomePage
    {
        private IWebDriver Webdriver;

        public HomePage(IWebDriver driver)
        {
            Webdriver = driver;
        }

        public void ClickSearchButton()
        {
            // Click on search button
            IWebElement searchButton = Webdriver.FindElement(By.CssSelector("[aria-label='Search']"));
            searchButton.Click();
        }
        public void EnterSearch(string Searchitem)
        {
            // Enter "Google Cloud Platform Pricing Calculator"
            IWebElement searchField = Webdriver.FindElement(By.CssSelector("input[name='q']"));
            searchField.SendKeys("Google Cloud Platform Pricing Calculator");
            searchField.SendKeys(Keys.Enter);
        }
        public void ClickCalculatorPage()
        {
            // Click on "Google Cloud Platform Pricing Calculator"
            IWebElement calculatorButton = Webdriver.FindElement(By.CssSelector("a.gs-title[href='https://cloud.google.com/products/calculator']"));
            calculatorButton.Click();
            Thread.Sleep(5000);
        }
    }
}
