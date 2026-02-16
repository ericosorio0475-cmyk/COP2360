using System;

var o = new Octopus("Inky");
Console.WriteLine($"{o.Name} has {o.Legs} legs.");

class Animal
{
    public readonly string Name;

    public Animal(string name)
    {
        Name = name;
    }
}

class Octopus : Animal
{
    public readonly int Legs = 8;

    public Octopus(string name) : base(name)
    {
    }
}