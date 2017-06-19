using QAAuto.Utils.Common.Results;

namespace QAAuto.Utils.Common.Assertions
{
    public interface AssertionItem
    {
        string ReportMessage { get; set; }

        Result Result { get; set; }

        bool Failed();

        bool Passed();

    }
}
