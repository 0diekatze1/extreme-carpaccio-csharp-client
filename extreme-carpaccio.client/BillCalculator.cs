using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using Nancy.IO;

namespace xCarpaccio.client
{
    public class BillCalculator
    {
        public Bill Calculate(Order order)
        {
            Country country = Country.InitCountry(order.Country);

            return _calculate(country, order); ;
        }

        private Bill _calculate(Country country, Order order)
        {

            if (validOrder(order))
            {
                Decimal total = 0;
                total = order.Prices.Select((t, i) => t*order.Quantities[i]).Sum(); // PrixHT
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

        private Boolean validOrder(Order order)
        {
            return (order.Prices.Length == order.Quantities.Length);
        }
    }
}