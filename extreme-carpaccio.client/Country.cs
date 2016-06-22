using System;
using System.Diagnostics;

namespace xCarpaccio.client
{
    public class Country
    {
        public String Code;

        public Decimal TvaDecimal;

        public static Decimal InitTva(String code)
        {
            Decimal Tva = -1;
            switch(code)
            {
                case "DE":
                    Tva = 20;
                    break;
                case null:
                    break;
            }
            return Tva;
        }
    }
}