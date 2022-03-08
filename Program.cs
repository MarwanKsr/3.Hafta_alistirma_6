using System;
namespace alistirma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[6] {"Marwan", "Omar", "Mohammed", "Yaman", "Aliaa", "Ahmad"};
            if (dizi.Contains("Marwan") == true)
            Console.WriteLine("Dizide yazdigin isim bulunuyordur");
            else
            Console.WriteLine("Dizide yazdigin isim bulunmuyordur");



        }
    }
}