using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Approval
{
    public class ApprovalPageChecker : AdvancedPageChecker<ApprovalPage>
    {
        private ApprovalPage page;
        public ApprovalPageChecker(ApprovalPage page) : base(page)
        {
            this.page = page;
        }
    }
}
