using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Approval;
using QAAuto.Pages.Common;
using QAAuto.Pages.Data_Upload;
using QAAuto.Pages.Exceptions;
using QAAuto.Pages.Filed;

namespace QAAuto.Pages.Home
{
    public class HomePage : AdvancedPage
    {
        //Map
        #region Home Page Elements
        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(1) arc-navigation-button")]
        public IWebElement reviewExceptionsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(1) span")]
        public IWebElement daysLeftTextExceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(1) div.value")]
        public IWebElement percentageTextExceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "dashboard-section:nth-child(2) arc-navigation-button")]
        public IWebElement approveSubmitFundsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(2) span")]
        public IWebElement daysLeftTextApproved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(2) div.value")]
        public IWebElement percentageTextApproved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "dashboard-section:nth-child(3) arc-navigation-button")]
        public IWebElement reviewFilingsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(3) span")]
        public IWebElement daysLeftTextFiled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.section-column dashboard-section:nth-child(3) div.value")]
        public IWebElement percentageTextFiled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hero-section arc-navigation-button")]
        public IWebElement reviewFundsWithMissingDataButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hero-section span")]
        public IWebElement daysLeftTextHeroSection { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hero-section div.value")]
        public IWebElement percentageTextHeroSection { get; set; }

        #endregion

        public HomePage(WebUser webUser) : base(webUser) { }

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

        public ApprovalPage ClickApproveSubmitFundsButton()
        {
            log.Info("Clicking approve & submit funds button");
            approveSubmitFundsButton.Click();
            return new ApprovalPage(GetWebUser());
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

        public FiledPage ClickReviewFilingsButton()
        {
            log.Info("Clicking review filings button");
            reviewFilingsButton.Click();
            return new FiledPage(GetWebUser());
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

        public DataCollectedPage ClickReviewFundsWithMissingDataButton()
        {
            log.Info("Clicking review funds with missing data button");
            reviewFundsWithMissingDataButton.Click();
            return new DataCollectedPage(GetWebUser());
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
