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
        private AdvancedPageChecker<AdvancedPage> checker;
        protected static Logger log = LogManager.GetCurrentClassLogger();

        public AdvancedPage(WebUser webUser, params AdvancedPage[] page)
        {
            tweb.Value = webUser;
            checker = new AdvancedPageChecker<AdvancedPage>(this);
            utils = new AdvancedPageUtils<AdvancedPage>(this);
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

        public T LoadPage<T>() where T : Page, new()
        {
            return (T)Activator.CreateInstance(typeof(T), GetWebUser());
        }

        public void RefreshPage()
        {
            log.Info("Refresh page");
            GetWebUser().GetDriver().Navigate().Refresh();
        }

        public AdvancedPageChecker<AdvancedPage> Verify()
        {
            return checker;
        }

    }
}
