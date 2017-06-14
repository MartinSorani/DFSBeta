using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using QAAuto.Pages.Common;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace QAAuto.Pages.Home
{
    public class MainMenu : AdvancedPage
    {
        //Map
        #region Main Menu Elements
        [FindsBy(How = How.Id, Using = "nav-logo")]
        public IWebElement homeLogo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(2)")]
        public IWebElement nMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(3)")]
        public IWebElement monthMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(4)")]
        public IWebElement fundsMenu { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button:nth-child(1)")]
        public IWebElement filing { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button:nth-child(2)")]
        public IWebElement data { get; set; }

        [FindsBy(How = How.CssSelector, Using = "arc-navigation-button:nth-child(3)")]
        public IWebElement analytics { get; set; }

        [FindsBy(How = How.Id, Using = "bell-logo")]
        public IWebElement bellLogo { get; set; }

        [FindsBy(How = How.Id, Using = "profile-logo")]
        public IWebElement profileLogo { get; set; }

        [FindsBy(How = How.Id, Using = "grid-logo")]
        public IWebElement gridLogo { get; set; }        

        #endregion

        private static ConcurrentDictionary<WebUser, MainMenu> menu = new ConcurrentDictionary<WebUser, MainMenu>();
        private readonly MainMenuChecker checker;

        public MainMenu(WebUser webUser) : base(webUser)
        {
            checker = new MainMenuChecker(this);
        }

        public new MainMenuChecker Verify()
        {
            return checker;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MainMenu GetMainMenu(WebUser webUser)
        {
            if (menu[webUser] == null)
            {
                menu[webUser] = new MainMenu(webUser);
            }
            MainMenu main = menu[webUser];
            return main;
        }

        #region Main Menu Actions

        public HomePage ClickHomeLogo()
        {
            log.Info("Clicking home logo");
            homeLogo.Click();
            return new HomePage(GetWebUser());
        }

        public MainMenu ClickNMenu()
        {
            log.Info("Clicking n-menu");
            nMenu.Click();
            return this;
        }

        public MainMenu ClickFundsMenu()
        {
            log.Info("Clicking funds menu");
            fundsMenu.Click();
            return this;
        }

        public void ClickFiling()
        {
            log.Info("Clicking filing");
            filing.Click();
        }

        public void ClickData()
        {
            log.Info("Clicking data");
            data.Click();
        }

        public void ClickAnalytics()
        {
            log.Info("Clicking analytics");
            analytics.Click();
        }

        public void ClickBellLogo()
        {
            log.Info("Clicking bell logo");
            bellLogo.Click();
        }

        public void ClickProfileLogo()
        {
            log.Info("Clicking profile logo");
            profileLogo.Click();
        }

        public void ClickGridLogo()
        {
            log.Info("Clicking grid logo");
            gridLogo.Click();
        }
        #endregion

    }
}
