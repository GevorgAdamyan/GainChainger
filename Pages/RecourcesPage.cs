using OpenQA.Selenium;

namespace Gainchainger.Pages
{
    public class RecourcesPage : BasePage
    {
        private By blogsLinks = By.CssSelector(".elementor-posts-container a.elementor-post__thumbnail__link");
        public RecourcesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<IWebElement> GetBlogs()
        {
            return this.GetWebElements(this.blogsLinks);
        }

        public void NavigateToBlog(int index)
        {
            var blogs = this.GetBlogs();
            blogs[index].Click();
        }
    }
}