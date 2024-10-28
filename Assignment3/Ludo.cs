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

        public List<string> IsEligible(int dice, string name)
        {
            var b = Board.board;
            List<String> list = new List<String>();
            int cnt = 0, row, col;
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

            if (dice == 6)
            {
                for (int m = row; m <= row + 1; m++)
                {
                    for (int n = col; n <= col + 3; n += 3)
                    {
                        if (b[m][n] != ' ')
                        {
                            list.Add(b[m][n] + "" + b[m][n + 1]);
                        }
                    }
                }
            }
            if (list.Count < 4)
            {
                for (int i = 1; i <= 4; i++)
                {
                    bool check = SurvivedGuties.Any(x => x == c + "" + i);
                    if (!check)
                    {
                        int j, SRow, SCol, ERow, ECol;
                        if (name == "YELLOW")
                        {
                            j = 0;
                            SRow = 15;
                            ERow = 15;
                            SCol = 1;
                            ECol = 19;
                        }
                        else if (name == "GREEN")
                        {
                            j = 1;
                            SRow = 1;
                            ERow = 13;
                            SCol = 21;
                            ECol = 21;
                        }
                        else if (name == "BLUE")
                        {
                            j = 2;
                            SRow = 15;
                            ERow = 15;
                            SCol = 44;
                            ECol = 26;
                        }
                        else
                        {
                            j = 3;
                            SRow = 29;
                            ERow = 17;
                            SCol = 21;
                            ECol = 21;
                        }
                        foreach (var item in Players[j].CurrentPosition)
                        {
                            if (SRow == ERow && SRow == item.Value.Item1)
                            {
                                if (SCol < ECol && item.Value.Item2 + 3 * dice <= ECol)
                                {
                                    list.Add(item.Key);
                                }
                                else if (SCol > ECol && item.Value.Item2 - 3 * dice >= ECol)
                                {
                                    list.Add(item.Key);
                                }
                            }
                            else if (SCol == ECol && SCol == item.Value.Item2)
                            {
                                if (SRow > ERow && item.Value.Item1 + 3 * dice <= ERow)
                                {
                                    list.Add(item.Key);
                                }
                                else if (SRow < ERow && item.Value.Item1 - 3 * dice >= ERow)
                                {
                                    list.Add(item.Key);
                                }
                            }

                            list.Add(list.Any(x => x != item.Key) ? item.Key : "");
                        }
                    }
                }
            }

            return list;

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
        public void IsFree(string guti, (int,int,int) pos, int player)
        {
            int row = pos.Item1, col1 = pos.Item2, col2 = pos.Item3;
            var b = Board.board;
            for (int m = row; m <= row + 1; m++)
            {
                for (int n = col1; n <= col1 + 3; n += 3)
                {
                    if (b[m][n] == guti[0] && b[m][col2] == guti[1])
                    {
                        foreach(var x in Players[player].StartPosition)
                        {
                            x.Value.Add(guti);
                        }
                    }
                }
            }
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
                            List<string> eligible = IsEligible(diceno, Players[i].Name);

                            string guti = "";

                            if (eligible.Count > 1)
                            {
                                Console.WriteLine("Your Dice is : " + diceno + "  Enter your guti: ");
                                bool flag;
                                while (true)
                                {
                                    guti = Console.ReadLine().ToUpper();
                                    flag = eligible.Any(x => x == guti);
                                    if (flag)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Not eligible! Please type again");
                                }
                            }
                            else if (eligible.Count == 1)
                            {
                                guti = eligible[0];
                            }
                            if (eligible.Count != 0)
                            {
                                if(diceno == 6)
                                {
                                    IsFree(guti, Players[i].CurrentPosition[guti],i);
                                }
                                (int, int, int) pos = Board.MoveGuti(diceno, guti, Players[i].CurrentPosition[guti]);
                                Players[i].CurrentPosition[guti] = pos;
                                for (int j = 0; j < 4; j++)
                                {
                                    foreach (var x in Players[j].StartPosition)
                                    {
                                        if (x.Value.Any(x => x == guti))
                                        {
                                            x.Value.Remove(guti);
                                            break;
                                        }
                                        if (x.Key == pos)
                                        {
                                            x.Value.Add(guti);
                                            break;
                                        }
                                    }
                                }
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