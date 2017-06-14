using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Filed
{
    public class FiledPageChecker : AdvancedPageChecker<FiledPage>
    {
        private FiledPage page;
        public FiledPageChecker(FiledPage page) : base(page)
        {
            this.page = page;
        }
    }
}
