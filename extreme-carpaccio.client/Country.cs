using System;
using System.Diagnostics;

namespace xCarpaccio.client
{
    public class Country
    {
        public String Code;

        public Decimal TvaDecimal;

        public IReduction Reduction;

        public static Country InitCountry(String code, Order order)
        {
            Country country = null;
            switch(code)
            {
                
                case "DE":
                    country = new Country();
                    country.TvaDecimal = (Decimal) 0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "FR":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "IT":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.25;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "ES":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.19;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "PL":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.21;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "RO":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "NL":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "BE":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.24;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "EL":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "CZ":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.19;
                    country.Reduction = calculateReduction(order, country);
                    break;

                case null:
                    return null;
                    break;
            }
            return country;
        }

        private static IReduction calculateReduction(Order order, Country country)
        {
            return  order.Reduction.ToUpper() == "PAY THE PRICE" ? country.Reduction = new ReductionPayThePrice() : new ReductionStandard();
        }
    }
}