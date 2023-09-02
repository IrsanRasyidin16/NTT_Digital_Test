using System;

namespace CheckIn_Menu.controller
{
    using Parking_Model.model;
    using Input.utils;

    public class CheckIn_Menu
    {
       public static ParkingSlot[] ChechkIn(ParkingSlot[] parking)
       {
            List<int> available = Input.CheckEmptySlot(parking);
            if (available.Count==0)
            {
                Console.Clear();
                Console.WriteLine("Sorry, parking lot is full");
                Input.PressAnyKeyToContinue();
                return parking;
            }
            Console.Clear();
            foreach (var item in available)
            {
                Console.WriteLine($"Parking lot {item+1} is available");
            }
            while(true)
            {
                Console.Write("Input : ");
                string? input = Console.ReadLine();
                int.TryParse(input, out int inputInt);
                bool isValueIn = available.Contains(inputInt-1);
                if (isValueIn)
                {
                    parking[inputInt-1].Slot=inputInt;
                    parking[inputInt-1].Create();
                    Console.WriteLine("Check In Success");
                    break;
                } else
                {
                    Console.WriteLine("Input salah");
                }                
            }
            Input.PressAnyKeyToContinue();
            return parking;
       } 
    }
}