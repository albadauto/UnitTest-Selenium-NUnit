using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteProjeto3
{
    public class Begin
    {

        public IWebDriver driver;
        public bool driverQuit = true;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = false;

        }

        [TearDown]
        public void EndTest()
        {
            if (driverQuit)
            {
                driver.Quit();
            }
        }

        
    }
}