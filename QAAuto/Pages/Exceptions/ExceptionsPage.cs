using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Common;

namespace QAAuto.Pages.Exceptions
{
    public class ExceptionsPage : AdvancedPage
    {
        //Map
        #region Exceptions Page Elements

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Manage exceptions']")]
        public IWebElement manageExceptionsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.main-content div.value")]
        public IWebElement percentageText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.main-content div.sub-text")]
        public IWebElement dayLeftText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Legacy')]")]
        public IWebElement fistCell { get; set; }

        #endregion

        WebUser webUser;
        ExceptionsPageChecker checker;

        public ExceptionsPage() { }

        public ExceptionsPage(WebUser webUser) : base(webUser)
        {
            this.webUser = webUser;
            PageFactory.InitElements(webUser.GetDriver(), this);
            checker = new ExceptionsPageChecker(this);
        }

        public new ExceptionsPageChecker Verify()
        {
            return checker;
        }

        #region Exceptions Actions

        public void ClickManageExceptionsButton()
        {
            log.Info("Clicking manage exceptions button");
            manageExceptionsButton.Click();
        }

        public string GetPercentageText()
        {
            log.Info("Getting percentage text");
            return percentageText.Text;
        }

        public string GetDayLeftText()
        {
            log.Info("Getting day left text");
            return dayLeftText.Text;
        }

        #endregion
    }
}
