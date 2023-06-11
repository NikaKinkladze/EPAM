using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Send_Fake_E_Mail
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
        public void SendEmailFromProton()
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

            // Click on New message
            var newMessageButton = WebDriver.FindElement(By.XPath("//button[@data-testid='sidebar:compose']"));
            newMessageButton.Click();

            // Input addresat
            var input = WebDriver.FindElement(By.XPath("//input[@data-testid='composer:to']"));
            input.SendKeys("epam.t@yahoo.com");

            // Input subject
            input = WebDriver.FindElement(By.XPath("//input[@data-testid='composer:subject']"));
            input.SendKeys("Mail Test");

            // Input mail
            var editorDiv = WebDriver.FindElement(By.CssSelector("div.composer-content--rich-edition"));

            WebDriver.ExecuteScript("arguments[0].innerHTML = arguments[0].innerHTML.replace('Sent with Proton Mail secure email', 'I sent you this email for testing purposes');", editorDiv);

            // Click on Send
            var sendmail = WebDriver.FindElement(By.XPath("//button[@data-testid='composer:send-button']"));
            sendmail.Click();
        }

        [Test]
        public void CheckEmailOnYahoo()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl2);

            // Click on sign in button
            IWebElement submitBtn = WebDriver.FindElement(By.CssSelector("a[data-ylk='sec:ybar;slk:sign-in;elm:signin;subsec:settings;itc:0;tar:login.yahoo.com']"));
            submitBtn.Click();
            Thread.Sleep(5000);

            // Log in to second E-mail
            var input = WebDriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("epam.t@yahoo.com");
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            input = WebDriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("secondtestmail");
            submitBtn = WebDriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();

            // Click on E-mail button
            submitBtn = WebDriver.FindElement(By.Id("root_1"));
            submitBtn.Click();

            // Check if conditions are met
            IWebElement email = WebDriver.FindElement(By.CssSelector("ul[role='list']"));
            string codeText = email.Text;
            Assert.IsFalse(codeText.Contains("Unread"));
            Assert.IsTrue(codeText.Contains("From: testepam."));
            Assert.IsTrue(codeText.Contains("subject: Mail Test."));
            Assert.IsTrue(codeText.Contains("Summary: I sent you this email for testing purposes."));

            // Click on mail
            submitBtn = WebDriver.FindElement(By.CssSelector("li.H_A.hd_n.p_a.L_0.R_0 a.D_B.bm_FJ.I4_Z1gjdjJ"));
            submitBtn.Click();

            //click on replay
            submitBtn = WebDriver.FindElement(By.CssSelector("li.G_e.p_R button.A_6EqO"));
            submitBtn.Click();

            // Click on mailbox and replaying
            IWebElement mailbox = WebDriver.FindElement(By.CssSelector("div[data-test-id='rte']"));
            mailbox.Clear();
            mailbox.SendKeys("testepam123");
            mailbox = WebDriver.FindElement(By.CssSelector("button[data-test-id='compose-send-button']"));
            mailbox.Click();
        }
    }
}