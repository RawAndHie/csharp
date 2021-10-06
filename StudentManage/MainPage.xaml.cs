using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using StudentManage.Model;
using System.Collections.ObjectModel;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentManage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Student> ListStudent;
        private List<Avatar> Avatars;
        public MainPage()
        {
            this.InitializeComponent();
            ListStudent = StudentManager.GetListStudents();
            Avatars = ItemAvatar.GetAvatars();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            
            ListStudent.Add(new Student { Count = ListStudent.Count + 1, FullName = FullName.Text, BirthDay = BirthDay.Text, Avatar = ((Avatar)AvatarComboBox.SelectedValue).AvatarImage });
        }
    }
}
