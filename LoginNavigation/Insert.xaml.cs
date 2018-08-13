using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
    public partial class Insert : ContentPage
    {
        public Insert()
        {
            InitializeComponent();
        }
       
        void OnSaveClicked(object sender, EventArgs e)
        {
            
            Student student = new Student();
            student.FullName = fullName.Text;
            student.Gender = gender.Text;
            student.Image = fullName.Text;
            student.Height = Convert.ToInt32(height.Text);
            student.Weight = Convert.ToInt32(weight.Text);
            student.Sinifi = sinifi.Text;
            student.BirthDate = birthDate.Date;
            try
            {
                DataAccess dtAccess = new DataAccess();
                dtAccess.SaveEmployee(student);
            }
            catch(Exception ex){
                lblMessage.Text = "eksik bilgi";
                throw ex;
            }

        }
        void OnUploadClicked(object sender, EventArgs e)
        {
         //Filepicker code here
        }

    }
}
