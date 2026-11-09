
using System;

abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract string Sound { get; }

    public void Speak()
    {
        Console.WriteLine(Name + " says: " + Sound);
    }

    public void Sleep()
    {
        Console.WriteLine("Zzz...");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override string Sound
    {
        get { return "Woof!"; }
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Sound
    {
        get { return "Meow!"; }
    }
}

class Bird : Animal
{
    public Bird(string name) : base(name)
    {
    }

    public override string Sound
    {
        get { return "Tweet!"; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Max");
        Cat cat = new Cat("Kitty");
        Bird bird = new Bird("Tweety");

        dog.Speak();
        dog.Sleep();

        Console.WriteLine();

        cat.Speak();
        cat.Sleep();

        Console.WriteLine();

        bird.Speak();
        bird.Sleep();
    }
}
