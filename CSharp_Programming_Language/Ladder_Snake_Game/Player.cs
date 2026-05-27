using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Programming_Language.Ladder_Snake_Game
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set;  }
        public int Id { get; set; }
        public Player(string name, int id)
        {
           this.Name = name;
           this.Score = 0;
           this.Id = id;
        }

        public int GetScore()
        {
            return this.Score;
        }
        public string GetPlayerName()
        {
            return this.Name;
        }
        public int GetPlayerId()
        {
            return this.Id;
        }
    }
}
