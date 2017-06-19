using QAAuto.Pages.Common;

namespace QAAuto.Pages.Home
{
    public class MainMenuChecker : AdvancedPageChecker
    {
        private MainMenu page;
        public MainMenuChecker(MainMenu page) : base(page)
        {
            this.page = page;
        }
    }
}
