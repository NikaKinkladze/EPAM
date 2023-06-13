using MyFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyFramework.Test
{
    public class GoogleCloudPricingCalculatorTest
    {
        private IWebDriver Webdriver { get; set; }
        private HomePage homePage;
        private CalculatorPage calculatorPage;
        private EmailPage emailPage;
        private string BaseUrl1 { get; set; } = "https://cloud.google.com/";
        private string BaseUrl2 { get; set; } = "https://yopmail.com/";



        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Webdriver = new ChromeDriver();
            homePage = new HomePage(Webdriver);
            calculatorPage = new CalculatorPage(Webdriver);
            emailPage = new EmailPage(Webdriver);
            Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Test]
        public void Test1()
        {
            // Navigate to the pricing calculator page
            Webdriver.Navigate().GoToUrl(BaseUrl1);

            homePage.ClickSearchButton();
            homePage.EnterSearch("Google Cloud Platform Pricing Calculator");
            homePage.ClickCalculatorPage();

            // Switch to iframes
            IWebElement iframe1 = Webdriver.FindElement(By.CssSelector("iframe[src='https://cloud.google.com/frame/products/calculator/index_d6a98ba38837346d20babc06ff2153b68c2990fa24322fe52c5f83ec3a78c6a0.frame']"));
            Webdriver.SwitchTo().Frame(iframe1);

            IWebElement iframe2 = Webdriver.FindElement(By.Id("myFrame"));
            Webdriver.SwitchTo().Frame(iframe2);

            // Operating System / Software and VM Class are set as default so did not change it 

            // Calculator Page actions
            calculatorPage.EnterNumberOfInstances("4");
            calculatorPage.EnterSeries();
            calculatorPage.EnterMachineType();
            calculatorPage.AddGPUs();
            calculatorPage.AddSSDs();
            calculatorPage.AddDataCenter();
            calculatorPage.AddCommitedUsage();
            calculatorPage.AddToEstimateButton();
            calculatorPage.FirstPrice();
            calculatorPage.ClickOnEstimateEmail();

            // Swtitch to default
            Webdriver.SwitchTo().DefaultContent();

            // Open new tab in browser 
            ((IJavaScriptExecutor)Webdriver).ExecuteScript("window.open();");

            // Switch to new tab
            Webdriver.SwitchTo().Window(Webdriver.WindowHandles.Last());

            // Open Website
            Webdriver.Navigate().GoToUrl(BaseUrl2);

            emailPage.GenerateEmail();

            // Return to Calculator
            Webdriver.SwitchTo().Window(Webdriver.WindowHandles.First());

            // Switch to iframe1 and iframe 2
            iframe1 = Webdriver.FindElement(By.CssSelector("iframe[src='https://cloud.google.com/frame/products/calculator/index_d6a98ba38837346d20babc06ff2153b68c2990fa24322fe52c5f83ec3a78c6a0.frame']"));
            Webdriver.SwitchTo().Frame(iframe1);
            iframe2 = Webdriver.FindElement(By.Id("myFrame"));
            Webdriver.SwitchTo().Frame(iframe2);

            // Send Mail
            calculatorPage.SendMail();

            // Return to E-mail
            Webdriver.SwitchTo().Window(Webdriver.WindowHandles.Last());
            Thread.Sleep(10000); // Wait little bit longer for E-mail to arrive 

            emailPage.ClickOnRefreshButton();

            // Click on recieved E-mail
            // Switch to iframe 3
            Webdriver.SwitchTo().Frame("ifinbox");

            emailPage.ClickOnMail();

            // Switch to default
            Webdriver.SwitchTo().DefaultContent();

            // Switch to iframe 4
            IWebElement iframe = Webdriver.FindElement(By.Name("ifmail"));
            Webdriver.SwitchTo().Frame("ifmail");

            Assert.AreEqual(calculatorPage.FirstPrice, emailPage.SecondPrice);
        }

        [TearDown]
        public void TearDown()
        {
            //Webdriver.Quit();
        }
    }
}