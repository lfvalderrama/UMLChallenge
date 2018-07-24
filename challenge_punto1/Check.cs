using System;

namespace challenge
{
    class Check: PaymentMethod
    {
        private int number;
        private int bankid;
        private String holder;

        public Check(int number, int bankid, string holder)
        {
            this.Number = number;
            this.Bankid = bankid;
            this.Holder = holder;
        }

        public int Number { get => number; set => number = value; }
        public int Bankid { get => bankid; set => bankid = value; }
        public string Holder { get => holder; set => holder = value; }
    }
}
