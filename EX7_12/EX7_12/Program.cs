using System;

namespace Data
{
    partial class PrtClass
    {
        public int iVal;
        public PrtClass()
        {
            this.iVal = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrtClass prt = new PrtClass();
            prt.PrintIVal();
        }
    }
}