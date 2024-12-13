// See https://aka.ms/new-console-template for more information


public partial class Program
{
    public static void Main()
    {
        Animal myAnimal; // This is a reference to the base class

        myAnimal = new Dog(); // Dog barks
        myAnimal.MakeSound();

        myAnimal = new Cat(); // Cat meows
        myAnimal.MakeSound();
    }
}
