using System;

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        Animal cachorro1 = new Cachorro();
        Animal gato1 = new Gato();

        animal1.EmitirSom();    // Animal emitindo som
        cachorro1.EmitirSom();  // Au au!
        gato1.EmitirSom();      // Miau!
    }
}

