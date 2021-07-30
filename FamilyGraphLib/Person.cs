//Structure of a Person and its fields and data retrival methods

using System;
using System.Collections.Generic;

namespace FamilyGraphLib
{
    public class Person
    {
        public Int64 Id{get;set;}
        public string Name{get;set;}
        public Genders  Gender {get;set;}
        public int YearOfBirth {get;set;}
        public Boolean IsMarried {get; set;}
        public Person Spouse {get; set;}
        public Person Father{get;set;}
        public Person Mother{get;set;}
        public List<Person> Children = new List<Person>();
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
        public List<Person> getChildren()
        {
            Person person = this;
            return person.Children;
        }
        public Person getMother()
        {
            Person person = this;
            return person.Mother;
        }
        public Person getSpouse()
        {
            Person person = this;
            return person.Spouse;
        }
        public Person getFather()
        {
            Person person = this;
            return person.Father;
        }
        public List<Person> getParents()
        {
            List<Person> parents = new List<Person>();
            Person person = this;
            parents.Add(person.Father);
            parents.Add(person.Mother);

            return parents;
        }

       

        override public string ToString() {
            return Id.ToString() + " : " + Name ;
        }

    }

}
