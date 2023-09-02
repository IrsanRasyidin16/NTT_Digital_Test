

namespace Status_Main_Menu.controller
{
    using System;
    using Parking_Model.model;
    using Status_Parking_Menu.controller;
    using Status_Vehicle_Menu.controller;
    using Input.utils;
    public class Status_Main_Menu
    {
        public static ParkingSlot[] StatusMenu(ParkingSlot[] parking)
        {
            bool exit = false;
            bool first = true;

            while (!exit)
            {   
                if (first)
                {
                    Console.WriteLine("----- Menu Status Parking -----");
                    Console.WriteLine("1. Status Parking Unavailable  ");
                    Console.WriteLine("2. Status Parking Available    ");
                    Console.WriteLine("3. Status Number Plate Vehicle ");
                    Console.WriteLine("4. Status Type Vehicle         ");
                    Console.WriteLine("5. Status Color Vehicle        ");
                    Console.WriteLine("0. Exit                        ");
                    Console.WriteLine("-------------------------------");
                }
                
                char userInput = Input.InputMenu();
                Console.Clear();
                first=false;
                switch (userInput)
                {
                    case '0':
                        exit = true;
                        Console.Clear();
                        break;
                    case '1':
                        Status_Parking_Menu.MainStatusParking(parking,userInput);
                        first=true;
                        break;
                    case '2':
                        Status_Parking_Menu.MainStatusParking(parking,userInput);
                        first=true;
                        break;
                    case '3':
                        Status_Vehicle_Menu.MainStatusVehicle(parking,userInput);
                        first=true;
                        break;
                    case '4':
                        Status_Vehicle_Menu.MainStatusVehicle(parking,userInput);
                        first=true;
                        break;
                    case '5':
                        Status_Vehicle_Menu.MainStatusVehicle(parking,userInput);
                        first=true;
                        break;
                    default:
                        Console.WriteLine("Menu yang tersedia: 0, 1, 2, 3, 4, 5");
                        break;
                }
            }
            Console.Clear();
            return parking;
        }
        
    }
}