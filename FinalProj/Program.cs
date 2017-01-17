using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter first name");
                string firstName = Console.ReadLine();
                if (firstName.ToLower() == "quit" || firstName.ToLower() == "exit" || firstName.ToLower() == "restart")
                {
                    break;
                }


                Console.WriteLine("\nEnter last name");
                string lastName = Console.ReadLine();
                if (lastName.ToLower() == "exit" || lastName.ToLower() == "quit" || lastName.ToLower() == "restart")
                {

                    break;
                }

                userGreetings(firstName, lastName);
                creepy();


                Console.WriteLine("\nEnter your age?");
                int age = int.Parse(Console.ReadLine());

                creepy();
                string years = Convert.ToString(age);
                if (years.ToLower() == "quit" || years.ToLower() == "exit" || years.ToLower() == "restart")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEnter birth month in number?");
                    int month = int.Parse(Console.ReadLine());
                    string location = Convert.ToString(month);

                    if (location.ToLower() == "quit" || location.ToLower() == "exit" || location.ToLower() == "restart")
                    {
                        break;
                    }

                    creepy();

                    Console.WriteLine("\nWhat's your favorite ROYGBIV color? Enter help for more info of ROYGBIV");
                    string coloR = (Console.ReadLine());
                    if (coloR.ToLower() == "quit" || coloR.ToLower() == "exit" || coloR.ToLower() == "restart") 
                    {
                        break;
                    }

                    else if (coloR.ToLower() == "help")
                    {
                        Console.WriteLine("R-Red, O-Orange, Y-Yellow, G-Green, B-Blue, I-Indigo, V-Violet");

                        Console.WriteLine("\n" + "Enter your favorite ROYGBIV color?");
                        coloR = Console.ReadLine();
                        creepy();
                    }
                  

                    Console.WriteLine("\nEnter number of siblings");
                    int siblings = (int.Parse(Console.ReadLine()));
                   


                    userGreetings(firstName, lastName);
                    Console.WriteLine("\n"+firstName + " " + lastName);
                    calculateYears(age);
                    calculateMoneyintheBank(month);
                    findLocationvacay(siblings);
                    coloRmatters(coloR);
                    fortuneTellerjudges();

                    break;
                }

            }


        }
        static void userGreetings(string firstName, string lastName)

        {
            Console.WriteLine("\nGreetings " + firstName + " " + lastName + " I will show you your fortune!");

        }


        static void creepy()
        {
            Console.WriteLine("I can sense a good fortune! Let's keep going!");
        }
        static int calculateYears(int age)
        {
            int retire = age % 2;

            if (retire == 0)
            {
                Console.WriteLine("You will retire in 5 years");
            }
            else
            {
                Console.WriteLine("You will retire in 10 years");
            }
            return retire;
        }
        static int findLocationvacay(int siblings)
        {
            int location = siblings;


            if (siblings == 0)
            {
                Console.WriteLine("You will have a vacation home in Greece.");
            }

            else if (siblings == 1)
            {
                Console.WriteLine("You will have a vacation home in China.");

            }
            else if (siblings == 2)

            {
                Console.WriteLine("You will have a vacation home in Florida.");
            }

            else if (siblings == 3)
            {
                Console.WriteLine("You will have a vacation home in Japan.");
            }

            else if (siblings >= 3)
            {
                Console.WriteLine("You will have a vacation home in Cleveland, Ohio.");

            }

            else if (siblings <= 0)
            {
                Console.WriteLine("You will have a vacation in Afghanistan, good luck!");
            }
            return location;
        }

        static string coloRmatters(string coloR)
        {
            coloR = coloR.ToLower();

            if (coloR == "red" || coloR == "orange" || coloR == "yellow" || coloR == "blue" || coloR == "indigo" || coloR == "violet")

                switch (coloR)

                {
                    case "red":
                        Console.WriteLine("You will be driving a red audi to work tomorrow.");
                        break;

                    case "orange":
                        Console.WriteLine("You will be taking an orange helicopter to starbucks tomorrow.");
                        break;

                    case "yellow":
                        Console.WriteLine("You will be driving a chevy camaro to see your friends tomorrow.");
                        break;

                    case "blue":
                        Console.WriteLine("You will be on a plane to Hawaii tomorrow.");
                        break;

                    case "indigo":
                        Console.WriteLine("You will be riding a scooter to get groceries tomorrow.");
                        break;

                    case "violet":
                        Console.WriteLine("You will be driving a mini cooper next friday going to Canada.");
                        break;

                    default:
                        Console.WriteLine("You are confused in life!");
                        break;

                }
            return coloR;
        }

        static int calculateMoneyintheBank(int month)
        {

            int money = month;


            if (month >= 1 || month <= 4)
            {
                Console.WriteLine("You have $15,000 in the bank.");

            }

            else if (month >= 5 || month <= 8)

            {
                Console.WriteLine("You have $5,000 in the bank.");
            }

            else if (month >= 9 || month <= 12)

            {
                Console.WriteLine("You have $2 in the bank.");

            }
            return money;
        }
        static void fortuneTellerjudges()
        {
            Console.WriteLine("Congratulations! Live long and prosper! ");
        }

    }


}
