//. Run - Time Polymorphism(Method Overriding)
//In C#, method overriding is achieved using inheritance and the virtual and override keywords.

using System;
class Animal
{

    //Base clas method marked as virtual
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal make sound");
    }
}
    class Dog:Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
    class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat Meow Meow");
        }
    }

