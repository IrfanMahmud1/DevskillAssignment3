using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Ludo
    {
        public static void PrintBoard()
        {
            StringBuilder[] board = new StringBuilder[31];
            board[0] = new StringBuilder("###############################################");
            board[1] = new StringBuilder("#                 #  |  |  #                  #");
            board[2] = new StringBuilder("#                 #--|--|--#                  #");
            board[3] = new StringBuilder("#                 #  |  |  #                  #");
            board[4] = new StringBuilder("#    YELLOW       #--|--|--#     BLUE         #");
            board[5] = new StringBuilder("#                 #  |  |  #                  #");
            board[6] = new StringBuilder("#    -------      #--|--|--#    -------       #");
            board[7] = new StringBuilder("#    |  |  |      #  |  |  #    |  |  |       #");
            board[8] = new StringBuilder("#    |  |  |      #--|--|--#    |  |  |       #");
            board[9] = new StringBuilder("#    -------      #  |  |  #    -------       #");
            board[10] = new StringBuilder("#                 #--|--|--#                  #");
            board[11] = new StringBuilder("#                 #  |  |  #                  #");
            board[12] = new StringBuilder("###################---------####################");
            board[13] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[14] = new StringBuilder("#--################         ################--#");
            board[15] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[16] = new StringBuilder("#--################         ################--#");
            board[17] = new StringBuilder("#  |  |  |  |  |  |         |  |  |  |  |  |  #");
            board[18] = new StringBuilder("#--################---------################--#");
            board[19] = new StringBuilder("#                  #  |  |  #                 #");
            board[20] = new StringBuilder("#                  #--|--|--#                 #");
            board[21] = new StringBuilder("#    GREEN         #  |  |  #     RED         #");
            board[22] = new StringBuilder("#                  #--|--|--#                 #");
            board[23] = new StringBuilder("#    -------       #  |  |  #    -------      #");
            board[24] = new StringBuilder("#    |  |  |       #--|--|--#    |  |  |      #");
            board[25] = new StringBuilder("#    |  |  |       #  |  |  #    |  |  |      #");
            board[26] = new StringBuilder("#    -------       #--|--|--#    -------      #");
            board[27] = new StringBuilder("#                  #  |  |  #                 #");
            board[28] = new StringBuilder("#                  #--|--|--#                 #");
            board[29] = new StringBuilder("#                  #  |  |  #                 #");
            board[30] = new StringBuilder("###############################################");
            /*
            "###############################################",
            "#                 #  |  |  #                  #",
            "#                 #--|--|--#                  #",
            "#     YELLOW      #  |  |  #      BLUE        #",
            "#                 #--|--|--#                  #",
            "#     -------     #  |  |  #     -------      #",
            "#     |  |  |     #--|--|--#     |  |  |      #",
            "#     |  |  |     #  |  |  #     |  |  |      #",
            "#     -------     #--|--|--#     -------      #",
            "#                 #  |  |  #                  #",
            "#                 #--|--|--#                  #",
            "#                 #  |  |  #                  #",
            "###################__|__|__###################",
            "#  |  |  |  |  |  |         |  |  |  |  |  |  #",
            "#--################         ################--#",
            "#  |  |  |  |  |  |         #  |  |  |  |  |  #",
            "#--################         ################--#",
            "#  |  |  |  |  |  |         |  |  |  |  |  |  #",
            "#--################---------################--#",
            "#                  #  |  |  #                 #",
            "#                  #--|--|--#                 #",
            "#     GREEN        #  |  |  #      RED        #",
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
            foreach (var line in board)
            {
                Console.WriteLine(line);
            }
        }
    }
}