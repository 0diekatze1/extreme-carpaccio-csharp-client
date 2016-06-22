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
            Country country = new Country {Code = order.Country};
            country.TvaDecimal = Country.InitTva(country.Code);

            return _calculate(country, order); ;
        }

        private Bill _calculate(Country country, Order order)
        {

            if (validOrder(order))
            {
                Decimal total = order.Prices.Select((t, i) => t*order.Quantities[i]).Sum();
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