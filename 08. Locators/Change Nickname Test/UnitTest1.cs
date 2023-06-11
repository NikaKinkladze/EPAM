using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Change_Nickname_Test
{
    public class Tests
    {
        private WebDriver WebDriver { get; set; } = null;
        private string DriverPath { get; set; } = @"C:\Users\qinql\OneDrive\Desktop\chromedriver";
        private string BaseUrl1 { get; set; } = "https://proton.me/";
        private string BaseUrl2 { get; set; } = "https://www.yahoo.com/";

        private WebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();

            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }

        [SetUp]
        public void Setup()
        {
            WebDriver = GetChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }

        [Test]
        public void Test1()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl1);

            // Navigate and click on Sign in button
            IWebElement element = WebDriver.FindElement(By.XPath("//a[contains(@href, 'https://account.proton.me/login')]"));
            element.Click();

            // Log in to first E-mail
            var mailinput = WebDriver.FindElement(By.Id("username"));
            mailinput.SendKeys("testsepam@proton.me");
            var passwordinput = WebDriver.FindElement(By.Id("password"));
            passwordinput.SendKeys("testforepam");
            mailinput = WebDriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            var signinbutton = WebDriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            signinbutton.Click();

            // Click on Settings button
            IWebElement settings = WebDriver.FindElement(By.XPath("//button[@data-testid='view:general-settings']"));
            settings.Click();
            settings = WebDriver.FindElement(By.XPath("//a[text()='Go to settings']"));
            settings.Click();
            // Click on identity and address
            settings = WebDriver.FindElement(By.XPath("//span[text()='Identity and addresses']"));
            settings.Click();

            // Click on 'Display name' field
            var name = WebDriver.FindElement(By.Id("displayName"));
            name.Clear();
            name.SendKeys("Testepam123");

            // Click on update button
            var updatebutton = WebDriver.FindElement(By.XPath("//button[text()='Update']"));
            updatebutton.Click();
        }
    }
}