using System;
using Xamarin.Forms.Xaml;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Android;
using Xamarin.Android.Net;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Internals;
using LoginNavigation.Droid;
using System.IO;

using SQLite.Net;

[assembly: Dependency(typeof(SqliteService))]
namespace LoginNavigation.Droid
{
    public class SqliteService : ISQLite
    {
        public SqliteService() { }

        #region ISQLite implementation
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "/Data/Students.db";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);
            // Return the database connection 
            return conn;
        }

        #endregion


    }
}