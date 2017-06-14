using QAAuto.Pages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Data_Upload
{
    public class DataCollectedPageChecker : AdvancedPageChecker<DataCollectedPage>
    {
        private DataCollectedPage page;
        public DataCollectedPageChecker(DataCollectedPage page) : base(page)
        {
            this.page = page;
        }
    }
}
