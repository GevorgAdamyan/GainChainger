using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Gainchainger.Pages
{
    public class BlogPage : BasePage
    {
        private By header = By.CssSelector("h1.elementor-heading-title");
        private By heading = By.XPath("//h2");
        private By paragraph = By.TagName("p");
        public BlogPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Dictionary<string, object> GetExtractedFields(string[] elements)
        {
            var extractedFields = new Dictionary<string, object>();
            object textToAdd = "";
            List<string> elTxts = new List<string>();
            string script = "return document.querySelector('meta[property=\"og:description\"]').getAttribute('content')";


            foreach (string element in elements)
            {
                switch (element)
                {
                    case "H1":
                        textToAdd = this.GetWebElement(this.header).Text;
                        break;
                    case "Meta title":
                        textToAdd = driver.Title;
                        break;
                    case "Meta description":
                        textToAdd = (string)((IJavaScriptExecutor)driver).ExecuteScript(script);
                        break;
                    case "H2 elements":
                        foreach (IWebElement el in this.GetWebElements(this.heading))
                        {
                            elTxts.Add(el.Text);
                        }
                        textToAdd = elTxts;
                        break;
                    case "Paragraph elements":
                        foreach (IWebElement el in this.GetWebElements(this.paragraph))
                        {
                            elTxts.Add(el.Text);
                        }
                        textToAdd = elTxts;
                        break;
                    default:
                        Assert.Fail($"Invalid field name: {element}");
                        break;
                }
                extractedFields.Add(element, textToAdd);
            }
            return extractedFields;
        }
    }
}