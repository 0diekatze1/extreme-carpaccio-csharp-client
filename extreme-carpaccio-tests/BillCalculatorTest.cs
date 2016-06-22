using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using xCarpaccio.client;

namespace extreme_carpaccio_tests
{
    public class BillCalculatorTest
    {
        [Test]
        public void BillAllemagneTestBasique()
        {
            BillCalculator billCalculator = new BillCalculator();
            Order order = new Order()
            {
                Country = "DE",
                Prices = new Decimal[] {1, 1},
                Quantities = new[] {1, 2},
                Reduction = "STANDARD"
            };

            Country country = Country.InitCountry("DE");
            Assert.That(order.Prices.Select((t, i) => t * order.Quantities[i]).Sum(), Is.EqualTo(3));
            Assert.That(country.Reduction.CalculateReduction(3), Is.EqualTo(0.03));

            Decimal total = billCalculator.Calculate(order).total;
            
            Assert.That(total, Is.EqualTo((Decimal)3.492));



        } 
    }
}
