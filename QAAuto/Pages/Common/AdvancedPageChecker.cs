using NHamcrest;
using QAAuto.Utils.Common.Assertions;
using Xunit;

namespace QAAuto.Pages.Common
{
    public class AdvancedPageChecker : AdvancedPage
    {
        private readonly AdvancedPage page;

        public AdvancedPageChecker(AdvancedPage page)
        {
            this.page = page;
        }

        public AdvancedPage GetPage()
        {
            return page;
        }

        public virtual bool CheckThat<U>(U actual, string summary, Matcher<U> matcher)
        {
            AssertionItem item = CustomAssertions.CheckThat(summary, actual, matcher);
            log.Info(summary + ": " + item.Result.passed().ToString());
            if (item.Result.passed())
            {
                return true;
            }
            else
            {
                Assert.False(true, summary + " returned false");
                return false;
            }
        }

    }
}
