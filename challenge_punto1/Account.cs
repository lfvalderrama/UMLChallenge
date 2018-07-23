using System;
using System.Collections.Generic;

namespace challenge
{
    class Account
    {
        private int id;
        private Customer customer;
        private AccountStatus status;
        private ShoppingCart cart;
        private List<Address> addresses = new List<Address>();
        private List<PaymentMethod> methods = new List<PaymentMethod>();

        public void addMethod(PaymentMethod p)
        {
            this.methods.Add(p);
        }

        public void addAddress(Address a)
        {
            this.addresses.Add(a);
        }
        public void destroyMethods()
        {
            this.methods = new List<PaymentMethod>();
        }
        public void destroyAddresses()
        {
            this.addresses = new List<Address>();
        }
    }
}
