//Helper Class to populate Person Graph

using System;
using System.Collections.Generic;

namespace FamilyGraphLib
{
    public class PersonGraph
    {
        public Dictionary <Int64,Person> people = new Dictionary<Int64, Person>();

        public  int addChildren(Person father, Person mother, List<Person> children)
        {
            people[father.Id].Children = children;
            people[mother.Id].Children= children;

            return 1;
        }

        public int relateSpouses(Person husband, Person wife)
        {
            people[husband.Id].Spouse = wife;
            people[wife.Id].Spouse = husband;
            people[husband.Id].IsMarried = true;
            people[wife.Id].IsMarried = true;

            return 1;
        }
        public int addParents (List<Person> children,Person father, Person mother)
        {
            foreach(Person c in children)
            {
                people[c.Id].Father = father;
                people[c.Id].Mother = mother;
            }
            return 1;
        }
        public Int64 createPerson (Int64 id, string name, Genders gender, int yearOfBirth)
        {
            people.Add(id,new Person { Id=id, Name = name,Gender = gender, YearOfBirth = yearOfBirth} );
            return id;
        }

        public Relations getRelation(Person fromPerson, Person toPerson)
        {
            if(fromPerson.getMother() == toPerson) return Relations.MOTHER;
            if(fromPerson.getFather() == toPerson) return Relations.FATHER;
            if(fromPerson.getSpouse() == toPerson) return Relations.SPOUSE;
            if(fromPerson.Children.Contains(toPerson)) return Relations.CHILD;
            if(fromPerson.getMother() == toPerson.getMother())  {
                if(toPerson.Gender == Genders.MALE) return Relations.BROTHER;
                if(toPerson.Gender == Genders.FEMALE) return Relations.SISTER;
                return Relations.SIBILING;
            }
            return Relations.UNKNOWN;
        }
    }


}