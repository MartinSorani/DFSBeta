using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using QAAuto.Pages.Home;
using QAAuto.Users;
using System;

namespace QAAuto.Pages.Common
{
    public class WebUser
    {
        private IWebDriver driver;
        private NgWebDriver ngDriver;
        private User user;
        private Page activePage;
        private String windowHandle;

        public WebUser()
        {
            activePage = null;
            driver = new ChromeDriver();
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(120);
            ngDriver = new NgWebDriver(driver);
            user = new User();      //Implement user creation mechanism once we have a viable way to do so through the app or db
        }

        public NgWebDriver GetDriver()
        {
            return ngDriver;
        }

        public User GetUser()
        {
            return user;
        }

        private Page GetActivePage()
        {
            return activePage;
        }

        public void SetActivePage(Page page)
        {
            activePage = page;
        }

        public T LoadPage<T>(AdvancedPage page) where T : AdvancedPage, new()
        {
            SetActivePage(page);
            return page.LoadPage<T>(page);
        }

        public T Login<T>(AdvancedPage nextPage) where T : AdvancedPage
        {
            ngDriver.Navigate().GoToUrl(nextPage.GetUrl());
            return (T)nextPage;
        }

        //In the future this method should take WebUser as parameter
        public HomePage Login()
        {
            GetDriver().Navigate().GoToUrl(HomePage.HomeUrl());
            return LoadPage<HomePage>(new HomePage(this));
        }

        public void CloseBrowser()
        {
            ngDriver.Quit();
        }
    }
}
