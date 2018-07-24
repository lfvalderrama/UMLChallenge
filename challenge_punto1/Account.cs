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

        internal Customer Customer { get => customer; set => customer = value; }
        public AccountStatus Status { get => status; set => status = value; }
        internal ShoppingCart Cart { get => cart; set => cart = value; }
        internal List<Address> Addresses { get => addresses; set => addresses = value; }
        internal List<PaymentMethod> Methods { get => methods; set => methods = value; }

        public Account(Customer customer, AccountStatus status, ShoppingCart cart, List<Address> addresses, List<PaymentMethod> methods)
        {
            this.Customer = customer;
            this.Status = status;
            this.Cart = cart;
            this.Addresses = addresses;
            this.Methods = methods;
        }

        public void addMethod(PaymentMethod p)
        {
            this.Methods.Add(p);
        }

        public void addAddress(Address a)
        {
            this.Addresses.Add(a);
        }
        public void destroyMethods()
        {
            this.Methods = new List<PaymentMethod>();
        }
        public void destroyAddresses()
        {
            this.Addresses = new List<Address>();
        }
    }
}
