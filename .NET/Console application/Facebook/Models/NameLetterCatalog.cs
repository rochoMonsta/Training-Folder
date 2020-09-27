using System;
using System.Collections.Generic;
using System.Linq;

namespace Facebook.Models
{
    class NameLetterCatalog
    {
        public char Letter { get; private set; }

        private List<User> UserList;
        
        public NameLetterCatalog()
        {
            UserList = new List<User>();
        }
        public NameLetterCatalog(char Letter)
        {
            if (char.IsWhiteSpace(Letter))
                throw new ArgumentNullException();

            this.Letter = Letter; UserList = new List<User>();
        }

        public void AddUser(User user)
        {
            if (user.UserFullName[0] == Letter)
            {
                if (!UserList.Any(u => u.UserFullName == user.UserFullName))
                {
                    UserList.Add(user);
                    UserList = UserList.OrderBy(u => u.UserFullName).ToList();
                }
            }
        }
        public List<User> GetUsers => UserList;
}
}
