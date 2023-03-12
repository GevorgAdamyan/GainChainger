using OpenQA.Selenium;

namespace Gainchainger.Pages
{
    public class LoginPage : BasePage
    {
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By loginBtn = By.Id("submit");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void DoLogin(string username, string password)
        {
            this.TypeText(this.usernameField, username, false);
            this.TypeText(this.passwordField, password, false);
            this.ClickOnElement(this.loginBtn);
        }
    }
}