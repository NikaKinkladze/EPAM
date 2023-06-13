using OpenQA.Selenium;

namespace MyFramework.Pages
{
    public class CalculatorPage
    {
        private IWebDriver Webdriver;

        public CalculatorPage(IWebDriver driver)
        {
            Webdriver = driver;
        }
        public void EnterNumberOfInstances(string NumberOfInstances)
        {
            var addNumberOfInstances = Webdriver.FindElement(By.Id("input_96"));
            addNumberOfInstances.SendKeys("4");
        }
        public void EnterSeries()
        {
            // Click on Series and choose "N1"
            IWebElement Series = Webdriver.FindElement(By.Id("select_value_label_91"));
            Series.Click();
            Series = Webdriver.FindElement(By.Id("select_option_212"));
            Series.Click();
        }
        public void EnterMachineType()
        {
            // Click on "Machine type" anc choose Instance type: "n1-standard-8 (vCPUs: 8, RAM: 30 GB)"
            IWebElement Machinetype = Webdriver.FindElement(By.Id("select_value_label_92"));
            Machinetype.Click();
            Machinetype = Webdriver.FindElement(By.Id("select_option_451"));
            Machinetype.Click();
        }
        public void AddGPUs()
        {
            // Click on "add GPUs" checkbox
            IWebElement Addgpu = Webdriver.FindElement(By.CssSelector("md-checkbox[ng-model='listingCtrl.computeServer.addGPUs']"));
            Addgpu.Click();
            // Add GPU type
            Addgpu = Webdriver.FindElement(By.Id("select_487"));
            Addgpu.Click();
            Addgpu = Webdriver.FindElement(By.Id("select_option_492")); // "Tesla V100" was disabled so i used "Tesla P100"
            Addgpu.Click();
            //add number of GPUs
            Addgpu = Webdriver.FindElement(By.Id("select_489"));
            Addgpu.Click();
            Addgpu = Webdriver.FindElement(By.Id("select_option_497"));
            Addgpu.Click();
        }
        public void AddSSDs()
        {
            // Add Local SSD: 2x375 Gb
            IWebElement Localssd = Webdriver.FindElement(By.Id("select_value_label_445"));
            Localssd.Click();
            Localssd = Webdriver.FindElement(By.Id("select_option_472"));
            Localssd.Click();
        }
        public void AddDataCenter()
        {
            // Add datacenter location
            IWebElement Location = Webdriver.FindElement(By.Id("select_value_label_94"));
            Location.Click();
            Thread.Sleep(3000);
            Location = Webdriver.FindElement(By.Id("select_option_253"));
            Location.Click();
        }
        public void AddCommitedUsage()
        {
            // Add commited usage
            IWebElement Usagedate = Webdriver.FindElement(By.Id("select_136"));
            Usagedate.Click();
            Usagedate = Webdriver.FindElement(By.Id("select_option_134"));
            Usagedate.Click();
        }
        public void AddToEstimateButton()
        {
            var button = Webdriver.FindElement(By.ClassName("md-raised"));
            button.Click();
        }
        public void FirstPrice()
        {
            IWebElement Price1 = Webdriver.FindElement(By.XPath("//div[@class='cpc-cart-total']//b[contains(text(), 'Total Estimated Cost:')]"));
            // Get the text value of the element
            string price1Text = Price1.Text;
            string price1Value = price1Text.Replace("Total Estimated Cost:", "").Trim();

            // Assert if the text contains the expected value
            Assert.IsTrue(price1Text.Contains("4,024.56"));
        }
        public void ClickOnEstimateEmail()
        {
            IWebElement estimateemail = Webdriver.FindElement(By.Id("Email Estimate"));
            estimateemail.Click();
        }
        public void SendMail()
        {
            IWebElement inputMail = Webdriver.FindElement(By.Id("input_564"));
            inputMail.SendKeys("epamtesting@yopmail.com");
            inputMail = Webdriver.FindElement(By.XPath("//button[contains(text(), 'Send Email')]"));
            inputMail.Click();
            Webdriver.SwitchTo().DefaultContent();
        }
    }
}
