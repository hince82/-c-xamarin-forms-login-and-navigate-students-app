using System;
using SQLite;
using Xamarin.Forms;

namespace LoginNavigation
{
        public interface ISQLite
        {
            SQLiteConnection GetConnection();
        }
    }


