using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Common;
using QAAuto.Pages.Exceptions;

namespace QAAuto.Pages.Home
{
    public class HomePage : AdvancedPage
    {
        HomePageChecker checker;
        //Map
        #region Home Page Elements
        [FindsBy(How = How.XPath, Using = "//arc-navigation-button[contains(text(),'exception')]")]
        public IWebElement reviewExceptionsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(1) span")]
        public IWebElement daysLeftTextExceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(1) div.value")]
        public IWebElement percentageTextExceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Approve & submit funds']")]
        public IWebElement approveSubmitFundsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(2) span")]
        public IWebElement daysLeftTextApproved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(2) div.value")]
        public IWebElement percentageTextApproved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Review filings']")]
        public IWebElement reviewFilingsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(3) span")]
        public IWebElement daysLeftTextFiled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(3) div.value")]
        public IWebElement percentageTextFiled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button[ng-reflect-label='Review funds with missing data']")]
        public IWebElement reviewFundsWithMissingDataButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hero-section span")]
        public IWebElement daysLeftTextHeroSection { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hero-section div.value")]
        public IWebElement percentageTextHeroSection { get; set; }

        #endregion

        public HomePage() { }

        public HomePage(WebUser webUser) : base(webUser)
        {
            url = "http://dfs-qa-arcfilingweb.azurewebsites.net/";
            checker = new HomePageChecker(this);
            PageFactory.InitElements(webUser.GetDriver(), this);
        }

        public override AdvancedPage LoadPage()
        {
            return this;
        }

        public new HomePageChecker Verify()
        {
            return checker;
        }

        public static string HomeUrl()
        {
            return "http://dfs-qa-arcfilingweb.azurewebsites.net/";
        }

        #region Home Actions

        public ExceptionsPage ClickReviewExceptionsButton()
        {
            log.Info("Clicking review exceptions button");
            reviewExceptionsButton.Click();
            return new ExceptionsPage(GetWebUser());
        }

        public string GetDaysLeftTextExceptionsResolved()
        {
            log.Info("Getting days left text of exceptions resolved widget");
            return daysLeftTextExceptionsResolved.Text;
        }

        public string GetPercentageTextExceptionsResolved()
        {
            log.Info("Getting percentage of exceptions resolved widget");
            return percentageTextExceptionsResolved.Text;
        }

        public void ClickApproveSubmitFundsButton()
        {
            log.Info("Clicking approve & submit funds button");
            approveSubmitFundsButton.Click();
        }

        public string GetDaysLeftTextApproved()
        {
            log.Info("Getting days left text of approved widget");
            return daysLeftTextApproved.Text;
        }

        public string GetPercentageTextApproved()
        {
            log.Info("Getting percentage of approved widget");
            return percentageTextApproved.Text;
        }

        public void ClickReviewFilingsButton()
        {
            log.Info("Clicking review filings button");
            reviewFilingsButton.Click();
        }

        public string GetDaysLeftTextFiled()
        {
            log.Info("Getting days left text of filed widget");
            return daysLeftTextFiled.Text;
        }

        public string GetPercentageTextFiled()
        {
            log.Info("Getting percentage of filed widget");
            return percentageTextFiled.Text;
        }

        public void ClickReviewFundsWithMissingDataButton()
        {
            log.Info("Clicking review funds with missing data button");
            reviewFundsWithMissingDataButton.Click();
        }

        public string GetDaysLeftTextHeroSection()
        {
            log.Info("Getting days left text of hero section");
            return daysLeftTextHeroSection.Text;
        }

        public string GetPercentageTextHeroSection()
        {
            log.Info("Getting percentage of hero section");
            return percentageTextHeroSection.Text;
        }

        #endregion
    }
}
