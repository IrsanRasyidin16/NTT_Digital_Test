using System;

namespace CheckOut_Menu.controller
{
    using Parking_Model.model;
    using Input.utils;

    public class CheckOut_Menu{
        public static ParkingSlot[] CheckOut(ParkingSlot[] parking)
        {
            List<int> Unavailable = Input.CheckVehicle(parking);
            if(Unavailable.Count==0)
            {
                Console.Clear();
                Console.WriteLine("Parking lot still empty, feel free to park");
                Input.PressAnyKey();
                return parking;
            }
            Console.Clear();
            foreach (var item in Unavailable)
            {
                Console.WriteLine($"Parking lot {item+1} filled with vehicles {parking[item].Vehicle.NumberPlate}");
            }
            while(true)
            {
                Console.Write("Input : ");
                string? input = Console.ReadLine();
                int.TryParse(input, out int inputInt);
                bool isValueIn = Unavailable.Contains(inputInt-1);
                if (isValueIn)
                {
                    int total = parking[inputInt-1].Biling * 3;
                    Console.Clear();
                    parking[inputInt-1].Out();
                    Console.WriteLine("Check Out Success With Billing : Rp."+total);
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