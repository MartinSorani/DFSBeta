using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #endregion

        WebUser webUser;
        public ExceptionsPage(WebUser webUser) : base(webUser)
        {
            this.webUser = webUser;
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
