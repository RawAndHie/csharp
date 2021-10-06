using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace StudentManage.Model
{
    public class Student
    {
        public int Count { get; set; }
        public string FullName { get; set; }
        public string BirthDay { get; set; }
        public string Avatar { get; set; }
    }

    public class Avatar
    {
        public string AvatarImage { get; set; }
    }
    public class ItemAvatar
    {
        public static List<Avatar> GetAvatars()
        {

            var avatars = new List<Avatar>();
            avatars.Add(new Avatar { AvatarImage = "Assets/avatar.png" });
            avatars.Add(new Avatar { AvatarImage = "Assets/avatar2.png" });
            return avatars;
        }
    }

    public class StudentManager
    {
        public static ObservableCollection<Student> GetListStudents()
        {
            var students = new ObservableCollection<Student>();
            return students;
        }
    }
}
