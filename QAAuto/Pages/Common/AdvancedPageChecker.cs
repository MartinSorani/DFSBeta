using OpenQA.Selenium;
using System;

namespace QAAuto.Pages.Common
{
    public class AdvancedPageChecker<T> where T : AdvancedPage
    {
        private readonly T page;

        public AdvancedPageChecker(T page)
        {
            this.page = page;
        }

        public T GetPage()
        {
            return page;
        }

    }
}
