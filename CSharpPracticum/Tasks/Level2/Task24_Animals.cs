using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        protected Animal(string name) { Name = name; }
        public abstract void MakeSound();
        public override string ToString() { return GetType().Name + ": " + Name; }
    }
    public class Dog : Animal { public Dog(string name) : base(name) { } public override void MakeSound() { Console.WriteLine(Name + ": Гав!"); } }
    public class Cat : Animal { public Cat(string name) : base(name) { } public override void MakeSound() { Console.WriteLine(Name + ": Мяу!"); } }
    public class Bird : Animal { public Bird(string name) : base(name) { } public override void MakeSound() { Console.WriteLine(Name + ": Чирик!"); } public void Fly() { Console.WriteLine(Name + " летит."); } }
    public class Task24_Animals : TaskBase
    {
        public override string Title { get { return "24. Наследование животных"; } }
        public override void Run()
        {
            List<Animal> animals = new List<Animal> { new Dog("Бобик"), new Cat("Мурка"), new Bird("Кеша") };
            foreach (Animal animal in animals) { Console.WriteLine(animal); animal.MakeSound(); Bird bird = animal as Bird; if (bird != null) bird.Fly(); }
        }
    }
}
