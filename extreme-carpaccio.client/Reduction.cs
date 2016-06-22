using System;
using System.Security.Cryptography.X509Certificates;

namespace xCarpaccio.client
{
    public interface IReduction
    {
        Decimal CalculateReduction(Decimal totalDecimal);

    }
}