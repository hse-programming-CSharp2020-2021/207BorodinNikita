using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    interface IVocal
    {
        public void DoSound();
    }

    abstract class Animal : IVocal
    {
        private static int Id { get; set; }

        static Animal()
        {
            Id = 1;
        }

        public string Name { get; }

        public bool IsTakenCare { get; set; }

        public abstract void DoSound();

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Is taken care: {IsTakenCare}";
        }

        protected static int GetId()
        {
            return Id++;
        }

        public Animal(string name, bool isTakenCare)
        {
            Name = name;
            IsTakenCare = isTakenCare;
        }
    }

    class Mammal : Animal
    {
        public int Id { get; }

        public int Paws { get; }

        public override void DoSound()
        {
            Console.WriteLine("я млекопитающие, би-би-би");
        }

        public Mammal(string name, bool isTakenCare, int paws) : base(name, isTakenCare)
        {
            if (paws < 1 || paws > 20)
                throw new ArgumentException();

            Paws = paws;
            Id = GetId();
        }

        public override string ToString()
        {
            return $"Mammal - Id: {Id}, Name: {Name}, Is taken care: {IsTakenCare}, Paws count: {Paws}";
        }
    }

    class Bird : Animal
    {
        public int Id { get; }

        public int Speed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("я птичка, пип-пип-пип");
        }

        public Bird(string name, bool isTakenCare, int speed) : base(name, isTakenCare)
        {
            if (speed < 1 || speed > 100)
                throw new ArgumentException();

            Speed = speed;
            Id = GetId();
        }

        public override string ToString()
        {
            return $"Bird - Id: {Id}, Name: {Name}, Is taken care: {IsTakenCare}, Speed: {Speed}";
        }
    }

    class Zoo : IEnumerable<Animal>
    {
        public List<Animal> Animals { get; }

        public Zoo()
        {
            Animals = new List<Animal>();
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return Animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Animals).GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Zoo zoo = new Zoo();
            int N = Convert.ToInt32(Console.ReadLine());

            for (int iterator = 0; iterator < N; iterator++)
            {
                string name = random.Next().ToString();
                bool isTakingCare = random.Next(0, 2) == 0;

                if (random.Next(0, 2) == 0)
                    zoo.Animals.Add(new Mammal(name, isTakingCare, random.Next(1, 21)));

                else zoo.Animals.Add(new Bird(name, isTakingCare, random.Next(1, 101)));
            }

            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal);
                animal.DoSound();
            }

            Console.WriteLine();
            var birdsQuery = from animal in zoo where animal is Bird && animal.IsTakenCare select (Bird)animal;

            foreach (var bird in birdsQuery)
                Console.WriteLine(bird);

            Console.WriteLine();
            var mammalsQuery = from animal in zoo where animal is Mammal && !animal.IsTakenCare select (Mammal)animal;

            foreach (var mammal in mammalsQuery)
                Console.WriteLine(mammal);
        }
    }
}
