using OpenQA.Selenium;



namespace UnitTestProject1.CommonPageObjects
{
    public class BasePage
    {
        IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);

        }
        public void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }
        public void ClickOnElement(string locatorString)
        {

            driver.FindElement(By.XPath(locatorString));
        }
        public void Search(string searchText)
        {
            driver.FindElement(By.XPath("//input[@title='Search...']")).SendKeys(searchText);
            driver.FindElement(By.XPath("//a[@title='Search']")).Click();
        }
        public void GoToHomeLink()
        {
            driver.FindElement(By.LinkText("Home")).Click();
        }


    }
}
