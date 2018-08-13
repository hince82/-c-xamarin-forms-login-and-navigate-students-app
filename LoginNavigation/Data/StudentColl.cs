using LoginNavigation.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SQLite;
using SQLite.Net;

namespace LoginNavigation.Data
{
    public class StudentColl
    {
      
        public enum Sinifi
        {
            Sınıf_5,
            Sınıf_6,
            Sınıf_7,
            Sınıf_8
        }
        public static string Sinif { get; set; } 
        public static int refreshCount { get; set; } = 0;

       public static IList<Student> Students { get; set; }

        static StudentColl()
        {
            Students = new ObservableCollection<Student>();
            DataAccess dtAccess = new DataAccess();
            Students= dtAccess.GetAllEmployees(Sinif);
           
        }

        public static ObservableCollection<Grouping<string, Student>> GetStudentsWithGrouping(string StudentFullName = null)
        {
            var result = Students;

            if (!String.IsNullOrEmpty(StudentFullName) && StudentFullName.Length > 2)
                result = Students.Where(x => x.FullName.ToLower().Contains(StudentFullName)).ToList();

            var list = new ObservableCollection<Grouping<string, Student>>(
            result
                .OrderBy(c => refreshCount % 2 == 0 ? c.Country : c.FullName)
            .GroupBy(c => refreshCount % 2 == 0 ? c.Country[0].ToString() : c.FullName[0].ToString(), c => c)
            .Select(g => new Grouping<string, Student>(g.Key, g)));

            return list;
        }
    }
}