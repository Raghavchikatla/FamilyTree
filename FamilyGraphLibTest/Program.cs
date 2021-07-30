//Test cases for the person and person graph functionalities
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
            GraphTest GT = new GraphTest();
            GT.Test1();
            GT.Test2();
        }
    }
}

public  class GraphTest
{
    public PersonGraph g = new PersonGraph();
    public Person Teja;
    public Person Raghav;
    public GraphTest()
    {
        g.createPerson (0,"Venkata Raghava Chandra Chikatla",Genders.MALE,1992);
        g.createPerson(1,"Satya Teja Chikatla",Genders.MALE, 1996 );
        g.createPerson (2,"Jayapadmini Chikatla",Genders.FEMALE,1969 );
        g.createPerson (3,"Srinivasa Rao Chikatla",Genders.MALE, 1963 );

        // foreach(int k in g.people.Keys){
        //     g.people[k].Id = k;
        // }
        Teja = g.people[1];
        Raghav = g.people[0];
        List<Person> children = new List<Person>();
        children.Add(g.people[0]);
        children.Add(g.people[1]);
        Person father = g.people[3];
        Person mother = g.people[2];
        g.addParents(children,father,mother);
        g.addChildren(father,mother,children);
        g.relateSpouses(father,mother);
    }

    public void Test1()
    {
        Console.WriteLine("Test1");
        foreach(Person p in g.people.Values)
        {
            Console.WriteLine(p);
        }
    }
    public void Test2()
    {
        Console.WriteLine("Test2");
        Console.WriteLine(g.getRelation(Teja,Raghav)==Relations.BROTHER);
    }
}