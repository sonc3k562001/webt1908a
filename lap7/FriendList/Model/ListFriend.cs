using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList.Model
{
    class ListFriend
    {
        public static List<Friend> GetFriends()
        {
            var friends = new List<Friend>();

            friends.Add(new Friend { Name = "Le Pham Minh Ngoc", Age = 18, Birthday = "06-11-2001", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/male-01.png" });
            friends.Add(new Friend { Name = "Nguyen Viet Hoang", Age = 18, Birthday = "06-11-2001", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/male-02.png" });
            friends.Add(new Friend { Name = "Pham Thanh Ha", Age = 18, Birthday = "06-11-2001", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/male-03.png" });
            friends.Add(new Friend { Name = "Le Hai Anh", Age = 20, Birthday = "06-11-1999", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/female-01.png" });
            friends.Add(new Friend { Name = "Le Huyen Nhi", Age = 18, Birthday = "06-11-2001", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/female-02.png" });
            friends.Add(new Friend { Name = "Nguyen Thuy Trang", Age = 18, Birthday = "06-11-2001", Address="Moc nam - Duy Tien - Ha Nam",Numberphone="0189131931",Interests="Anime, Fime,Black Coffee,game,...",Avatar="Assets/female-03.png" });

            return friends;
        }
    }
}
