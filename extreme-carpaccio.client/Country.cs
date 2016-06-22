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
                case "PT":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.23;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "HU":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.27;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "SE":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.23;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "AT":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.22;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "BG":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.21;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "DK":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.21;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "FI":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.17;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "SK":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.18;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "IE":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.21;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "LT":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.23;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "SI":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.24;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "LV":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "EE":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.22;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "CY":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.21;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "LU":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.25;
                    country.Reduction = calculateReduction(order, country);
                    break;
                case "MT":
                    country = new Country();
                    country.TvaDecimal = (Decimal)0.20;
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