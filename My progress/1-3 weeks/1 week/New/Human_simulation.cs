using System;

namespace Simulation
{
    interface IRestable
    {
        void Rest();
    }
    abstract class Human : IRestable
    {
        public string name;
        public int age;
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
    class Program
    {
        static void Main()
        {
            Human h1 = new Student("Anton", 18);
            h1.ShowInfo();
            
            h1.Rest();
           
            h1.ShowInfo();
           
        }
    }
}

