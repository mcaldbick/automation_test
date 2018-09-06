using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.PageObjects;

namespace UnitTestProject1
{
    public class UnitTestProject1
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void TestMethodFirefoxDriver()
        {
            OzoneHomePage ozoneHomePage = new OzoneHomePage(driver);
            ozoneHomePage.MaximizeWindow();
            ozoneHomePage.GoToHomePage("https://ozone.oakton.com.au/Pages/Home.aspx");
            ozoneHomePage.Search("Benefits");

            SearchResultsPage searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage.HomeLink();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
