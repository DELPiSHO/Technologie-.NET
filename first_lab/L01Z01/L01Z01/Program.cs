using System;
using System.Runtime.CompilerServices;

namespace L01Z01
{
    class Program
    {
        static void Main(string[] args)
        {
         Punkt p1 = new Punkt(2, 5);
         Punkt p2 = new Punkt(5, 9);
         Punkt p3 = new Punkt(5, 7);
         Console.WriteLine($"[{p1}, {p2}] = {p1.dist(p2)}");
         Console.WriteLine(p2.Odleglosc());
         Console.WriteLine(p2.OdlegloscPunktu(p1));         
        }
    }
}
