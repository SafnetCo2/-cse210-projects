using System;

namespace FractionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create fractions using all constructors
            Fraction frac1 = new Fraction();       
            Fraction frac2 = new Fraction(6);      
            Fraction frac3 = new Fraction(6, 7);   

            // Output the fraction and its decimal representation
            //1/1 =1
            Console.WriteLine(frac1.GetFractionString());  
            Console.WriteLine(frac1.GetDecimalValue());   
            //6/1=6
            Console.WriteLine(frac2.GetFractionString());  
            Console.WriteLine(frac2.GetDecimalValue());   
            //6/7
            Console.WriteLine(frac3.GetFractionString());  
            Console.WriteLine(frac3.GetDecimalValue());   // 0.8571428571428571

            // Modifying values using setters
            frac1.Top = 3;
            frac1.Bottom = 4;
            //3/4
            Console.WriteLine(frac1.GetFractionString());  
            Console.WriteLine(frac1.GetDecimalValue());   
        }
    }
}
