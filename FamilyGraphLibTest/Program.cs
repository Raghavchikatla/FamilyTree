using System;
using System.Collections.Generic;
using System.Linq;
using FamilyGraphLib;

namespace FamilyGraphLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Person p in PersonService.persons[0].getSibilings())
            {
                Console.WriteLine(p);
            }
        }
    }
}

public  class PersonService
{
    public static List<Person> persons { get; }
    static PersonService()
    {
        persons = new List<Person>
        {
            new Person {  Name = "Venkata Raghava Chandra Chikatla", YearOfBirth = 1992},
            new Person {  Name = "Satya Teja Chikatla", YearOfBirth = 1996},
            new Person {  Name = "Jayapadmini Chikatla", YearOfBirth = 1969},
            new Person {  Name = "Srinivasa Rao Chikatla", YearOfBirth = 1963}
        };

        for (int i=0;i<persons.Count();i++) {
            persons[i].Id = i;
        }

        persons[0].Mother = persons[2];
        persons[1].Mother = persons[2];

        persons[0].Father = persons[3];
        persons[1].Father = persons[3];

        persons[2].Children.Add(persons[0]);
        persons[2].Children.Add(persons[1]);

        persons[3].Children.Add(persons[0]);
        persons[3].Children.Add(persons[1]);

    }



            
    
    public string getRelation(Person person)
    {
        return "";

    }
}