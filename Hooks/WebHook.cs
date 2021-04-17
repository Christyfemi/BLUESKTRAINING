using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace PrepMajorSite.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        public static void Main()
        {
          //  //driver = new ChromeDriver(@"C:\PrepMajorProject\PrepMajorSite\PrepMajorSite\bin\Debug\netcoreapp3.1");
          //  //driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
         
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
