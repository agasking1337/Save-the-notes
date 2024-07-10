using System;
using System.ComponentModel;
using System.IO;

namespace SaveData
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new file path where to save the data.
            string filePath = "saved_data.txt";


            //checking if there is an existing file if not to create one.
            if (!File.Exists(filePath)) 
            {
                Console.WriteLine("Generating a new file named " + filePath);
            }
            else
            {
                Console.WriteLine("Adding text to the existing file " + filePath);
            }

            //Appending new text to the file
            using (StreamWriter userInput = File.AppendText(filePath))
            {
                Console.WriteLine("Add your notes. ");
                userInput.WriteLine(Console.ReadLine());
            }

            Console.WriteLine("Text saved to " + filePath);

            //reading all the saved text 
            string savedData = File.ReadAllText(filePath);
            Console.WriteLine("Your previous notes are: ");
            Console.WriteLine(savedData);
            
        }
    }
}