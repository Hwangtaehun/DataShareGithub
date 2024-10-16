using System;

namespace CnslApp
{
    class PackerMaker
    {
        public string msg;
        public PackerMaker(string m) { msg = m; }

        public string MakePacket()
        {
            Prefixer prfixer = new Prefixer();
            msg = prfixer.AddPrefix(msg);
            return msg;
        }

        class Prefixer
        {
            public Prefixer() { }
            public string AddPrefix(string msg)
            {
                return "147.6.15.2/20:" + msg;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string message = "God is good.";
            
            PackerMaker pcktmaker = new PackerMaker(message);

            string packet = pcktmaker.MakePacket();

            Console.WriteLine($"packet: {packet}");
        }
    }
}