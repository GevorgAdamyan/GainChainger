using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static Gainchainger.Support.Data;
using static Gainchainger.Support.Helpers;

namespace Gainchainger.StepDefinitions
{
    [Binding]
    public class ElementsExtractionSteps : BaseTest
    {
        [BeforeScenario]
        public void BeforTest()
        {
            this.SetUp();
        }

        [AfterScenario]
        public void AfterTest()
        {
            this.TearDown();
        }

        [Given("I am on the login page")]
        public void GivenIamOnTheLoginPage()
        {
            this.driver.Navigate().GoToUrl(baseUrl);
        }

        [When("I log in with valid creddedntials")]
        public void WhenILogInWithValidCrededdntials()
        {
            this.loginPage.DoLogin(username, password);
        }
        [Then("I should be redirected to main page")]
        public void ThenIShouldBeRedirectedToMainPage()
        {
            Assert.AreEqual(this.driver.Url, mainPageUrl);
        }
        [When("I navigate to recources page")]
        public void WhenINavigateToRecourcesPage()
        {
            this.mainPage.NavigateToRecources();
        }
        [When("I should see a list of blog posts")]
        public void WhenIShouldSeeAListOfBlogPosts()
        {
            foreach(IWebElement el in this.recourcesPage.GetBlogs())
            {
                Assert.IsTrue(el.Displayed);
            }
        }
        [When("I access the first blog post")]
        public void WhenAccessTheFirstBlogPost()
        {
            this.recourcesPage.NavigateToBlog(0);
        }        
        [Then("I export the page fields to a JSON file")]
        public void ThenIExtractPageFieldToJSONFile()
        {
            var extractedFields = this.blogPage.GetExtractedFields(elements);
            GenerateJSONFile(extractedFields);
        }
    }
}