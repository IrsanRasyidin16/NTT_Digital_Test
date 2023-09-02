namespace Vehicle_Model.model
{
    public struct Vehicle
    {
        public string Nama;
        public string NumberPlate;
        public string Type;
        public string Color;

        public void Display()
        {
            Console.WriteLine($"{Nama}\t{NumberPlate}\t{Type}\t{Color}");
        }

        public void Create()
        {            
            string? input ="\0";
            while(true)
            {
                Console.Write("Type Motor/Mobil: ");
                input = Console.ReadLine();
                if (input!=null)
                {   
                
                    if (input=="Motor" || input=="Mobil")
                    {
                        Type=input;
                        break;
                    }
                    Console.WriteLine("Type Only Has Motor / Mobil");
                }
            }
            Console.Write($"Name {Type}\t: ");
            input = Console.ReadLine();
            if (input!=null)
            {
                Nama=input;
            }
            Console.Write("Number Plate\t: ");
            input = Console.ReadLine();
            if (input!=null)
            {
                NumberPlate=input;
            }
            
            Console.Write($"Color {Type}\t: ");
            input = Console.ReadLine();
            if (input!=null)
            {
                Color=input;
            }
        }

        public void Out()
        {
            Nama="";
            NumberPlate="";
            Type="";
            Color="";
        }
    }
}
