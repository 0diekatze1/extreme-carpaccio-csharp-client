using System;
using System.Linq;

namespace xCarpaccio.client
{
    public class BillCalculator
    {
        public Bill Calculate(Order order)
        {
            if (order == null) return null;
            Country country = Country.InitCountry(order.Country, order);
            if (country != null) return _calculate(country, order);
             return null;
        }

        private Bill _calculate(Country country, Order order)
        {


            if (ValidOrder(order))
            {
                Decimal total = order.Prices.Select((t, i) => t*order.Quantities[i]).Sum();
                total += (total*country.TvaDecimal); //Prix TTC
                total -= (total*country.Reduction.CalculateReduction(total)); //reduc
                Bill returnBill = new Bill {total = total};

                return returnBill;
            }
            else
            {
                return null;
            }      
        }

        private static Boolean ValidOrder(Order order)
        {
            return (order.Prices.Length == order.Quantities.Length);
        }
    }
}