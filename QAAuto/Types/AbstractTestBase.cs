using NLog;
using QAAuto.Pages.Common;
using System;
using System.Runtime.CompilerServices;

namespace QAAuto.Types
{
    public class AbstractTestBase : IDisposable
    {
        WebUser testObject;
        static Logger log = LogManager.GetCurrentClassLogger();

        public WebUser web([CallerMemberName]string memberName = "")
        {
            if (testObject == null)
            {
                testObject = new WebUser();
            }
            log.Info("Starting test execution for " + memberName);
            //testObject.Logout()           //Login/Logout methods are not implemented yet
            return testObject;
        }

        public void Dispose()
        {
            if (testObject != null)
            {
                testObject.CloseBrowser();
                log.Info("Terminating test execution.");
            }
        }
    }
}
