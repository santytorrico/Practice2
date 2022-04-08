using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager: IUserManager
    {
        public List<User> Users { get; set; }
        public UserManager()
        {
            Users = new List<User>()
            {
                 new User(){ Name= "Santiago"},
                new User(){ Name= "Marcelo"},
                new User(){ Name= "Sandro"}
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
      
        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }
       
        public User PutUser(User user)
        {
            return null;
        }
       
        public User DeleteUser(User user)
        {
            User userfound = Users.Find(u => u.Name == user.Name);
            Users.Remove(userfound);
            return user;
        }
    }
}
