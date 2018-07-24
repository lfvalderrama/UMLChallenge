using System;

namespace challenge
{
    class CreditCard: PaymentMethod
    {
        private double number;
        private DateTime expDate;
        private int maxInstallements;
        private Issuer issuer;

        public CreditCard(double number, DateTime expDate, int maxInstallements, Issuer issuer)
        {
            this.Number = number;
            this.ExpDate = expDate;
            this.MaxInstallements = maxInstallements;
            this.Issuer = issuer;
        }

        public double Number { get => number; set => number = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }
        public int MaxInstallements { get => maxInstallements; set => maxInstallements = value; }
        public Issuer Issuer { get => issuer; set => issuer = value; }
    }
}
