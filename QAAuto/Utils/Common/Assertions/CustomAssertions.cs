using NHamcrest;
using QAAuto.Utils.Common.Results;

namespace QAAuto.Utils.Common.Assertions
{
    public class CustomAssertions
    {
        private CustomAssertions() { }

        public static AssertionItem CheckThat<T>(string summary, T actual, Matcher<T> matcher)
        {
            AssertionItem item = AssertThat(summary, actual, matcher);
            return item;
        }

        public static AssertionItem AssertThat<T>(string summary, T actual, Matcher<T> matcher)
        {
            if (matcher == null)
            {
                throw new System.ArgumentException("Matcher is null");
            }
            AssertionItem item;
            //expected not null and actual is null
            if (actual == null && !matcher.Equals(null))
            {
                item = new CheckpointResult(summary, Result.FAILED);
            }
            else if (actual == null && matcher.Equals(null))
            { //check for isNull matcher
                item = new CheckpointResult(summary, Result.PASSED);
            }
            else
            {
                bool passed = matcher.Matches(actual);
                item = new CheckpointResult(summary, passed ? Result.PASSED : Result.FAILED);
            }
            item.ReportMessage = BuildMessage(item.Result, summary, actual, matcher);
            return item;
        }

        public static string BuildMessage<T>(Result result, string summary, T actual, Matcher<T> matcher)
        {

            if (result.Equals(Result.FAILED))
            {
                return BuildFailureMessage(summary, actual, matcher);
            }
            else if (result.Equals(Result.PASSED))
            {
                return BuildSuccessMessage(summary, matcher);
            }
            else if (result.Equals(Result.NOTRUN))
            {
                return BuildSkippedMessage(summary);
            }
            else
            {
                return null;
            }
        }

        private static string BuildSkippedMessage(string summary)
        {
            const string message = "skipped validation";
            return summary + ": " + message;
        }

        private static string BuildSuccessMessage<T>(string summary, Matcher<T> matcher)
        {
            string message = MatcherSummary(matcher).Replace('<', '(').Replace('>', ')');
            return summary + ": " + message;
        }

        private static string BuildFailureMessage<T>(string summary, T actual, Matcher<T> matcher)
        {
            Description description = new StringDescription();
            if (matcher != null)
            {
                description.AppendText("instead ");
                matcher.DescribeTo(description);
                matcher.DescribeMismatch(actual, description);
            }
            else
            {
                description.AppendText("instead [not displayed] was visible");
            }
            string descriptionString = description.ToString().Replace("<", "[").Replace(">", "]");
            return summary + ": " + descriptionString;
        }

        public static string MatcherSummary<T>(Matcher<T> matcher)
        {
            Description description = new StringDescription();
            if (matcher != null)
            {
                matcher.DescribeTo(description);
            }
            else
            {
                description.AppendText("not displayed");
            }
            return description.ToString();
        }
    }
}
