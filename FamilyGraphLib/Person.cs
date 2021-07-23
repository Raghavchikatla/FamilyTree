using System;
using System.Collections.Generic;

namespace FamilyGraphLib
{
    public class Person
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int YearOfBirth {get;set;}
        public Person Father{get;set;}
        public Person Mother{get;set;}
        public List<Person> Children = new List<Person>();

        override public string ToString() {
            return Id.ToString() + " : " + Name ;
        }

        public List<Person> getSibilings()
        {
            Person person = this;
            List<Person> sibilings = new List<Person>();
            Person mother = person.Mother;

            foreach(Person child in mother.Children){
                if (child.Id != person.Id) {
                    sibilings.Add(child);
                }
            }

            return sibilings;
        }
    }

}
