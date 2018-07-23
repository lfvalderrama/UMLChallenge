using System;

namespace challenge
{
    class DebitCard: PaymentMethod
    {
        private double number;
        private DateTime expDate;
        private Issuer issuer;
    }
}
