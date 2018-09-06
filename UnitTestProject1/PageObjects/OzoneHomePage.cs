using UnitTestProject1.CommonPageObjects;
using OpenQA.Selenium;

namespace UnitTestProject1.PageObjects
{
    public class OzoneHomePage : BasePage
    {
        private IWebDriver driver;

        public OzoneHomePage(IWebDriver driver) : base(driver)

        {
            this.driver = driver;
        }
        public void GoToHomePage(string url)
        {
            NavigateToPage(url);
        }

    }
}

