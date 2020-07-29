using System;

namespace Common
{
    public class CashHandler
    {
        public bool DeliverCashEnvelope(string personName, decimal amount)
        {
            // dispatch an accounting cash release.
            Console.WriteLine($"A cash withdrawal of {amount} will be handed to employee {personName}");
            return true;
        }
    }
}