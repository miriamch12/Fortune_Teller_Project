using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is you last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if(age % 2 == 0)
            {
                int retireEven = 42;
            }
            else
            {
                int retireOdd = 92;
            }           

            Console.WriteLine("What is your birth month?");
            string birthMonth = Console.ReadLine();

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, type \"Help\"");
            string favoriteColor = Console.ReadLine();
            if(favoriteColor == "Help")
            {
                Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                string favoriteColoragain = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int numberOfsiblings = int.Parse(Console.ReadLine());
            if(numberOfsiblings == 0)
            {
                string locationZero = "Narnia";
            }
            else if(numberOfsiblings == 1)
            {
                string locationOne = "Springfield";
            }
            else if(numberOfsiblings == 2)
            {
                string locationTwo = "South Park";
            }
            else if(numberOfsiblings == 3)
            {
                string locationThree = "Quahog";
            }
            else
            {
                string locationOther = "I don't know, wherever you want.";
            }
            
        }
    }
}
