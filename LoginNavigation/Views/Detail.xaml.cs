using Xamarin.Forms;
using System;
using LoginNavigation.Data;
using static LoginNavigation.Data.StudentColl;

namespace LoginNavigation.Views
{
    public partial class Detail : ContentPage
    {
        public Detail(Student student)
        {
            InitializeComponent();
            BindingContext = student;
            Title = student.FullName;
            Icon = "icon.png";

        }
        void OnUpdate(object sender, EventArgs e)
        {
            fullName.IsEnabled = true;
            sinifi.IsEnabled = true;
            weight.IsEnabled = true;
            height.IsEnabled = true;
            birthDate.IsEnabled = true;
            btnSave.IsVisible = true;
        }
        void OnSave(object sender, EventArgs e)
        {
            
            Student student = new Student();
            student.FullName = fullName.Text;
            student.Gender = gender.Text;
            student.Image = fullName.Text;
            student.Height = Convert.ToInt32(height.Text);
            student.Weight = Convert.ToInt32(weight.Text);
            student.Sinifi = Sinifi.Text;
            student.BirthDate = Convert.ToInt32(birthDate.Text);
            try
            {
                DataAccess dtAccess = new DataAccess();
                dtAccess.EditEmployee(student);
            }
            catch (Exception ex)
            {
                lblMessage.Text = "eksik bilgi";
                throw ex;
            }

        }
    }
}