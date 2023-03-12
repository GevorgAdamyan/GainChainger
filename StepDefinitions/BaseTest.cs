using Gainchainger.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Gainchainger.StepDefinitions
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected LoginPage loginPage;
        protected MainPage mainPage;
        protected RecourcesPage recourcesPage;

        protected BlogPage blogPage;

        protected string GetCurrentUrl()
        {
            return driver.Url;
        }

        protected void SetUp()
        {
            this.driver = new ChromeDriver();
            this.loginPage = new LoginPage(driver);
            this.mainPage = new MainPage(driver);
            this.recourcesPage = new RecourcesPage(driver);
            this.blogPage = new BlogPage(driver);
            driver.Manage().Window.Maximize();
        }

        protected void TearDown()
        {
            driver.Quit();
        }
    }
}