using Facebook.Models;
using System;
using System.Linq;

namespace Facebook.Data
{
    class Users
    {
        private static string CharacherCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static NameLetterCatalog[] DataBase;

        static Users() 
        {
            DataBase = new NameLetterCatalog[CharacherCharset.Length];

            for (int i = 0; i < CharacherCharset.Length; ++i)
                DataBase[i] = new NameLetterCatalog(CharacherCharset[i]);
        }
        public void AddUserToCatalog(User user)
        {
            if (DataBase.Any(c => c.Letter == user.UserFullName[0]))
            {
                var catalogIndex = IndexOfCollectionByLetter(user.UserFullName[0]);
                
                if (catalogIndex != -1)
                    DataBase[catalogIndex].AddUser(user);
            }
        }
        public void AddUserToCatalog(params User[] users)
        {
            foreach (var user in users)
                AddUserToCatalog(user);
        }
        private int IndexOfCollectionByLetter(char letter)
        {
            for (int i = 0; i < DataBase.Length; ++i)
                if (DataBase[i].Letter == letter)
                    return i;
            return -1;
        }
        public void PrintUsersCatalog()
        {
            foreach (var catalog in DataBase)
            {
                if (!(catalog.GetUsers.Count < 1))
                {
                    Console.WriteLine("Letter: " + catalog.Letter);
                    foreach (var user in catalog.GetUsers)
                        Console.WriteLine(user);
                }
            }
        }
        public int GetCount => DataBase.Length;
    }
}
