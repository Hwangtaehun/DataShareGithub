using System;

namespace CnslApp
{
    class Player
    {
        static string teamName = "TeamHeaven";
        static int numPlyr = 0;
        string position;

        public Player(string p)
        {
            Player.numPlyr++;
            this.position = p;
        }

        public static string GetTeamName() { return Player.teamName; }
        public int GetNumPlayer() { return Player.numPlyr; }
        public string GetPosition() { return this.position; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Player.GetTeamName());

            Player tom = new Player("Forward");
            Player jerry = new Player("Defender");

            Console.WriteLine(tom.GetNumPlayer());
            Console.WriteLine(jerry.GetNumPlayer());
            Console.WriteLine(tom.GetPosition());
        }
    }
}