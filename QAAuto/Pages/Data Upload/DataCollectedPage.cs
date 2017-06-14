using QAAuto.Pages.Common;
using QAAuto.Pages.Filing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto.Pages.Data_Upload
{
    public class DataCollectedPage : AdvancedPage
    {
        private MilestoneBar milestoneBar;

        public DataCollectedPage(WebUser webUser) : base(webUser)
        {
            milestoneBar = new MilestoneBar(webUser);
        }

        public MilestoneBar MilestoneBar
        {
            get { return milestoneBar; }
        }
    }
}
