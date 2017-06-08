using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using QAAuto.Pages.Common;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace QAAuto.Pages.Home
{
    public class MainMenu : AdvancedPage
    {
        //TODO separate mapping
        //Map
        #region Main Menu Elements
        [FindsBy(How = How.Id, Using = "nav-logo")]
        IWebElement homeLogo { get; set; }
        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(2)")]
        IWebElement nMenu { get; set; }
        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(3)")]
        IWebElement monthMenu { get; set; }
        [FindsBy(How = How.CssSelector, Using = "arc-dropdown:nth-child(4)")]
        IWebElement fundsMenu { get; set; }
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

        #endregion

    }
}
