using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace xCarpaccio.client
{
    class ReductionStandard : IReduction
    {
        public Decimal CalculateReduction(Decimal totalDecimal)
        {
            if(totalDecimal <= 1000)
            {
                return (Decimal) 0.03;
            }
            if (totalDecimal <= 5000)
            {
                return (Decimal)0.05;
            }
            if (totalDecimal <= 7000)
            {
                return (Decimal)0.07;
            }
            if (totalDecimal <= 10000)
            {
                return (Decimal)0.10;
            }
            return (Decimal)0.15;
        }
    }
}
