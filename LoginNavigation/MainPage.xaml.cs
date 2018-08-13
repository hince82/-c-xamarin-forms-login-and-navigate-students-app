using System;
using Xamarin.Forms;
using LoginNavigaiton.Views;
using LoginNavigation.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace LoginNavigation
{
    public partial class MainPage : ContentPage
    {
        public static IList<Student> Students { get; set; } 
        public MainPage(){
            
            InitializeComponent();
            DataAccess getStudentClasses = new DataAccess();
            BindingContext = getStudentClasses.GetAllEmployees();
           


        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string selectedClass = e.SelectedItem.ToString();
            StudentColl.Sinif = selectedClass;
            ListView lv = (ListView)sender;
            lv.SelectedItem = null;
            if (selectedClass != null)
                await this.Navigation.PushAsync(new Students());
        }

        void OnAlert(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Student student = new Student();
            student.Sinifi = item.BindingContext.ToString();
            DataAccess dtAccess = new DataAccess();
            Students = new ObservableCollection<Student>();
            Students=dtAccess.GetAllEmployees(student.Position);
                foreach(Student st in Students)
                       dtAccess.DeleteEmployee(st);
        }
        void OnSearch(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Length > 2)
                BindingContext = StudentColl.GetStudentsWithGrouping(e.NewTextValue);
            else if (String.IsNullOrEmpty(e.NewTextValue))
                BindingContext = StudentColl.GetStudentsWithGrouping();
        }
        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

    }
}