using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var HumanList = new List<Person>()
                {
                  new Person("William", "Bill"),
                  new Person("Jack", "JD"),
                  new Person("Robert", "Bob"),
                  new SuperHero("Wade Turner", "Mr. Incredible", "Super Strength"),
                  new SuperHero("Tony Stark", "Iron Man", "Flying & Powerful weapons"),
                  new SuperHero("James Howlett", "Wolverine", "Healing & retractable claws"),
                  new Villain("The Joker", "Batman"),
                  new Villain("Thanos", "the Avengers"),
                  new Villain("Sabretooth", "Wolverine")
                };
            foreach(var Item in HumanList)
            {
                Item.PrintGreeting();
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public Person(string Nname, string Nick)
        {
            Name = Nname;
            NickName = Nick;
        }
        public override string ToString()
        {
            return " " + Name;
        }
        public virtual void PrintGreeting()
        {
            Console.WriteLine(Name + ": " + "Hi, my name is " + Name + ", you can call me " + NickName + ".\n");
        }
    }
    public class SuperHero : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public static string Nick { get; set; }
        public SuperHero(string SRealName, string Nname, string SSuperPower):base(Nname, Nick)
        {
            Name = Nname;
            RealName = SRealName;
            Nick = null;
            NickName = Nick;
            SuperPower = SSuperPower;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine(Name + ": " + "I am " + RealName + ". When I am " + Name + ", my super power is " + SuperPower + "!\n");
        }
    }
    public class Villain : Person
    {
        public string Nemesis { get; set; }
        public static string Nick { get; set; }
        public Villain(string Nname, string NNemesis):base(Nname, Nick)
        {
            Name = Nname;
            Nemesis = NNemesis;
            Nick = null;
            NickName = Nick;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine(Name + ": " + "I am " + Name + "! Have you seen " + Nemesis + "?\n");
        }
    }
}
