using System;
using System.Security.Cryptography.X509Certificates;

namespace Things
{
    public class Machine
    {
        public int pub = 10;
        private int pri = 20;
        internal int intr = 30;
        protected int pro = 40;
        protected internal int proIntr = 50;
        private protected int priPro = 60;

        public void AccessData()
        {
            pub = 20;
            pri = 30;
            intr = 40;
            pro = 50;
            proIntr = 60;
            priPro = 70;
        }

        public void SetPri(int i) { this.pri = i; }
    }

    public class Robot : Machine
    {
        public void ModifyData()
        {
            pub = 20;
            intr = 40;
            pro = 50;
            proIntr = 60;
            priPro = 70;
        }
    }

    class Mower
    {
        public void AccessData()
        {
            Machine mcn = new Machine();
            mcn.pub = 20;
            mcn.SetPri(30);
            mcn.intr = 40;
            mcn.proIntr = 60;
        }
    }
}

namespace Vehicle
{
    public class Car : Things.Machine
    {
        public void ModifyData()
        {
            pub = 20;
            intr = 40;
            pro = 50;
            proIntr = 60;
            priPro = 70;
        }
    }
}