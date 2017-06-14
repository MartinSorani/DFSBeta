using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Exceptions
{
    public class ExceptionsPage : AdvancedPage
    {
        WebUser webUser;
        public ExceptionsPage(WebUser webUser) : base(webUser)
        {
            this.webUser = webUser;
        }
    }
}
