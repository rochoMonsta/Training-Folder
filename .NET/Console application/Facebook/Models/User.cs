using System;

namespace Facebook.Models
{
    class User
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string UserFullName
        {
            get { return Name + " " + Surname; }
        }

        public User(string Name, string Surname, int Age)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentNullException();

            if (Age < 14 || Age > 120)
                throw new ArgumentException();

            this.Name = Name; this.Surname = Surname; this.Age = Age;
        }
        public override string ToString() => $"\t{this.Name} {this.Surname} - {this.Age}";
    }
}
