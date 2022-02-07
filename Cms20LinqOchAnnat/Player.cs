using System;
using System.Collections.Generic;

namespace Cms20LinqOchAnnat
{

    //public class SmallPlayer
    //{
    //    public string Name { get; set; }
    //    public int Points { get; set; }

    //}

    public class Player
    {
        //private int age;
        //private readonly int age;

        //private static int MaxAge = 49;

        public string Name { get; set; }
        public string Season { get; set; }
        public string Team { get; set; }
        public string Shoots { get; set; } 
        public string Position { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }

        public List<GameResult> BestGames{ get; set; }
    }

    public class GameResult
    {
        public DateTime Date { get; set; }

        public string AgainstTeam { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }

}