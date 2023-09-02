using System;

namespace Status_Vehicle_Menu.controller
{
    using Parking_Model.model;
    using System.Text.RegularExpressions;
    using Input.utils;
    using System.Runtime.CompilerServices;

    public class Status_Vehicle_Menu
    {
        public static void MainStatusVehicle(ParkingSlot[] parking, char menu)
        {            
            switch (menu)
            {
                case '3':
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine("Event for 1, Odd For 2 : ");
                        char userInput = Input.InputChar();
                        if(userInput=='1')
                        {
                            EventVehicle(parking);
                            break;
                        } else if(userInput=='2')
                        {
                            OddVehicle(parking);
                            break;
                        }else{
                            Console.WriteLine("Only 1 or 2 Press Any to Key Continue");
                            Console.ReadKey(true);
                        }
                        
                    }    
                    break;
                case '4':
                    TypeVehicle(parking);
                    break;   
                case '5':
                    Colorvehicle(parking);
                    break;
                default:
                    break;
            }
        }
        public static void Colorvehicle(ParkingSlot[] parking)
        {
            List<int> vehicle = Input.CheckVehicle(parking);
            string? color;
            bool exist=false;            
            while (true)
            {
                Console.Write("Color : ");
                color = Console.ReadLine();
                Console.Clear();
                if (color=="")
                {
                    Console.WriteLine("input cannot be empty");
                }else
                {
                    break;
                }
            }
            foreach (var item in vehicle)
            {
                if (parking[item].Vehicle.Color==color)
                {
                    if (!exist)
                    {
                        Console.WriteLine($"Vehicle With {color} Color Parked On ");
                        exist=true;
                    }
                    Console.Write($"Slot\t: {parking[item].Slot} ");
                }
            }            
            if(!exist)
            {
                Console.Write($"there are no {color} vehicles in the parking lot");
            }
            Console.WriteLine();
            Input.PressAnyKeyToContinue();
        }
        public static void TypeVehicle(ParkingSlot[] parking)
        {
            List<int> vehicle = Input.CheckVehicle(parking);
            int Motor=0; int Mobil=0;
                        foreach (var item in vehicle)
            {
                if (parking[item].Vehicle.Type=="Motor")
                {
                    Motor++;
                } else
                {
                    Mobil++;
                }
            }
            Console.WriteLine($"Motor : {Motor}, Mobil : {Mobil}");            
            Input.PressAnyKeyToContinue();
        }
        public static void EventVehicle(ParkingSlot[] parking)
        {
            
            List<string> numbersOnly = new List<string>();
            List<int> vehicle = Input.CheckVehicle(parking);
            bool exist=false;
            if(vehicle.Count==0)
            {
                Console.WriteLine("Parking lot still empty");
                Input.PressAnyKey();
                return;
            }
            Console.Clear();
            foreach (var item in vehicle)
            {
                numbersOnly.Add(Regex.Replace(parking[item].Vehicle.NumberPlate, @"[^\d]", ""));
            }
            for (int i = 0; i < numbersOnly.Count; i++)
            {
                
                if(int.Parse(numbersOnly[i])%2==0)
                {
                    if(!exist)
                    {   
                        Console.WriteLine("List vehicle with Event number plate");
                    }
                    Console.WriteLine($"Slot {i+1}. {parking[vehicle[i]].Vehicle.NumberPlate}");
                    exist=true;
                }
                
            }
            if(!exist)
            {
                Console.WriteLine("There Are no Event Number Plates In The Parking Lot");
                Input.PressAnyKey();
                return;
            }
            Input.PressAnyKeyToContinue();
        }
        public static void OddVehicle(ParkingSlot[] parking)
        {
            List<string> numbersOnly = new List<string>();
            List<int> vehicle = Input.CheckVehicle(parking);
            bool exist=false;
            if(vehicle.Count==0)
            {
                Console.WriteLine("Parking lot still empty");
                Input.PressAnyKey();
                return;
            }
            Console.Clear();
            foreach (var item in vehicle)
            {
                numbersOnly.Add(Regex.Replace(parking[item].Vehicle.NumberPlate, @"[^\d]", ""));
            }
            for (int i = 0; i < numbersOnly.Count; i++)
            {
                
                if(int.Parse(numbersOnly[i])%2!=0)
                {
                    if(!exist)
                    {
                        Console.WriteLine("List vehicle with Odd number plate");
                    }
                    Console.WriteLine($"Slot {i+1}. {parking[vehicle[i]].Vehicle.NumberPlate}");
                    exist=true;
                }
                
            }
            if(!exist)
            {
                Console.WriteLine("There Are no Odd Number Plates In The Parking Lot");
                Input.PressAnyKey();
                return;
            }
            Input.PressAnyKeyToContinue();
        }
    }
}