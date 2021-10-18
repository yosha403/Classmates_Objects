using System;
using System.Collections.Generic;

//DevBuild Lab : GET TO KNOW YOUR CLASSMATES REDUX WITH OBJECTS
//Author: Yosha Kunnummal
//Date: 10/17/2021

namespace StudentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Tommy", "Raleigh", "Curry"));
            students.Add(new Student("Cassly", "Detroit", "Steak"));
            students.Add(new Student("Anurag", "Rochester", "Tacos"));
            students.Add(new Student("Zac", "Wyandotte", "Sushi"));
            students.Add(new Student("Ese", "Detroit", "Shrimp"));
            students.Add(new Student("Marjorie", "Detroit", "Lasagna"));
            students.Add(new Student("Erin", "Troy", "Tacos"));
            students.Add(new Student("Richard", "Canton", "Sushi"));
            students.Add(new Student("Cullin", "Fowlerville", "Pad Thai"));
            students.Add(new Student("Cordero", "Berkley", "BBQ"));

            int num = students.Count;

            //Printing the details of students in the order of StudentId, Student name,Home town and Favorite food
            //Student ID starts from 0 to 9
            Console.WriteLine("C# DevBuild 7");
            Console.WriteLine("\nStudentID\t\tStudentName\t\tHometown\t\tFavorite Food");
            Console.WriteLine("");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i}\t\t\t{students[i].Name}\t\t\t{students[i].HomeTown}\t\t\t{students[i].FavoriteFood}");
            }

            bool goOn = true;
            while (goOn == true)
            {
                try
                {
                    Console.WriteLine("\nWelcome to our C# class. Which student would you like to learn more about?");
                    int studentNum = int.Parse(Console.ReadLine());

                    //Checking whether the student ID exists based on the input value
                    if (studentNum < num)
                    {
                        Console.WriteLine($"Student {studentNum}  is {students[studentNum].Name}. What would you like to know about {students[studentNum].Name}? (enter hometown or favoritefood):");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "hometown" || choice.ToLower() == "favoritefood")
                        {
                            if (choice.ToLower() == "hometown")
                            {
                                Console.WriteLine($"{students[studentNum].Name} is from {students[studentNum].HomeTown}.");
                                goOn = Continue();
                            }
                            else
                            {
                                Console.WriteLine($"{students[studentNum].Name}'s favorite food  is {students[studentNum].FavoriteFood}.");
                                goOn = Continue();
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        //A method to continue the application for more inputs
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to know more ? (enter “yes” or “no”):");
            string answer = Console.ReadLine().ToLower();

            if (answer.ToLower() == "yes")
            {
                return true;
            }
            else if (answer.ToLower() == "no")
            {
                Console.WriteLine("Thanks!");
                return false;
            }
            else
            {
                Console.WriteLine("\nThis is not a valid selection. ");
                Console.WriteLine("Please try again!");

                //This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}
