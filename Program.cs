using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string> { "Kim", "Dorain", "Jackson", "Laura", "Daphne", "Mateo", "Shaniqua","John",
                                  "Josiah","Jacob", "Alex", "Cynthia", "Marty", "Chad", "Dorian", "Rhonda", "Destiny", "Isaiah", "Katelyn", "Zamira"};


            List<string> Hometown = new List<string> { "Detroit","Seattle", "Chicago", "Atlanta", "New York", "St. Clair Shores", "Beverly Hills",
                                  "Southfield", "Nashville", "Sacremento", "Phoenix", "Rio de Janeiro", "Paris", "Dallas",
                                  "Los Angeles", "Lagos","Washington D.C.", "Seattle", "Detroit", "Denver"};

            List<string> FavoriteFood = new List<string> { "Pizza", "Nachos", "Chicken Alfredo", "Greek Salad", "Black Bean Burger", "Spaghetti", "Quiche",
                                      "Raviolli", "Samosas", "Lentil Kibbee","Fufu", "Taboulli", "BBQ Ribs", "Corn on the Cob",
                                      "Chimichangas", "Cole Slaw", "BLT sandwich", "Grinder Sub", "Chicken Salad", "Chicken Fingers"};

            List<string> FavoriteColor = new List<string> { "Purple", "Orange" , "Navy", "Pink", "Aqua", "Coral", "Red", "Blue", "Silver", "Midnight Blue",
                                                          "Tan", "Red Orange", "Brown", "Burgundy", "Canary Yellow", "Hot Pink", "Magenta", "Gray", "White",};
            Console.Write("Welcome to C# class.");
            bool repeat = true;
            while (repeat)
            { 
                Console.WriteLine("Enter \"1\" to learn about a student or \"2\" to add a student.");
                string input = Console.ReadLine().ToLower();
                int index;
                
                if (input == "1")
                {
                    Console.WriteLine($"Please enter a number between 1 and {Students.Count}");

                   
                    while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > Students.Count)
                    {
                        Console.WriteLine($"Invalid input. Please enter a number between 1 and {Students.Count}");
                    }
                    while (true)
                    {
                        Console.WriteLine("What would you like to know about " + Students[index - 1] + " (enter 'h' for hometown and 'f' for favorite food)");
                        string option1 = Console.ReadLine();

                        if (option1.ToLower().Contains("h"))
                        {
                            Console.WriteLine(Students[index - 1] + "'s" + " hometown is " + Hometown[index - 1]);
                            break;
                        }
                        else if (option1.ToLower().Contains("f"))
                        {
                            Console.WriteLine(Students[index - 1] + "'s " + "favorite food is " + FavoriteFood[index - 1]);
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please try again!");
                        }
                    }
                    
                    
                    Console.WriteLine("Would you like to select another student?(y/n)");
                    string choice = Console.ReadLine();
                    if (choice == "n")
                    {
                        Console.WriteLine("Goodbye");
                        repeat = false;
                    }
                }
                else if (input == "2")
                {
                    
                    Console.WriteLine("Please enter student name: ");
                    string name = Console.ReadLine();
                    Students.Add(name);

                    Console.WriteLine("Please enter hometown:");
                    string hometown = Console.ReadLine();
                    Hometown.Add(hometown);

                    Console.WriteLine("Please enter favorite food:");
                    string favFood = Console.ReadLine();
                    FavoriteFood.Add(favFood);


                    Console.WriteLine("Please enter favorite color:");
                    string favColor = Console.ReadLine();
                    FavoriteColor.Add(favColor);
                    Console.Clear();

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }

                //Look up parallel lists
                //You can refactor for regular expression checks
                //Review process to enter regex and prompt for validation through strings (Another form of refactoring)
                //COmparison of regex 
 

        }



    }




}




