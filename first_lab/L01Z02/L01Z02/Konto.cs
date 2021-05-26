using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace L01Z02
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;
    }
    class Konto
    {
        public Osoba Wlasciciel;
        public decimal Saldo = 0;
        public int Pin = 0;
        public static int IntLength(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }
        public bool CheckPin(int pin)
        {
            return this.Pin == pin;
        }
        public bool ChangePin(int oldPin,int newPin)
        {
            if (CheckPin(oldPin) == true) return true;
            Pin = newPin;
            return true;
        }
        public void Wplata(decimal kwota)
        {
            if (kwota < 0)
                throw new ArgumentException("Wplata nie może być ujemna");
            Saldo += kwota;
        }
        public string Wyplata(int pin,decimal kwota)
        {
            if((CheckPin(pin) == true) && (Saldo >= kwota))
            {
                Saldo -= kwota;
                return "Operacja zakończona";
            }
            else
            {
                return "Operacja anulowana";
            }
        }
        public string Information(int pin)
        {
            if(CheckPin(pin) == true)
            {
                return $"{Wlasciciel.Imie} {Wlasciciel.Nazwisko} ma na koncie {Saldo}";
            }
            else
            {
                return "Niepoprawny pin";
            }
        }
    }
