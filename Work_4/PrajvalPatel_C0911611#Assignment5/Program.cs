using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrajvalPatel_C0911611_Assignment5
{
    public class Program
    {
        //Question 1 - Take string input, convert to array of characters, sort and reverse the array
        public static int SortDescending(int user_input)
        {
            char[] digits = user_input.ToString().ToCharArray();
            Array.Sort(digits);
            Array.Reverse(digits);
            return int.Parse(new string(digits));
        }

        //Question 2 - Use TryParse to check if input is integer or not
        public static int IsNumber(string user_input)
        {
            int result;

            if(int.TryParse(user_input.Trim('\"'), out result)) {
                Console.WriteLine("It is a numerical value");
                return result;
            }
            else
            {
                return 0;
            }
        }

        //Question 3 - Use loop to fetch all characters(i) and integers(i+1) beside the characters and make a new string
        //which has character and count of that specific character
        public static string ConvertString(string user_input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < user_input.Length; i += 2)
            {
                char c = user_input[i];
                int count = int.Parse(user_input[i + 1].ToString());
                result.Append(new string(c, count));
            }
            return result.ToString();
        }

        public static void Main(string[] args)
        {
            string user_input = "";
            bool is_int_and_positive = false;
            List<string> output_list = new List<string>();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saved.txt"); //From Stackoverflow

            //Validating user input
            do
            {
                int is_number_result;
                int reversed_digits;

                Console.WriteLine("Please enter a positive integer:");
                user_input = Console.ReadLine();

                is_number_result = IsNumber(user_input);

                //Validate if input is an integer
                if (is_number_result > 0)
                {
                    //Validate if input is positive integer
                    if (is_number_result > 0)
                    {
                        is_int_and_positive = true;
                        reversed_digits = SortDescending(is_number_result);
                        Console.WriteLine($"Reverse Sorted Number is {reversed_digits}");
                    }
                    else
                    {
                        Console.WriteLine("The number entered is not positive. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input; please enter a valid integer.");
                }
            } while (!is_int_and_positive);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Please enter a string in format of (A1B2C3):");
            user_input = Console.ReadLine();
            Console.WriteLine($"Converted input - {ConvertString(user_input)}");

            //Question 4
            output_list.Add(ConvertString(user_input));
            try
            {
                File.WriteAllLines(filePath, output_list);
                Console.WriteLine($"Data saved to {filePath}'");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
