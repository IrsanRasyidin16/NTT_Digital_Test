using Vehicle_Model.model;

namespace Parking_Model.model
{
    public struct ParkingSlot
    {
        public int Slot;
        public int Biling;
        public Vehicle Vehicle;

        public void Display()
        {
            Console.Write($"{Slot}\t{Biling}\t");
            Vehicle.Display();
        }

        public void Create()
        {
            Vehicle.Create();
            if (Vehicle.Type=="Motor")
            {
                Biling=2000;
            } 
            else if (Vehicle.Type=="Mobil")
            {
                Biling=5000;
            }
        }

        public void Out()
        {
            Slot=0;
            Biling=0;
            Vehicle.Out();
        }
    }

    
}
