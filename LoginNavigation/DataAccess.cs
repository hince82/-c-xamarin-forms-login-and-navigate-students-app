
using Xamarin.Forms;
using SQLite.Net;
using System;
using System.Collections.Generic;
using LoginNavigaiton.Views;
namespace LoginNavigation
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite> ().GetConnection();
       }
        public List<Student> GetAllEmployees()
        {
            return dbConn.Query<Student>("Select * From [Students]");
        }
        public List<Student> GetAllEmployees(string sinif)
        {
            return dbConn.Query<Student>(string.Format("Select * From [Students] where [Sinifi]='{0}'", sinif));
        }
        public int SaveEmployee(Student student)
        {
            return dbConn.Insert(student);
        }
        public int DeleteEmployee(Student student)
        {
            return dbConn.Delete(student);
        }

        public int EditEmployee(Student student)
        {
            return dbConn.Update(student);
        }
    }
}
