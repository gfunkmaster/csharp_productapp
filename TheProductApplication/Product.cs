using System;
namespace TheProductApplication
{
    public class Product
    {
        //input variables to store values given by the user
        private string name; // name of the product as text
        private double price; // price as reel number (whit or whitout decimals )
        private int count; // quantity of the product as whole number

        //Read the name of the product from the Prompt Window
        public void ReadName()
        {
            Console.WriteLine("Name of the product?"); // Writes the text to Console window
            name = Console.ReadLine();
            Console.WriteLine($"The product's name is: {name}");
        }

        public void ReadPrice()
        {
            Console.WriteLine($"What's the price of the {name}?"); // writes the text to console window and using the name og the item
            string priceName = Console.ReadLine(); // so we can write in the price
            price = Double.Parse(priceName);    // parse, convering it so it have same type
            Console.WriteLine($"The price of {name} is ${price}"); // writing it out on console
        }

        // Ask the user to feed in the qunatity of the product as whole number
        public void ReadCount()
        {
            Console.WriteLine($"How many {name}'s are there?");
            //User's input is a text(ex 34)
            string strCount = Console.ReadLine();

            //convert the text to its corresponding number ex 34 (2cgars) ---> 34 (number 34)
            count = int.Parse(strCount);

            //Confirm the input, toString converts the count to text: ex 34 ()number ---> "34" (chars)
            Console.WriteLine($"The no of {name}'s:" + count.ToString());
        }

        // Calculate the total price = count * price, Dispaly the result to the user
        public void CalculateTotalPrice()
        {
            double totalPrice = count * price;
            //display the result to the user; put a space beetween thetwo words
            Console.WriteLine("Total price for " + count.ToString() + " units of " + name + " = " + totalPrice);
        }
    }
}
