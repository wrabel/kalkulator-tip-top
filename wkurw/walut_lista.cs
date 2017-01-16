using System.Collections.Generic;

namespace wkurw
{
    public sealed class walut_lista
    {
        private static List<waluty> _items = null;

        public static List<waluty> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new List<waluty>
                    {
                        new waluty { SC="EUR", e_nazwa="Euro"},
                        new waluty { SC="PLN", e_nazwa="Polish Zloty"},
                        new waluty { SC="USD", e_nazwa="US Dollar"},
                        new waluty { SC="AUD", e_nazwa="Australian Dollar"},
                        new waluty { SC="JPY", e_nazwa="Japanese Yen"},
                        new waluty { SC="BGN", e_nazwa="Bulgarian Lev"},
                        new waluty { SC="BRL", e_nazwa="Brazilian Real"},
                        new waluty { SC="CAD", e_nazwa="Canadian Dollar"},
                        new waluty { SC="CHF", e_nazwa="Swiss Franc"},
                        new waluty { SC="CNY", e_nazwa="Chinese Yuan"},
                        new waluty { SC="CZK", e_nazwa="Czech Koruna"},
                        new waluty { SC="DKK", e_nazwa="Danish Krone"},
                        new waluty { SC="GBP", e_nazwa="British Pound"},
                        new waluty { SC="HKD", e_nazwa="Hong Kong Dollar"},
                        new waluty { SC="HRK", e_nazwa="Croation Kuna"},
                        new waluty { SC="HUF", e_nazwa="Hungarian Forint"},
                        new waluty { SC="IDR", e_nazwa="Indonesian Rupiah"},
                        new waluty { SC="ILS", e_nazwa="Israeli New Shekel"},
                        new waluty { SC="INR", e_nazwa="Indian Rupee"},
                        new waluty { SC="KRW", e_nazwa="South Korean Won"},
                        new waluty { SC="MXN", e_nazwa="Mexican Peso"},
                        new waluty { SC="MYR", e_nazwa="Malaysian Ringgit"},
                        new waluty { SC="NOK", e_nazwa="Norwegian Kroner"},
                        new waluty { SC="NZD", e_nazwa="New Zealand Dollar"},
                        new waluty { SC="PHP", e_nazwa="Philippene Peso"},
                        new waluty { SC="RON", e_nazwa="Romanian New Lei"},
                        new waluty { SC="RUB", e_nazwa="Russian Ruble"},
                        new waluty { SC="SEK", e_nazwa="Swedish Krona"},
                        new waluty { SC="SGD", e_nazwa="Singapore Dollar"},
                        new waluty { SC="THB", e_nazwa="Thai Baht"},
                        new waluty { SC="TRY", e_nazwa="Turkish New Lira"},
                        new waluty { SC="ZAR", e_nazwa="South African Rand"}
                    };
                }
                return _items;
            }
        }
    }
}