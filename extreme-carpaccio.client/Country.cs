using System;
using System.Diagnostics;

namespace xCarpaccio.client
{
    public class Country
    {
        public String Code;

        public Decimal TvaDecimal;

        public IReduction Reduction;

        public static Country InitCountry(String code)
        {
            Country country = new Country();
            switch(code)
            {
                case "DE":
                    country.TvaDecimal = 20;
                    country.Reduction = new ReductionStandard();
                    break;
                case null:
                    break;
            }
            return country;
        }
    }
}