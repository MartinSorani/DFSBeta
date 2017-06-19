using QAAuto.Types;
using Xunit;

//Use this class to try and test your methods
//Keep your tests inside the 'Dummy' category

namespace QAAuto.Tests
{
    public class UnitTest1 : AbstractTestBase
    {
        [Fact]
        [Trait("Category", "Dummy")]
        public void TestMethod1()
        {
            web()
                .Login()
                .ClickReviewExceptionsButton()
                .Verify().FirstCellText("King");
        }

        [Fact]
        [Trait("Category", "Dummy")]
        public void TestMethod2()
        {
            web()
                .Login()
                .ClickReviewExceptionsButton()
                .Verify().FirstCellText("TestFail");
        }
    }
}
