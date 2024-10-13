using System;

namespace CnslApp
{
    class Human
    {
        string face;
        string upperBody;
        string lowerBody;
        
        public Human(string f, string u, string l)
        {
            face = f;
            upperBody = u;
            lowerBody = l;
        }

        public void Talk()
        {
            Console.WriteLine("Talk");
        }

        public void Kick()
        {
            Console.WriteLine("Kick");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Ball
    {
        int size;
        string shape;
        string color;

        public Ball(int s, string shp, string clr)
        {
            size = s;
            shape = shp;
            color = clr;
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Roll()
        {
            Console.WriteLine("Roll");
        }

        public void Pop()
        {
            Console.WriteLine("Pop");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human rebekah = new Human("laughing", "skyBlouse", "grayPants");
            Human isaac = new Human("smiling", "orangeShirt", "bluePants");
            Ball ball = new Ball(30, "pentagon", "black");
            rebekah.Kick();
            ball.Fly();
            isaac.Run();
        }
    }
}