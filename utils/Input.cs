namespace Input.utils
{
    using Parking_Model.model;
    public class Input
    {
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press Any to Key Continue");
            PressAnyKey();
        }

        public static void PressAnyKey()
        {
            Console.ReadKey(true);
            Console.Clear();
        }
        public static char InputChar()
        {
            char userInput = '\0';
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            userInput = keyInfo.KeyChar;
            return userInput;
        }
        public static char InputMenu()
        {            
            Console.WriteLine("Input menu : ");
            return InputChar();
        }
        public static List<int> CheckVehicle(ParkingSlot[] parking)
        {
            List<int> vehicle = new List<int>();
            for (int i = 0; i < parking.Length; i++)
            {
                if (parking[i].Slot!=0)
                {
                    vehicle.Add(i);
                }
            }
            return vehicle;
        }
        public static List<int> CheckEmptySlot(ParkingSlot[] parking)
        {
            List<int> Slot = new List<int>();
            for (int i = 0; i < parking.Length; i++)
            {
                if (parking[i].Slot==0)
                {
                    Slot.Add(i);
                }
            }
            return Slot;
        }
        public static int CheckSlotParking(ParkingSlot[] parking)
        {
            int slot =0;
            for (int i = 0; i < parking.Length; i++)
            {
                if (parking[i].Slot==0)
                {
                    slot++;
                }
            }
            return slot;
        }
        
    }
}