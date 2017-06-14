using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
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
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromMilliseconds(10);
            ngDriver = new NgWebDriver(driver);
            user = new User();
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

        private void SetActivePage(Page page)
        {
            activePage = page;
        }

        public T LoadPage<T>(T page) where T : Page, new()
        {
            SetActivePage(page);
            return page.LoadPage<T>(page);
        }
    }
}
