using QAAuto.Pages.Home;

namespace QAAuto.Pages.Common
{
    public interface Page
    {

        /// <summary>
        /// aceess object of checker class
        /// </summary>
        /// <returns>AdvancedPageChecker</returns>
        //AdvancedPageChecker<AdvancedPage> Verify();


        /// <summary>
        /// creates page object of the given class using its constructor Page(WebUser)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T LoadPage<T>() where T : Page, new();


        /// <summary>
        /// access the main menu object, singleton
        /// </summary>
        /// <returns></returns>
        MainMenu MainMenu();


        /// <summary>
        /// refresh current page
        /// </summary>
        void RefreshPage();
    }
}
