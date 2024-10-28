using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class GameBoard
    {
        public StringBuilder[] board { get; set; }

        public GameBoard()
        {
            board = new StringBuilder[31];
            board[0] = new StringBuilder("###############################################");
            board[1] = new StringBuilder("#                 #  |  |  #                  #");
            board[2] = new StringBuilder("#                 #--|--|--#                  #");
            board[3] = new StringBuilder("#     YELLOW      #  |  |  #      GREEN       #");
            board[4] = new StringBuilder("#                 #--|--|--#                  #");
            board[5] = new StringBuilder("#     -------     #  |  |  #     -------      #");
            board[6] = new StringBuilder("#     |Y1|Y2|     #--|--|--#     |G1|G2|      #");
            board[7] = new StringBuilder("#     |Y3|Y4|     #  |  |  #     |G3|G4|      #");
            board[8] = new StringBuilder("#     -------     #--|--|--#     -------      #");
            board[9] = new StringBuilder("#                 #  |  |  #                  #");
            board[10] = new StringBuilder("#                 #--|--|--#                  #");
            board[11] = new StringBuilder("#                 #  |  |  #                  #");
            board[12] = new StringBuilder("###################---------###################");
            board[13] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[14] = new StringBuilder("#--################         ################--#");
            board[15] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[16] = new StringBuilder("#--################         ################--#");
            board[17] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[18] = new StringBuilder("###################---------###################");
            board[19] = new StringBuilder("#                  #  |  |  #                 #");
            board[20] = new StringBuilder("#                  #--|--|--#                 #");
            board[21] = new StringBuilder("#       RED        #  |  |  #     BLUE        #");
            board[22] = new StringBuilder("#                  #--|--|--#                 #");
            board[23] = new StringBuilder("#     -------      #  |  |  #    -------      #");
            board[24] = new StringBuilder("#     |R1|R2|      #--|--|--#    |B1|B2|      #");
            board[25] = new StringBuilder("#     |R3|R4|      #  |  |  #    |B3|B4|      #");
            board[26] = new StringBuilder("#     -------      #--|--|--#    -------      #");
            board[27] = new StringBuilder("#                  #  |  |  #                 #");
            board[28] = new StringBuilder("#                  #--|--|--#                 #");
            board[29] = new StringBuilder("#                  #  |  |  #                 #");
            board[30] = new StringBuilder("###############################################");

            /*
           "###############################################",
           "#                 #  |  |  #                  #",
           "#                 #--|--|--#                  #",
           "#                 #  |  |  #                  #",
           "#                 #--|--|--#                  #",
           "#     -------     #  |  |  #     -------      #",
           "#     |  |  |     #--|--|--#     |  |  |      #",
           "#     |  |  |     #  |  |  #     |  |  |      #",
           "#     -------     #--|--|--#     -------      #",
           "#                 #  |  |  #                  #",
           "#                 #--|--|--#                  #",
           "#                 #  |  |  #                  #",
           "###################__|__|__####################",
           "#  |  |  |  |  |  |         |  |  |  |  |  |  #",
           "#--################         ################--#",
           "#  |  |  |  |  |  |         #  |  |  |  |  |  #",
           "#--################         ################--#",
           "#  |  |  |  |  |  |         |  |  |  |  |  |  #",
           "#--################---------################--#",
           "#                  #  |  |  #                 #",
           "#                  #--|--|--#                 #",
           "#                  #  |  |  #                 #",
           "#                  #--|--|--#                 #",
           "#     -------      #  |  |  #     -------     #",
           "#     |  |  |      #--|--|--#     |  |  |     #",
           "#     |  |  |      #  |  |  #     |  |  |     #",
           "#     -------      #--|--|--#     -------     #",
           "#                  #  |  |  #                 #",
           "#                  #--|--|--#                 #",
           "#                  #  |  |  #                 #",
           "###############################################"
       };
           */
        }

        
        public List<(int, int, int)> GetPositions(string key)
        {
            List<(int, int, int)> pos = new List<(int, int, int)>();
            if (key == "Y")
            {
                pos = [(6, 7, 8), (6, 10, 11), (7, 7, 8), (7, 10, 11)];
            }
            else if (key == "G")
            {
                pos = [(6, 34, 35), (6, 37, 38), (7, 34, 35), (7, 37, 38)];
            }
            else if (key == "B")
            {
                pos = [(24, 34, 35), (24, 37, 38), (25, 34, 35), (25, 37, 38)];
            }
            else
            {
                pos = [(24, 7, 8), (24, 10, 11), (25, 7, 8), (25, 10, 11)];
            }
            return pos;
        }

        public (int,int,int) MoveGuti(int dice, string guti, (int,int,int) pos)
        {
            return (0,0,0);
        }
        public void Display()
        {
            foreach (var line in board)
            {
                Console.WriteLine(line);
            }
            /* Console.WriteLine(board[24][7] + "" + board[24][8]);
             Console.WriteLine(board[24][10] + "" + board[24][11]);
             Console.WriteLine(board[25][7] + "" + board[25][8]);
             Console.WriteLine(board[25][10] + "" + board[25][11]);*/
        }
    }
}
