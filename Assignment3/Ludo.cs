using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Ludo
    {
        protected List<Player> Players { get; set; }
        protected Dice Dice { get; set; }
        protected GameBoard Board { get; set; }

        public List<string> SurvivedGuties { get; set; }

        public Ludo()
        {
            Board = new GameBoard();
            SurvivedGuties = new List<string>();
            Players = new List<Player>()
            {
                new Player("Irfan","Y",Board.GetPositions("Y")),
                new Player("Mahmud","G",Board.GetPositions("G")),
                new Player("Ashik","B",Board.GetPositions("B")),
                new Player("AI","R",Board.GetPositions("R")),
            };
        }

        public int IsEligible(int dice, string name)
        {
            var b = Board.board;
            int cnt = 0,row,col;
            char c;
            if (name == "Irfan")
            {
                row = 6;
                col = 7;
                c = 'Y';
            }
            else if (name == "Mahmud")
            {
                row = 6;
                col = 34;
                c = 'G';
            }
            else if (name == "Ashik")
            {
                row = 24;
                col = 34;
                c = 'B';
            }
            else
            {
                row = 24;
                col = 7;
                c = 'R';
            }

            for (int i = row; i <= row + 1; i++)
            {
                for (int j = col; j <= col + 3; j += 3)
                {
                    if (b[i][j] != ' ')
                    {
                        cnt++;
                    }
                }
            }
            cnt += SurvivedGuties.Count(s => s[0] == c);
            cnt = 4 - cnt;
            if(dice == 6)
            {
                return cnt + 1;
            }
            return cnt;

        }

        private bool IsFinished()
        {
            int cnt = 0;
            int y = SurvivedGuties.Count(s => s[0] == 'Y');
            int g = SurvivedGuties.Count(s => s[0] == 'G');
            int b = SurvivedGuties.Count(s => s[0] == 'B');
            int r = SurvivedGuties.Count(s => s[0] == 'R'); 
            for (int i = 1; i <= 4; i++)
            {
                if (y == 4 || g == 4 || b == 4 || r == 4)
                {
                    cnt++;
                }
            }
            return cnt == 3;
        }
        private bool IsWon(string name)
        {
            int cnt;
            char c;
            if (name == "Irfan")
            {
                c = 'Y';
            }
            else if (name == "Mahmud")
            {
                c = 'G';
            }
            else if (name == "Ashik")
            {
                c = 'B';
            }
            else
            {
                c = 'R';
            }
            cnt = SurvivedGuties.Count(s => s[0] == c);
            return cnt == 4;
        }
        public void Play()
        {
            while (!IsFinished())
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    if (!IsWon(Players[i].Name))
                    {
                        while (true)
                        {
                            Board.Display();
                            Console.Write(Players[i].Name + " To roll your Dice Press any key: ");
                            Console.Read();
                            int diceno = Dice.Roll();
                            int eligible = IsEligible(diceno, Players[i].Name);
                            if (eligible == 1)
                            {
                                Board.MoveGuti(diceno, )
                            }
                            else if (eligible > 1)
                            {
                                Console.WriteLine("Your Dice is : " + diceno + "Enter       your guti: ");
                                string guti = Console.ReadLine();
                            }

                            if (diceno != 6)
                            {
                                break;
                            }
                        }

                    }
                }
            }
        }
    }
}