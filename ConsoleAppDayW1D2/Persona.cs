using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDayW1D2
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age.ToString();
        }
        public string GetName()
        {
            return Name;
        }

        public string GetSurname()
        { 
            return Surname;
        }

        public int getAge()
        {
            return Age.ToString();
        }

        public string getDetails() 
        {
            return $"Nome: {Name}, Cognome:{Surname}, Età: {Age}";
        }
    }
}
