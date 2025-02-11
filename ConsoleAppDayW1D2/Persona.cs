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
        public string name { get; set; }
        public string surname { get; set; }

        public int age { get; set; }


        public string getName()
        {
            return name;
        }

        public string getSurname() 
        {
            return surname;
        }

        public int getAge()
        {
            return age;
        }

        public string getDettagli() 
        {
            return $"Nome: {name}, Cognome:{surname}, Età: {age}";
        }
    }
}
