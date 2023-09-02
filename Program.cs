using System;
using Main_Menu.controller;

class Program
{
    static void Main()
    {
        int slot = 0;
        while (true)
        {
            Console.Write("Masukan Jumlah Slot Parkir = ");
            string? slotInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(slotInput))
            {
                if (int.TryParse(slotInput, out slot))
                {
                    Console.WriteLine("Anda memasukkan angka: " + slot);
                    break;
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                }
            }
        }
        Console.Clear();
        MainMenu.menu(slot);
    }
}
