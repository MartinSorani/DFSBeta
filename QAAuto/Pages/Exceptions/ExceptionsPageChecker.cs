using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Exceptions
{
    public class ExceptionsPageChecker : AdvancedPageChecker<ExceptionsPage>
    {
        private ExceptionsPage page;
        public ExceptionsPageChecker(ExceptionsPage page) : base(page)
        {
            this.page = page;
        }
    }
}
