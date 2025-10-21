using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class CheckAndRegestorUser
    {
      
        public static bool CheckPhoneUser(List <User> users,User userToCheck)
        {
            foreach (var user in users)
            {
                if (userToCheck._PhoneNumber == user._PhoneNumber)
                {
                    return true;
                }
                
            }
            return false;
       }

       public static void AddUser (List<User> users,User user)
        {
            users.Add(user);
        }

    }
}