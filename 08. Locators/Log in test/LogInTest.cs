using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Log_in_test
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
        public void LogInToProtonmail()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl1);

            // Navigate and click on Sign in button
            IWebElement element = WebDriver.FindElement(By.XPath("//a[contains(@href, 'https://account.proton.me/login')]"));
            element.Click();

            // Empty input and verification
            var mailinput = WebDriver.FindElement(By.Id("username"));
            mailinput.SendKeys("");
            var signinbutton = WebDriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            signinbutton.Click();
            var errorMessage = WebDriver.FindElement(By.Id("id-3"));
            Assert.AreEqual("This field is required", errorMessage.Text);
            var passwordinput = WebDriver.FindElement(By.Id("password"));
            passwordinput.SendKeys("");
            errorMessage = WebDriver.FindElement(By.Id("id-4"));
            Assert.AreEqual("This field is required", errorMessage.Text);

            // Correct Input 
            mailinput = WebDriver.FindElement(By.Id("username"));
            mailinput.SendKeys("testsepam@proton.me");
            passwordinput = WebDriver.FindElement(By.Id("password"));
            passwordinput.SendKeys("testforepam");
            mailinput = WebDriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            signinbutton.Click();

        }

        [Test]
        public void YahooMail()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl2);

            //Click on sign in button
            IWebElement submitBtn = WebDriver.FindElement(By.CssSelector("a[data-ylk='sec:ybar;slk:sign-in;elm:signin;subsec:settings;itc:0;tar:login.yahoo.com']"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Enter empty E-mail
            var input = WebDriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("");

            //Click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            var errorMsg = WebDriver.FindElement(By.Id("username-error")).Text;
            Assert.AreEqual("Sorry, we don't recognize this email.", errorMsg);

            //Enter wrong E-mail
            input = WebDriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("wrong mail");

            //Click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = WebDriver.FindElement(By.Id("username-error")).Text;
            Assert.AreEqual("Sorry, we don't recognize this account.", errorMsg);

            //Enter E-mail
            input = WebDriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("epam.t@yahoo.com");

            //Click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Enter password
            input = WebDriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("wrongpassword");

            //click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = WebDriver.FindElement(By.CssSelector(".error-msg")).Text;
            Assert.AreEqual("Invalid password. Please try again", errorMsg);

            //Enter wrong password
            input = WebDriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("");

            //click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = WebDriver.FindElement(By.CssSelector(".error-msg")).Text;
            Assert.AreEqual("Please provide password.", errorMsg);

            //Enter Correct password
            input = WebDriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("secondtestmail");

            //click next
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);
        }
    }
}