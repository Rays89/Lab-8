using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int Student;

            //Console.WriteLine("Welcome to our C# class.");
            //string input = Console.ReadLine();

            //Console.WriteLine("Which student would you like to learn more about?");
            //int Student;

            string[] Names = {"Kim","Ray","Driscoll","Ronah","Ama","Caty","Katie","Babara","Oprah","Dan",
                "Cameroon","Kyle","Doreen","Stella","Dee","Shatty","Joan","Penny","Mike","Ian" };

            string[] Hometown = {"Detroit","Chicago","Boston","Washington","Southfield","Taylor",
                "Brownstown","Newyork","Uganda","London","Newcastle","Birmingham","Turkey","Lagos","Nashville","Dallas","Kampala","Mbarara",
            "Abuja","Sunderland"};

            string[] FavFoods = {"Rice","Posho","Matooke","Cassave","Chilli soup","Pizza","Fufu",
                "Grilled Chicken Salaads","Burger","Chocalate","Wheat Bread","Fish","Chicken","Goat Meat",
            "Bean soup","Cookies","Donuts","Sweet Chilli","Mash mellows","Bisquits"};

            Console.WriteLine("Welcome to our C# class.");


            bool repeat = true;
            while (repeat)
            {
               



                Console.WriteLine("Which student would you like to learn more about.? Please enter a number from 1-20 to know about a student");


                while (!int.TryParse(Console.ReadLine(), out Student) || Student < 1 || Student > 20)
                {

                    Console.WriteLine("That student does not exist. Please Try again. Enter a number from 1-20");

                    //input = Console.ReadLine();
                }

                Console.WriteLine(Names[Student - 1]);


                Console.WriteLine($"What would you like to know more about {Names[Student - 1]}");
                Console.WriteLine("Would you like to know the hometown (h) or the favorite food (f)");
                string input = Console.ReadLine().ToLower();

                if (input != "h" && input != "f" && input != "n")
                {
                    Console.WriteLine("Please enter (h) or (f) or (n) to choose another student");
                    input = Console.ReadLine().ToLower();
                }

                if (input == "h")
                {

                    Console.WriteLine($"{Names[Student - 1]}'s Hometown is  {Hometown[Student - 1]} ");
                    Console.WriteLine($"Would you like to know {Names[Student - 1]}'s favourite food (f) or (n)");
                    input = Console.ReadLine().ToLower();
                    //Console.WriteLine($"{Names[Student - 1]}'s FavFoods is {FavFoods[Student - 1]}");


                    while (input != "f" && input != "n")
                    {
                        Console.WriteLine("Please enter (f) or (n) to choose another student");
                        input = Console.ReadLine().ToLower();
                    }
                    if (input == "f")
                    {
                        Console.WriteLine($"{Names[Student - 1]}'s favorite food is {FavFoods[Student - 1]}");
                        repeat = GetResponce("Would you like to know about another student? (y) or (n)");
                    }
                    else
                    {
                        repeat = GetResponce("Would you like to know another student? (y) or (n)");
                    }
                }
                else if (input == "f")
                {
                    Console.WriteLine($"{Names[Student - 1]}'s favorite food is {FavFoods[Student - 1]}");
                    Console.WriteLine($"Would you like to know {Names[Student - 1]} hometown (h) or (n)");
                    input = Console.ReadLine().ToLower();

                    while (input != "h" && input != "n")
                    {
                        Console.WriteLine("Please enter (y) or (n) to choose another student");
                        input = Console.ReadLine().ToLower();
                    }

                    if (input == "h")
                    {
                        Console.WriteLine($"{Names[Student - 1]}'s Hometown is {Hometown[Student - 1]}");
                        //Console.WriteLine($"{Names[Student]}")
                    }
                    else
                    {

                        repeat = GetResponce("Would you like to know more about another student? (y) or (n)");

                    }

                }
                else
                {
                    Console.WriteLine("Thanks");
                    repeat = false;
                    
                }
            }
        }

        public static bool GetResponce(string prompt)
        {

            while (true)
            {

                Console.WriteLine(prompt);
                string input = Console.ReadLine().ToLower();//method
                if (input == "n")
                {

                    return false;
                }

                else if (input == "y")
                {

                    return true;
                }
                else

                {

                    Console.WriteLine("Thank you.");
                    
                }
            }
        }
        
    }
}
