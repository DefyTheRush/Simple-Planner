using System;
using System.Collections; // Important for ArrayLists
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Important for StreamWriter and TextWriter

namespace A_Planner {
    class Program {
        static void Main(string[] args) {

            // Variables and Declarations
            ArrayList tasks = new ArrayList();
            string response;
            int countOfTasks = 1;

            // Main code
            do {
                Console.WriteLine("\nWhat is a goal you want to set for yourself? (Type 'exit' to display the items)");
                response = Console.ReadLine();
                response = response.ToLower();
                if (response.Equals("exit")) {
                    Console.WriteLine("\n\nYou have chosen to exit the program, displaying list now..\n");
                }
                else {
                    response = (countOfTasks + ". " + response + "\n");
                    tasks.Add(response);
                    countOfTasks++;
                }
            }
            while (!response.Equals("exit"));

            // This is a loop that iterates through an ArrayList and prints the value
            // I added a decision statement to make sure there is at least something in the list
            if (tasks.Count < 1) {
                Console.WriteLine("You have no items here");
            }

            else {
                foreach (string s in tasks)
                {
                    Console.WriteLine(s);
                }
            }

            // A way for the user to see the output and not close the program automatically, then let them close it at their own will
            Console.WriteLine("\n\nDo you want to write your list to a text file automatically? Type 'y' or 'n'");
            string write_file_response = Console.ReadLine();
            write_file_response = write_file_response.ToLower();

            if (write_file_response.Equals("y"))
            {
                // This is for writing to text files
                StreamWriter fileWriter = new StreamWriter("Plan.txt");
                Console.WriteLine("\nWriting to file now.. (Do not delete it, make a copy of it as well.");
                foreach (string s in tasks)
                {
                    fileWriter.WriteLine(s);
                }
                fileWriter.Close();
            }

            else {
                Console.WriteLine("\nThat's okay, it is here for you if you need to screenshot it");
            }

            Console.WriteLine("\n\nPress any key to exit");
            char c = Console.ReadKey().KeyChar;
        }
    }
}
