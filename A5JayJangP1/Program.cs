/*
 Program ID: A5JayJangP1
 Purpose: Assignment 5 Using class.
 Rivision Histoy:
 April 16, 2017 by Jay Jang
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5JayJangP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = "";

            Dog infoDog;
            infoDog= new Dog();
            do
            {

                Console.WriteLine(" ┌───────────MENU OPTIONS───────────┐");
                Console.WriteLine(" │     A. DOG INFORMATION.          │");
                Console.WriteLine(" │     B. ADD A NEW DOG.            │");
                Console.WriteLine(" │     C. EDIT AN EXISTING DOG.     │");
                Console.WriteLine(" │     D. EXIT THE PROGRAM          │");
                Console.WriteLine(" └──────────────────────────────────┘");

                do
                {
                    Console.Write("Please choose the option you want[A to D]: ");
                    userOption = Console.ReadLine().ToUpper();
                } while (userOption != "A" && userOption != "B" &&
                            userOption != "C" && userOption != "D");


                if (userOption == "A") // Display - dog
                {
                        infoDog.DisplayDogInformation();
                }

                if (userOption == "B") // add - dog
                {
                    infoDog.AddDog(null);
                }

                if (userOption == "C") // edit - dog
                {
                    infoDog.DisplayDogInformation();
                    infoDog.EditDogInformation(null);
                }

                if (userOption == "D") // exit program
                {
                    Console.WriteLine("  BoWWoW! Goodbye!");
                    Console.WriteLine("");
                    return;
                }
            } while (true);
        }
    }
}
