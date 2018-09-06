using UnitTestProject1.CommonPageObjects;
using OpenQA.Selenium;


namespace UnitTestProject1.PageObjects
{
    class SearchResultsPage : BasePage    {
        IWebDriver driver;

        public SearchResultsPage(IWebDriver driver) : base(driver)

        {
            this.driver = driver;
        }
        public void HomeLink()
        {
            GoToHomeLink();
        }
    }
}
