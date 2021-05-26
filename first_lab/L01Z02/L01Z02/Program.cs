using System;

namespace L01Z02
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto[] konta = new Konto[3];
            konta[0] = new Konto();
            konta[0].Wlasciciel = new Osoba();
            konta[0].Wlasciciel.Imie = "Eugene";
            konta[0].Wlasciciel.Nazwisko = "Denisow";
            Console.WriteLine("Zmiana pinu");
            Console.WriteLine($"{konta[0].ChangePin(0, 1111)}");
            Console.WriteLine($"{konta[0].ChangePin(1111, 1112)}");
            Console.WriteLine("Robimy wplaty na konto");
//          konta[0].Wplata(-2);
            konta[0].Wplata(100);
            Console.WriteLine($"Inforamcja o koncie: {konta[0].Information(1112)}");
            konta[0].Wplata(666);
            Console.WriteLine($"Inforamcja o koncie: {konta[0].Information(1112)}");
            Console.WriteLine("Robimy wyplaty z konta");
            Console.WriteLine($"{konta[0].Wyplata(1112, 666)}");
            Console.WriteLine($"Inforamcja o koncie: {konta[0].Information(1112)}");
            Console.WriteLine($"{konta[0].Wyplata(1112, 99)}");
            Console.WriteLine($"Inforamcja o koncie: {konta[0].Information(1113)}");
//          Console.WriteLine($"Inforamcja o koncie: {konta[0].Information(1113)}");
        }
    }
}
