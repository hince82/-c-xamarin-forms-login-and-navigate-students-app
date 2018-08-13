using Xamarin.Forms;

using LoginNavigation.Views;
namespace LoginNavigation
{
    public class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        static DataAccess dbUtils;
        public App()
        {

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new MainPage();
            }

        }
      
        public static DataAccess DAUtil
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }
    

		
	}
}

