using System;

using SQLite.Net;
using Xamarin.Forms;

namespace LoginNavigation
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}