using OpenQA.Selenium;

namespace Gainchainger.Pages
{
    public class MainPage : BasePage
    {
        private By recourcesLink = By.CssSelector("#menu-1-599ae343 [href=\"https://www.gainchanger.com/resources/\"]");
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToRecources()
        {
            this.ClickOnElement(this.recourcesLink);
        }
    }
}