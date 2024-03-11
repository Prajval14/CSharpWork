using System;

namespace RealEstateManagementSystem
{
    class House : Residence
    {
        //Declaring the properties(attributes) with appropriate data types
        public int Garage;
        public bool Type; //true-Detached and false-NonDetached
        public bool Condition; //true-Sale and false-Rent
        public float houseCommission;

        //A no-arg constructor that creates a default house
        public House()
        {
            Garage = 1;
            Type = false;
            Condition = false;
        }

        //A constructor that creates a house with the specified garage, type and condition
        public House(int garage, bool type, bool condition)
        {
            Garage = garage;
            Type = type;    
            Condition = condition;
        }

        //A method that overrides the commission amount
        public override float CalculateCommission()
        {
            houseCommission = 3.5F;
            return houseCommission;
        }

        //A method to print out all available information about the current object
        public void PrintHouse()
        {
            Console.WriteLine($"Garage: {Garage}\nType: {Type}\nCondition: {Condition}");
        }
    }
}
