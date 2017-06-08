using Protractor;
using QAAuto.Users;

namespace QAAuto.Pages.Common
{
    public class WebUser
    {
        private NgWebDriver ngDriver;
        private User user;

        public WebUser()
        {
            user = new User();
        }

        public NgWebDriver GetDriver()
        {
            return ngDriver;
        }

        public User GetUser()
        {
            return user;
        }
    }
}
