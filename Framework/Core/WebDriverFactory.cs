using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Core
{
    /// <summary>
    /// Factory for WebDrivers
    /// </summary>
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(WebBrowser name, bool headless)
        {
            switch (name)
            {
                case WebBrowser.Firefox:
                    return new FirefoxDriver();
                case WebBrowser.Chrome:
                default:
                    ChromeOptions options = new ChromeOptions();
                    if (headless)
                    {
                        options.AddArgument("--headless=new");
                    }
                    return new ChromeDriver(options);
            }
        }
    }
}
