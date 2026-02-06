using System;
using System.Linq;
using System.Collections.Generic;


namespace Simulation
{
    class LinqDemo
    {
        public static void Linq()
        {
            List<int> nums = new List<int> { -5, 1, 2, -2, 8, -7, 9, 12 };


            var even = from n in nums
                       where n % 2 == 0
                       select n;

            Console.WriteLine("Even numbers:");
            foreach (var n in even)
            {
              Console.Write(n+" ");
            }

            var mult = from n in nums
                       select n * 2;
            Console.WriteLine("\nNumbers multiplied by 2:");
            foreach (var n in mult)
            {
                Console.Write(n+ " ");
            }
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                {"Alice", 15},
                {"Bob", 22},
                {"Charlie", 19},
                {"David", 16}
            };
            var over18 = from kvp in dict
                         where kvp.Value > 18
                         select kvp.Key;
            Console.WriteLine("\nPeople over 18:");
            foreach (var name in over18)
            {
                Console.WriteLine(name);
            }
        }
    }  
    interface IRestable
    {
        void Rest();
    }
    abstract class Human : IRestable
    {
        public string name { get; set; }
        public int age { get; set; }
        protected int health=100;
        private int maxhealth = 100;
        protected int mood=50;
        protected bool isAlive=true;

        public Human(string n,int a)
        {
            name = n;
            age = a;
            health = 100;
            maxhealth = 100;
            mood = 50;
            isAlive = true;
        }
        
        protected void ChangeHealth(int c)
        {
            
            int change = c;
            health = health + c;
            if (health > maxhealth)
            {
                health = maxhealth;
            }
            else if (health < 0)
            {
                health = 0;
                isAlive = false;
            }
            }
        protected void ChangeMood(int am)
        {
            int ammount = am;
            mood = mood + am;
        }

        public abstract void ShowInfo();

        public virtual void Rest()
        {
            Console.WriteLine(name + " is resting");
            ChangeHealth(5);
            ChangeMood(10);
        }

        public abstract void Work();


    }
    class Student : Human
    {
        private int knowledge;

        public Student(string n,int a) : base (n,a)
        {
            knowledge = 0;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name: "+name+"\nAge: "+age+"\nHealth: "+health+"\nMood: "+mood+"\nKnowledge: "+knowledge);
        }
        public void Study()
        {
            Console.WriteLine(name + " is studying");
            knowledge += 10;
            ChangeMood(5);
        }
        public override void Rest()
        {
            Console.WriteLine(name+" is resting");
            ChangeHealth(5);
            ChangeMood(10);
            knowledge -= 1;
        }

        public override void Work()
        {
            Console.WriteLine(name + " is working");
            knowledge += 10;
            ChangeHealth(-5);
            ChangeMood(-10);
        }
        
        

    }
    class Worker : Human
    {
        private int experience;
        public Worker(string n,int a) : base (n,a)
        {
            experience = 0;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name: "+name+"\nAge: "+age+"\nHealth: "+health+"\nMood: "+mood+"\nExperience: "+experience);
        }

        public override void Rest()
        {
            Console.WriteLine(name + " is resting while working");
            ChangeMood(5);

        }
        public void GainExperience()
        {
            Console.WriteLine(name + " is gaining job experience");
            experience += 10;
            ChangeMood(-5);
        }
        public override void Work()
        {
            Console.WriteLine(name + " is working");
            GainExperience();
            ChangeHealth(-5);
            ChangeMood(-5);
        }
    }
    class Program
    {
        static void Main()
        {
            LinqDemo.Linq();
            Human h1 = new Student("Anton", 18);
            Human h2 = new Worker("Maria", 30);
            Student h3 = new Student("Sofia", 20);
            Student h4 = new Student("Alex", 20);
            Student[] linqdemo = {
            new Student("David",19),
            new Student("Ben",21),
            new Student("Roland",18),
            new Student("Anna",22),
            new Student("Cathy",18)
            };
            var sort = from acc in linqdemo
                       orderby acc.name , acc.age 
                       select acc;
            string str = "";
            foreach(Student acc in sort)
            {
                if (str != acc.name)
                {
                    Console.WriteLine();
                    str = acc.name;
                }
                Console.WriteLine("{0} ,\tAge: {1}", acc.name, acc.age);
            }
            Console.WriteLine();
            h1.ShowInfo();
            
            h1.Rest();
           
            h1.ShowInfo();
           
        }
    }
}

