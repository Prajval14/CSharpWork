//Prepared By - Prajval Patel (C0911611)
//Date - Jan 21, 2024

using System;

namespace Question_2
{
    public class Program
    {
        //method to get type of parking (long or short)
        public static int GetParkingType(Parking parkingClass)
        {
            Console.WriteLine("Airport Parking:\n--------------------------------------\nChoose parking type:\n1. Long Term Parking (typically in days)\n2. Short Term Parking (typically in hours)");

            parkingClass.ParkingType = GetValidIntegerInput();

            while (parkingClass.ParkingType != 1 && parkingClass.ParkingType != 2)
            {
                Console.WriteLine("Please enter valid parking mode (1 or 2).");
                parkingClass.ParkingType = GetValidIntegerInput();
            }
            return parkingClass.ParkingType;
        }

        //method to validate integer input (based on online research)
        public static int GetValidIntegerInput()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            return result;
        }

        //method to validate float input (based on online research)
        public static float GetValidFloatInput()
        {
            float result;

            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid float number.");
            }

            return result;
        }

        //method to calculate long term parking fee
        public static float LongTermParking(Parking parkingClass)
        {
            Console.WriteLine("Please enter number of days for parking: ");

            parkingClass.NumberOfDays = GetValidFloatInput();

            parkingClass.ParkingFee = parkingClass.LongTermParkingOneTimeFee + (parkingClass.LongTermParkingOneDayFee * parkingClass.NumberOfDays);

            return parkingClass.ParkingFee;
        }

        public static void Main(string[] args)
        {
            Parking parkingClass = new Parking();

            parkingClass.LongTermParkingOneTimeFee = 25;
            parkingClass.LongTermParkingOneDayFee = 40;
            parkingClass.ShortTermParkingFirstHourFee = 4;
            parkingClass.ShortTermParkingOneHourFee = 3;
            parkingClass.ShortTermParkingMaxFee = 40;

            GetParkingType(parkingClass);

            if (parkingClass.ParkingType == 1)
            {
                LongTermParking(parkingClass);

                Console.WriteLine($"Your total parking fee for {parkingClass.NumberOfDays} days would be: ${parkingClass.ParkingFee}.\nThank you, Visit again!");
            }
            else 
            {
                //short term
                Console.WriteLine("Please enter number of hours for parking: ");
                parkingClass.NumberOfHours = GetValidFloatInput();

                //if user exceeds short term plan limit
                if(parkingClass.NumberOfHours > 24)
                {
                    Console.WriteLine("You have exceeded short term parking limit. Redirecting to long term option...");
                    parkingClass.ParkingType = 1;
                    LongTermParking(parkingClass);
                    Console.WriteLine($"Your total parking fee for {parkingClass.NumberOfDays} days would be: ${parkingClass.ParkingFee}.\nThank you, Visit again!");
                }
                else
                {
                    //max limit fee for one day (24 hoours) 
                    if (parkingClass.NumberOfHours == 24)
                    {
                        parkingClass.ParkingFee = parkingClass.ShortTermParkingMaxFee;                        
                    }
                    //calculate short term parking fee for exactly 1 hour
                    else if (parkingClass.NumberOfHours == 1)
                    {
                        parkingClass.ParkingFee = parkingClass.ShortTermParkingFirstHourFee;
                    }
                    //calculate short term parking fee for 1 to 24 hours
                    else
                    {
                        parkingClass.ParkingFee = parkingClass.ShortTermParkingFirstHourFee + ((parkingClass.NumberOfHours - 1) * parkingClass.ShortTermParkingOneHourFee);
                    }
                    Console.WriteLine($"Your total parking fee for {parkingClass.NumberOfHours} hours would be: ${parkingClass.ParkingFee}.\nThank you, Visit again!");
                }                
            }
            Console.ReadLine();
        }
    }
}
