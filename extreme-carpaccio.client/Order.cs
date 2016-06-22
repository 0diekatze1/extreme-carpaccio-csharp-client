using System;

namespace xCarpaccio.client
{
    public class Order
    {
        public Decimal[] Prices { get; set; }
        public Int32[] Quantities { get; set; }
        public String Country { get; set; }
        public String Reduction { get; set; }
    }
}