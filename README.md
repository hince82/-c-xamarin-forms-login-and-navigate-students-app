# C# xamarin-forms- Login and navigate students for teachers app
  Hi,this is my c# app for teachers in Xamarin.Forms. I chose Xamarin.forms because the 
  ease of developing for both Android and IOS.  In this app  teachers can 
  look students' personal info to recognize them easily. Specially in big schools
  its a big problem to recognize students among each other.Main motto in this app 
  Listview and Converters. By implementing "image" and  "birthday" converters
  i can set image source from PCL shared layer to both Android  and IOS.Also enabled 
  grouping in Listview so i can group  students with grouping helper in Utility folder.
  
## Folder Stucture
   Data, Images,Utility, Views
    Data: Converter and POCO Binding class files,also sqlite db file "students.db"
    Images:Student Images
    Utility:Grouping helper file to group students in listview
    Views:Students.xaml and Detail.xaml
    LinkTemplates:Template for reset link
    Login.xaml: Login file, simple stack navigation with navigation.popasync() or 
                pushasync after "app.IsUserLoggedIn=true". admin username and password is in "constants.cs"
    Signup.xaml: Saves new user. Need to edit it because still using "Constants"
                 file for admin entry.  
    ResetPassword.xaml: Non complete page for "forgot password". I plan to 
                        create a JWT token (nuget package must be intsalled) 
                        and send it to user mail as a reset link.At the same 
                        time need to save it to database with an expiry date.
                        Need some time to complete nowadays. 
    MainPage.xaml: After successful login lists students classes in database.
    DataAccess: Data connection  helper.
    IsqLite : Interface to use with "dependency service" for both IOS and Android connections.So with "environment
              .GetFolderPath.SpecialFolder.Personal " command can get both local 
              paths and to make db connection.
    Insert.xaml: Insert new student. An addition to TODO list; must improve 
                 "filepciker" class for photo upload for students.
    Update and Delete Student:To Delete, "viewcellcontext" in listview is set to ask 
                                delete the student. For Update, simply click "Guncelle "
                               in Detail.xaml and entry boxes in the file been set to 
                               enabled to edit student info.
          
    
