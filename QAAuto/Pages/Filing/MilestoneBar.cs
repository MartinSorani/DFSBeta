using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAAuto.Pages.Approval;
using QAAuto.Pages.Common;
using QAAuto.Pages.Data_Upload;
using QAAuto.Pages.Exceptions;
using QAAuto.Pages.Filed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Filing
{
    public class MilestoneBar : AdvancedPage
    {
        #region Milestone Bar Elements

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(1)")]
        public IWebElement dataCollected { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(1) span")]
        public IWebElement percentageDataCollected { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(2)")]
        public IWebElement exceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(2) span")]
        public IWebElement percentageExceptionsResolved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(3)")]
        public IWebElement approved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(3) span")]
        public IWebElement percentageApproved { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(4)")]
        public IWebElement filed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > arc-tab-navigation > arc-tab:nth-child(4) span")]
        public IWebElement percentageFiled { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-tab.arc-tab-nav.isSelected")]
        public IWebElement activeTitle { get; set; }

        #endregion

        public MilestoneBar(WebUser webUser) : base(webUser)
        { }

        #region Milestone Bar Actions

        public DataCollectedPage ClickDataCollected()
        {
            log.Info("Clicking Data Collected");
            dataCollected.Click();
            return new DataCollectedPage(GetWebUser());
        }

        public ExceptionsPage ClickExceptionsResolved()
        {
            log.Info("Clicking Exceptions Resolved");
            exceptionsResolved.Click();
            return new ExceptionsPage(GetWebUser());
        }

        public ApprovalPage ClickApproved()
        {
            log.Info("Clicking Approved");
            approved.Click();
            return new ApprovalPage(GetWebUser());
        }

        public FiledPage ClickFiled()
        {
            log.Info("Clicking Filed");
            filed.Click();
            return new FiledPage(GetWebUser());
        }

        public string GetPercentageDataCollected()
        {
            log.Info("Getting the percentage data collected of the milestone bar");
            return percentageDataCollected.Text;
        }

        public string GetPercentageExceptionsResolved()
        {
            log.Info("Getting the percentage exceptions resolved of the milestone bar");
            return percentageExceptionsResolved.Text;
        }

        public string GetPercentageApproved()
        {
            log.Info("Getting the percentage approved of the milestone bar");
            return percentageApproved.Text;
        }

        public string GetPercentageFiled()
        {
            log.Info("Getting the percentage filed of the milestone bar");
            return percentageFiled.Text;
        }

        public string GetActiveTitle()
        {
            log.Info("Getting the active title of the milestone bar");
            return activeTitle.Text;
        }

        public bool IsHighlightedActive()
        {
            log.Info("Getting if the active title is highlighted");
            return activeTitle.GetCssValue("border-bottom-color").Equals("#0596e1") && activeTitle.GetCssValue("border-bottom-width").Equals("4px") && activeTitle.GetCssValue("font-weight").Equals("700");
        }

        public bool IsLowLightedDataCollected()
        {
            log.Info("Getting if the Data Collected is lowlighted");
            return dataCollected.GetCssValue("border-bottom-color").Equals("#7fdcff") && dataCollected.GetCssValue("border-bottom-width").Equals("2px") && dataCollected.GetCssValue("font-weight").Equals("600");
        }

        public bool IsLowLightedExceptionsResolved()
        {
            log.Info("Getting if the Exceptions Resolved is lowlighted");
            return exceptionsResolved.GetCssValue("border-bottom-color").Equals("#7fdcff") && exceptionsResolved.GetCssValue("border-bottom-width").Equals("2px") && exceptionsResolved.GetCssValue("font-weight").Equals("600");
        }

        public bool IsLowLightedApproved()
        {
            log.Info("Getting if the Approved is lowlighted");
            return approved.GetCssValue("border-bottom-color").Equals("#7fdcff") && approved.GetCssValue("border-bottom-width").Equals("2px") && approved.GetCssValue("font-weight").Equals("600");
        }

        public bool IsLowLightedFiled()
        {
            log.Info("Getting if the Filed is lowlighted");
            return filed.GetCssValue("border-bottom-color").Equals("#7fdcff") && filed.GetCssValue("border-bottom-width").Equals("2px") && filed.GetCssValue("font-weight").Equals("600");
        }

        #endregion
    }
}
