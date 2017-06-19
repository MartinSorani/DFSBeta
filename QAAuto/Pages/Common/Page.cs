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
        T LoadPage<T>(AdvancedPage page) where T : AdvancedPage, new();


        /// <summary>
        /// this method can be overriden in any page object in order to perform custom actions on page load
        /// </summary>
        /// <returns></returns>
        AdvancedPage LoadPage();


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
