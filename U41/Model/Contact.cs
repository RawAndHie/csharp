using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U41.Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
}
