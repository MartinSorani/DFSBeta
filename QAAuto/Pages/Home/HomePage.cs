using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Common;

namespace QAAuto.Pages.Home
{
    public class HomePage : AdvancedPage
    {
        //Map
        #region Home Page Elements
        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Review exceptions']")]
        public IWebElement reviewExceptionsButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Approve & submit funds']")]
        public IWebElement approveSubmitFundsButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Review filings']")]
        public IWebElement reviewFillingsButton { get; set; }
        #endregion

        public HomePage(WebUser webUser) : base(webUser) { }
    }
}
