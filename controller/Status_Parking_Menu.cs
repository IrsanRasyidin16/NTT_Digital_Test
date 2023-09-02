using System;

namespace Status_Parking_Menu.controller
{
    using Parking_Model.model;
    using Input.utils;
    public class Status_Parking_Menu{
        public static void MainStatusParking(ParkingSlot[] parking, char menu)
        {
            switch (menu)
            {
                case '1':
                    ParkingUnavailableMenu(parking);
                    break;
                case '2':
                    ParkingAvailableMenu(parking);
                    break;   
                default:
                    break;
            }
        }
        public static void ParkingUnavailableMenu(ParkingSlot[] parking)
        {
            List<int> vehicle = Input.CheckVehicle(parking);   
            if(vehicle.Count==0)
            {                
                Console.WriteLine("Parking lot still empty");                
                Input.PressAnyKey();
                return;
            }            
            Console.WriteLine("Parking Slot Filled : "+vehicle.Count);
            Console.WriteLine("Slot\tBiling\tName\tNumber Plate\tType\tColor");
            foreach (var item in vehicle)
            {                
                parking[item].Display();
            }
            Input.PressAnyKeyToContinue();
            
        }
        public static void ParkingAvailableMenu(ParkingSlot[] parking)
        {
            int available = Input.CheckSlotParking(parking);          
            if(available==0)
            {
                Console.WriteLine("Parking lot is full");                
                Input.PressAnyKeyToContinue();
                return;
            }
            Console.WriteLine("Parking Slot Available : "+available);
            Input.PressAnyKeyToContinue();
        }
    }
    
}