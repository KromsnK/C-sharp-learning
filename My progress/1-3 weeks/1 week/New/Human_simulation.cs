using System;

namespace Simulation
{
    class Human
    {
        public string name;
        public int age;
        private int health;
        private int mood;
        private bool isAlive;

        public Human(string n,int a)
        {
            name = n;
            age = a;
            health = 100;
            mood = 50;
            isAlive = true;
        }
        public void ChangeHealth(int c)
        {
            int change = c;
            health = health + c;
        }
        public void ChangeMood(int am)
        {
            int ammount = am;
            mood = mood + am;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        public int Rest()
        {
            Console.WriteLine(name + " is resting");
            ChangeMood(10);
            ChangeHealth(5);
            return health,mood;
        }
       

    }
    class Program
    {
        static void Main()
        {
            Human h1 = new Human("Alex", 20);
            h1.ShowInfo();
            h1.Rest();
        }
    }
}

