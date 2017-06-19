using QAAuto.Pages.Home;
using System;
using System.Threading;
using NLog;
using System.Runtime.CompilerServices;

namespace QAAuto.Pages.Common
{
    public abstract class AdvancedPage : Page
    {
        private readonly ThreadLocal<WebUser> tweb = new ThreadLocal<WebUser>();
        private AdvancedPageUtils<AdvancedPage> utils;
        private AdvancedPageChecker checker;
        protected static Logger log = LogManager.GetCurrentClassLogger();
        protected static string url;

        public AdvancedPage() { }

        public AdvancedPage(WebUser webUser, params AdvancedPage[] page)
        {
            tweb.Value = webUser;
            checker = new AdvancedPageChecker(this);
            utils = new AdvancedPageUtils<AdvancedPage>(this);
            webUser.GetDriver().WaitForAngular();
        }

        protected WebUser GetWebUser()
        {
            return tweb.Value;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public MainMenu MainMenu()
        {
            return Home.MainMenu.GetMainMenu(GetWebUser());
        }

        public virtual AdvancedPage LoadPage()
        {
            return this;
        }

        public T LoadPage<T>(AdvancedPage page) where T : AdvancedPage, new()
        {
            GetWebUser().SetActivePage(page);
            return (T)Activator.CreateInstance(typeof(T), GetWebUser());
        }

        public void RefreshPage()
        {
            log.Info("Refresh page");
            GetWebUser().GetDriver().Navigate().Refresh();
        }

        public AdvancedPageChecker Verify()
        {
            return checker;
        }

        public virtual string GetUrl()
        {
            return url;
        }
    }
}
