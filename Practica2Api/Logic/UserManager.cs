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
                 new User(){ Name= "Santiago", Id=1},
                new User(){ Name= "Marcelo", Id=2},
                new User(){ Name= "Sandro",Id=3}
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
            User userToUpdate = Users.Find(u => u.Id == user.Id);
            userToUpdate.Name = user.Name ?? userToUpdate.Name;
            userToUpdate.Id = user.Id ?? userToUpdate.Id;
            return user;
        }
       
        public User DeleteUser(User user)
        {
            User userfound = Users.Find(u => u.Id == user.Id);
            Users.Remove(userfound);
            return user;
        }
    }
}
