using System;

namespace Main_Menu.controller
{
    using Parking_Model.model; 
    using CheckIn_Menu.controller;
    using CheckOut_Menu.controller;
    using Status_Main_Menu.controller;
    using Input.utils;

    public class MainMenu
    {
       

        public static void menu(int slot)
        {
            bool exit = false;
            bool first = true;
            ParkingSlot[] parking = new ParkingSlot[slot];
            
            while (!exit)
            {   
                if (first)
                {
                    Console.WriteLine("----- Main Menu -----");
                    Console.WriteLine("1. Check-In Vehicle  ");
                    Console.WriteLine("2. Check-Out Vehicle ");
                    Console.WriteLine("3. Status Parking    ");
                    Console.WriteLine("0. Exit              ");
                    Console.WriteLine("---------------------");
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
                        parking = CheckIn_Menu.ChechkIn(parking);
                        first=true;
                        break;
                    case '2':
                        parking = CheckOut_Menu.CheckOut(parking);
                        first=true;
                        break;
                    case '3':
                        parking = Status_Main_Menu.StatusMenu(parking);
                        first=true;
                        break;
                    default:
                        Console.WriteLine("Menu yang tersedia: 0, 1, 2, 3");
                        break;
                }
            }
        }
    }
}
