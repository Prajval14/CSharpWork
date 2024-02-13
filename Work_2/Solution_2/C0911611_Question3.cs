using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //used for file operations

namespace Solution_2
{
    public class C0911611_Question3
    {
        //Function to write in file
        public static void calculatePosition(string filePath, double time)
        {
            double position;

            //using streamwriter function to write in a txt file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Time\tPosition");
                //using for loop to write data based on time interval of 1 second                                
                for (int i = 0; i <= time; i++)
                {
                    //calculating position
                    position = 4.0 - (2.0 * i);
                    writer.WriteLine($"{i:F1}\t\t{position:F1}");
                }
            }
        }

        public static void Main(string[] args)
        {
            //declaring and initializing variables
            bool isDouble = false;
            double result = 0;            
            //the file path is set to dynamic and is stored in bin debug folder - from stackoverflow and R&D :)
            string filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "particlePosition.txt");                       
                        
            Console.WriteLine("Please enter time (in seconds) to calculate the position of particle X: ");            

            //validating user input
            while (!isDouble || result < 0)
            {
                //user input
                string userInput = Console.ReadLine();

                //positive double input validation
                if (double.TryParse(userInput, out result) && result >= 0)
                {
                    //rounding off user input to ceiling value        
                    result = Math.Ceiling(result);
                    //calling calculatePosition function
                    calculatePosition(filePath, result);                    
                    isDouble = true;
                }
                else
                {
                    //error message
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

            //Output
            Console.WriteLine($"Particle X's positons over {result} seconds has been updated in the file.");

            Console.ReadLine();
        }
    }
}
