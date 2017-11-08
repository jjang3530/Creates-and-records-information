using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5JayJangP1
{
    class Dog
    {
        private string dogName = "";
        private string dogBreed = "";
        private string dogColour = "";
        private string dogGender = "";
        private string addDogName = null;

        public Dog() // Default constructor - if you make constructor, have to make default constructo, otherwise dafault constructor is made by program
        {
            dogName = "";
            dogBreed = "";
            dogColour = "";
            dogGender = "";
            addDogName = null;
        }

        public Dog( string dogName, string dogBreed,string dogColour, string dogGender, string addDogName) // constructor
        {
            this.dogName = dogName;
            this.dogBreed = dogBreed;
            this.dogColour = dogColour;
            this.dogGender = dogGender;
            this.addDogName = addDogName;
        }

        public void GetDogName(string iDogName)  // A dispaly dog
        {
            do
            {
                Console.WriteLine("");
                Console.Write("Pleaes write dog name: ");
                iDogName = Console.ReadLine().ToUpper();
                dogName = iDogName;

                if (iDogName.Length < 2)
                {
                    Console.Write("***Please wtire dog Name");
                    Console.WriteLine(" at least two characters.***");
                    iDogName = "";
                }
            } while (iDogName == "");

            bool empty = true;
            if (dogName == addDogName)
            {
                Console.WriteLine("");
                Console.WriteLine(" [Dog Information]");
                Console.WriteLine(" -Dog Name is: " + addDogName);
                Console.WriteLine(" -Dog Breed is: " + dogBreed);
                Console.WriteLine(" -Dog Colour is: " + dogColour);
                Console.WriteLine(" -Dog Gender is: " + dogGender);
                Console.WriteLine("");
                empty = false;
            }

            while (empty)
            {
                Console.WriteLine("");
                Console.WriteLine("No dog record exists.");
                Console.WriteLine("");
                empty = false;
            }
        }


        public void DisplayDogInformation() //display method;
        {
            bool empty = true;
            //Console.WriteLine("Dog name is: " + dogName);
            if (addDogName != null)
            {
                Console.WriteLine("");
                Console.WriteLine(" [Dog Information]");
                Console.WriteLine(" -Dog Name is: " + addDogName);
                Console.WriteLine(" -Dog Breed is: " + dogBreed);
                Console.WriteLine(" -Dog Colour is: " + dogColour);
                Console.WriteLine(" -Dog Gender is: " + dogGender);
                Console.WriteLine("");
                empty = false;
            }

            while (empty)
            {
                Console.WriteLine("");
                Console.WriteLine("No dog record exists.");
                Console.WriteLine("");
                empty = false;
            }

        }

        public void AddDog(string iDogName) //Add dog
        {
            do
            {
                Console.Write("Pleaes write dog name: ");
                iDogName = Console.ReadLine().ToUpper();
                addDogName = iDogName;

                if (iDogName.Length < 2)
                {
                    Console.Write("***Please wtire dog Name");
                    Console.WriteLine(" at least two characters.***");
                    iDogName = "";
                }
            } while (iDogName == "");

            do
            {
                Console.Write("Pleaes write dog Breed: ");
                dogBreed = Console.ReadLine().ToUpper();
            } while (dogBreed == "");

            do
            {
                Console.Write("Pleaes write dog Colour: ");
                dogColour = Console.ReadLine().ToUpper();
            } while (dogColour == "");

            do
            {
                Console.Write("Pleaes write dog Gender[Male or Female]: ");
                dogGender = Console.ReadLine().ToUpper();
            } while (dogGender != "MALE" && dogGender != "FEMALE");
            Console.WriteLine("");
        }

        public void EditDogInformation(string input) //edit dog
        {
            if(addDogName != null)
            {
            do
            {
                Console.Write("Pleaes edit dog name: ");
                addDogName = Console.ReadLine().ToUpper();

                if (addDogName.Length < 2)
                {
                    Console.Write("***Please eidt dog Name");
                    Console.WriteLine(" at least two characters.***");
                    addDogName = "";
                }
            } while (addDogName == "");

            do
            {
                Console.Write("Pleaes edit dog Breed: ");
                dogBreed = Console.ReadLine().ToUpper();
            } while (dogBreed == "");

            do
            {
                Console.Write("Pleaes edit dog Colour: ");
                dogColour = Console.ReadLine().ToUpper();
            } while (dogColour == "");

            do
            {
                Console.Write("Pleaes edit dog Gender[Male or Female]: ");
                dogGender = Console.ReadLine().ToUpper();
            } while (dogGender != "MALE" && dogGender != "FEMALE");
            Console.WriteLine("");
            }
        }




    }
}
