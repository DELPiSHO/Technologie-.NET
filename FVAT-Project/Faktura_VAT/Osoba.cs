using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Faktura_VAT
{
    public class Osoba
    {
        public string Nazwa_Firmy { get; set; }
        public string Adres { get; set; }
        public long NIP { get; set; }
    }
    public class Klient : Osoba
    {
        public string _email;
        public string Email {
        get
            {
                return _email;
            }
        set
            {
                if (value.Contains("mail.ru"))
                    _email = value;
                else
                    throw new ArgumentException("Niepoprawny Email");
            }
        }

    }
    public class Sprzedawca : Osoba
    {
        public long _kontoBankowe;
        public long KontoBankowe {
        get
            {
                return _kontoBankowe;
            }
        set
            {
                if (value.ToString().Length == 15)
                    _kontoBankowe = value;
                else
                    throw new ArgumentException("Niepoprawny numer konta bankowego");
            }
        }

    }
}
