﻿// See https://aka.ms/new-console-template for more information
using ConsoleAppDayW1D2;


static void People(string[] argus)
{

    Person person = new Person
    {
        name = "Sachidu",
        surname = "Fernando",
        age = 24,
    };

    Console.WriteLine(person.getName());
    Console.WriteLine(person.getSurname());
    Console.WriteLine(person.getAge());

}