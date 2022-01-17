using System;

namespace TheProductApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Testing my first C# program at Malmö University!");
            Console.Title = "My First C# Program at Malmö University";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Product product = new Product(); //Create an object of the Product class
            product.ReadName(); // call (active) a method of the object
            product.ReadPrice();// call (active) a method of the object
            product.ReadCount();
            product.CalculateTotalPrice();

        }
    }
}
