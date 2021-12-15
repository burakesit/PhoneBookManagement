using PhoneBookDAL.Manager;
using PhoneBookEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookBLL.Management
{
    public class UserManager
    {
        public UserManager()
        {
            userDataAccess = new UserDataAccess();
        }
        UserDataAccess userDataAccess;
        public int Insert(User user)
        {
            if (string.IsNullOrEmpty(user.Name.Trim()) || string.IsNullOrEmpty(user.SurName.Trim()) || string.IsNullOrEmpty(user.Phone.Trim())) 
            {
                throw new Exception("Lütfen bilgileri doğru giriniz.");
            }
            //if e girerse aşağıdaki kodlar çalışmaz.Eğer if e girmezse benim standartlarıma uygun bir veri var demektir.
            return userDataAccess.Insert(user);

        }

        public List<User> GetUsers()
        {
            return userDataAccess.GetUser();
        }
    }
}
