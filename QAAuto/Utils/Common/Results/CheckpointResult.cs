using QAAuto.Utils.Common.Assertions;

namespace QAAuto.Utils.Common.Results
{
    public class CheckpointResult : AssertionItem
    {

        private string reportMessage;
        private Result result;

        private CheckpointResult()
        {
        }

        public CheckpointResult(string summary, Result result)
        {
            this.result = result;
            reportMessage = summary;
        }

        public Result Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public bool Failed()
        {
            return result.failed();
        }

        public bool Passed()
        {
            return result.passed();
        }

        public string ReportMessage
        {
            get
            {
                return reportMessage;
            }
            set
            {
                reportMessage = value;
            }
        }
    }
}
