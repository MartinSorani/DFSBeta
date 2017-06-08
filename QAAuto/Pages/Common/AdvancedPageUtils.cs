namespace QAAuto.Pages.Common
{
    public class AdvancedPageUtils<T> where T : AdvancedPage
    {
        private readonly T page;
        public AdvancedPageUtils(T page)
        {
            this.page = page;
        }
    }
}
