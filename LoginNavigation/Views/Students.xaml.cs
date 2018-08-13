using LoginNavigation.Data;
using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using static LoginNavigation.Data.StudentColl;

namespace LoginNavigation.Views
{
    public partial class Students : ContentPage
    {

       

        public Students()
        {
            InitializeComponent();
            refreshCount++;
            BindingContext = StudentColl.GetStudentsWithGrouping();
            Icon = "icon.png";
  
        }

        void OnAlert(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Student player = (Player)item.BindingContext;
            DataAccess dtAccess = new DataAccess();
            dtAccess.DeleteEmployee(player);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            ListView lv = (ListView)sender;
            lv.SelectedItem = null;
            if (selectedStudent != null)
                await this.Navigation.PushAsync(new Detail(selectedStudent));
        }

        void OnRefreshing(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            refreshCount++;
            BindingContext = StudentColl.GetStudentsWithGrouping();
            lv.IsRefreshing = false;
        }

        void OnSearch(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Length > 2)
                BindingContext = StudentColl.GetStudentsWithGrouping(e.NewTextValue);
            else if(String.IsNullOrEmpty(e.NewTextValue))
                BindingContext = StudentColl.GetStudentsWithGrouping();
        }
        async void OnInsert(object sender, ClickedEventArgs e)
        {
            await this.Navigation.PushAsync(new Insert());

        }
    }
}
