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
            string playAgain;
            do
            {
                Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToUpper();

            Console.WriteLine("What is you last name?");
            string lastName = Console.ReadLine().ToUpper();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            string retireAge;
            if (age % 2 == 0)
            {
                retireAge = "42 years";
            }
            else
            {
                retireAge = "63 years (sorry)";
            }

            Console.WriteLine("What is your birth month?");
            string birthMonth = Console.ReadLine().ToUpper();
            int len = birthMonth.Length;
            int money;
            for (int i = 0; i == 0; i++)
            {
                char letter = (birthMonth[i]);
                // Console.WriteLine(birthMonth[2]);

                // switch (letter)
                int indexFirstfirst = firstName.IndexOf(birthMonth[0]);
                int indexLastfirst = lastName.IndexOf(birthMonth[0]);

                int indexFirstsecond = firstName.IndexOf(birthMonth[1]);
                int indexLastsecond = lastName.IndexOf(birthMonth[1]);

                int indexFirstthird = firstName.IndexOf(birthMonth[2]);
                int indexLastthird = lastName.IndexOf(birthMonth[2])

               ; if ((indexFirstfirst != -1) || (indexLastfirst != -1))
                {
                    money = 10000;
                }
                else if ((indexFirstsecond != -1) || (indexLastsecond != -1))
                {
                    money = 100;
                }
                else if ((indexFirstthird != -1) || (indexLastthird != -1))
                {
                    money = 2;
                }
                else
                {
                    money = 0;
                }

                //foreach (char letter in birthMonth)
                //{
                //    Console.WriteLine(letter);
                //}





                Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, type \"Help\"");
                string favoriteColor = Console.ReadLine().ToUpper();
                string transportationType;
                if (favoriteColor == "RED")
                {
                    transportationType = "bike";
                }
                else if (favoriteColor == "ORANGE")
                {
                    transportationType = "tricycle";
                }
                else if (favoriteColor == "YELLOW")
                {
                    transportationType = "scooter";
                }
                else if (favoriteColor == "GREEN")
                {
                    transportationType = "2012 Ford Focus";
                }
                else if (favoriteColor == "BLUE")
                {
                    transportationType = "private jet";
                }
                else if (favoriteColor == "INDIGO")
                {
                    transportationType = "yearly bus pass";
                }
                else if (favoriteColor == "VIOLET")
                {
                    transportationType = "skateboard";
                }
                else
                {
                    transportationType = "app to request and Uber";
                }

                if (favoriteColor == "HELP")
                {
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
                    Console.WriteLine("What is your favorite ROYGBIV color?");
                    string favoriteColoragain = Console.ReadLine();
                }

                Console.WriteLine("How many siblings do you have?");
                int numberOfsiblings = int.Parse(Console.ReadLine());
                string location;
                if (numberOfsiblings == 0)
                {
                    location = "Narnia";
                }
                else if (numberOfsiblings == 1)
                {
                    location = "Springfield";
                }
                else if (numberOfsiblings == 2)
                {
                    location = "South Park";
                }
                else if (numberOfsiblings == 3)
                {
                    location = "Quahog";
                }
                else
                {
                    location = "Bikini Bottom";
                }

                Console.WriteLine(firstName +" " + lastName + " will retire in " + retireAge + " with $" + money + " in the bank, a vacation home in " + location + " and a " + transportationType+"." );


                

                }
                Console.WriteLine("Would you like to try again?(YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
                

            }
            while (playAgain == "YES");
        }
    }
}
