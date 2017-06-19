using NHamcrest.Core;
using QAAuto.Pages.Common;

namespace QAAuto.Pages.Exceptions
{
    public class ExceptionsPageChecker : AdvancedPageChecker
    {
        private ExceptionsPage page;
        public ExceptionsPageChecker(ExceptionsPage page) : base(page)
        {
            this.page = page;
        }

        public ExceptionsPage FirstCellText(string text)
        {
            CheckThat(page.fistCell.Text, "Checking that first cell contains: ", Contains.String(text));
            return page;
        }
    }
}
