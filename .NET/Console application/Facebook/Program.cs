using Facebook.Data;
using Facebook.Models;
using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Anton", "Lomovatskiy", 20);
            User user2 = new User("Abrakham", "Morgan", 19);
            User user3 = new User("Boris", "Battoni", 75);
            User user4 = new User("Batti", "Wilcom", 24);
            User user5 = new User("Catti", "Smith", 19);

            Users usersDB = new Users();

            usersDB.AddUserToCatalog(user1, user2, user3, user4, user5);

            usersDB.PrintUsersCatalog();

            Console.ReadLine();
        }
    }
}
