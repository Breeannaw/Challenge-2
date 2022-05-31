using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Random rnd = new Random();
        int amount;
        string ans;
        int roll = 0;

        string folder = @"C:\Users\104002563\OneDrive - Swinburne University\PROGRAMMING\Challenge_2\";
        string fileName = "CavesNLizards.txt";
        string fullPath = folder + fileName;


        
        Console.WriteLine("How many dice would you like to roll?");
        amount = int.Parse(Console.ReadLine());  

        
        List<int> stored = new List<int> ();            
        
        if (roll<amount){
            while (roll<amount){
            roll = roll + 1;
            stored.Add(rnd.Next(1, 7)); 
            } }

            string txt = 
                    "You Rolled " + List(stored) + Environment.NewLine +  
                    "Average of Rolls is " + Average(stored) + Environment.NewLine + 
                    "Total of Rolls is " + Total(stored);

            
            File.WriteAllText(fullPath, txt);

            Console.WriteLine(File.ReadAllText(fullPath));

        
        
        Console.WriteLine("Would you like to roll again? Y/N");
        ans = Console.ReadLine();


        if (ans == "N"){
            Console.WriteLine("Thanks for playing!");
                    }

        while (ans == "Y") {
            roll = 0;
            stored.Clear();

            Console.WriteLine("How many dice would you like to roll?");
            amount = int.Parse(Console.ReadLine());

            if (roll<amount){
                while (roll<amount){
                roll = roll + 1;
                stored.Add(rnd.Next(1, 7)); 
            } }

            string txt2 = 
                    "You Rolled " + List(stored) + Environment.NewLine +  
                    "Average of Rolls is " + Average(stored) + Environment.NewLine + 
                    "Total of Rolls is " + Total(stored);

        File.WriteAllText(fullPath, txt2);

        Console.WriteLine(File.ReadAllText(fullPath));


        Console.WriteLine("Would you like to roll again? Y/N");
        ans = Console.ReadLine(); 
                
        if (ans == "N") {
            Console.WriteLine("Thanks for playing!");
            }
        }     
        

        }
                public static string List (List<int> stored){
                    string combinedString = string.Join(", ", stored);
                    //Console.WriteLine("You rolled " + combinedString);

                    return combinedString;
                    //To list each dice roll in a line
                }

                public static double Average (List<int> stored){
                    double average = stored.Average();
                    //Console.WriteLine("Average of rolls is {0}", average);

                    return average;
                    //To calculate the average of the rolls
                }
                public static int Total (List<int> stored){
                    int sum = stored.Sum();
                    //Console.WriteLine("Total of rolls is {0} ", sum);

                    return sum;
                    //To calculate the sum of rolls
                }
            

        }
    }

