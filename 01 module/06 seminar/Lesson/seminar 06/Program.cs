using System;

namespace seminar_06
{
    class Animal
    {
        public string name;

        public string sound;

        public int age;

        public Animal(string sound, string name, int age)
        {
            this.sound = sound;

            this.name = name;

            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Meow!", "Felix", 7);

            Animal dog = new Animal("Bark!", "Sparky", 1);

            Animal rat = new Animal("Pee!", "Winny", 2);

            Animal fish = new Animal("...", "Mr. Fish", 0);

            Animal[] pets = new Animal[4];

            pets[0] = cat; pets[1] = dog; pets[2] = rat; pets[3] = fish;

            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine($"Name of the pet? {pets[i].name}\nWhat does the {pets[i].name} say? {pets[i].sound}\nHow is {pets[i].name} old? {pets[i].age} years old{Environment.NewLine}");
            }
        }
    }
}
