using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Ludo
    {
        protected List<Player> Players { get; set; }
        protected Dice Dice { get; set; }
        protected GameBoard Board { get; set; }

        public Ludo()
        {
            Board = new GameBoard();
            Players = new List<Player>()
            {
                new Player("Irfan","Y",Board.GetPositions("Y")),
                new Player("Mahmud","G",Board.GetPositions("G")),
                new Player("Ashik","B",Board.GetPositions("B")),
                new Player("AI","R",Board.GetPositions("R")),
            };
        }
        public void Play()
        {
            Board.Display();
        }
    }
}