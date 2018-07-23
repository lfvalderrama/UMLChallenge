using System;

namespace challenge
{
    class CreditCard: PaymentMethod
    {
        private double number;
        private DateTime expDate;
        private int maxInstallements;
        private Issuer issuer;
    }
}
