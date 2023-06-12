using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MyFramework.Managers
{
    public class WebDriverManager
    {
        private static IWebDriver WebDriver { get; set; }
        private WebDriverManager() { }

        public static IWebDriver GetInstance()
        {
            if (WebDriver == null)
            {
                WebDriver = new FirefoxDriver();
                WebDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                WebDriver.Manage().Window.Maximize();
            }
            else if (WebDriver == null)
            {
                WebDriver = new ChromeDriver();
                WebDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                WebDriver.Manage().Window.Maximize();
            }
            return WebDriver;
        }

        public static void CloseBrowser()
        {
            WebDriver.Quit();
            WebDriver = null;
        }
    }
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
}
