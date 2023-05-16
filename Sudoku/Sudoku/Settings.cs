using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    static class Settings
    {
        public static void init()
        {
            game = new int[9, 9];
            game[0, 0] = 5;
            game[0, 1] = 6; // ha 0 sokáig tart, 6
            game[0, 2] = 0;
            game[0, 3] = 0;
            game[0, 4] = 4;
            game[0, 5] = 0;
            game[0, 6] = 7;
            game[0, 7] = 0;
            game[0, 8] = 0;

            game[1, 0] = 0;
            game[1, 1] = 0;
            game[1, 2] = 2;
            game[1, 3] = 0;
            game[1, 4] = 7;
            game[1, 5] = 9;
            game[1, 6] = 0;
            game[1, 7] = 3;
            game[1, 8] = 0;

            game[2, 0] = 7;
            game[2, 1] = 0;
            game[2, 2] = 8;
            game[2, 3] = 0;
            game[2, 4] = 5;
            game[2, 5] = 0;
            game[2, 6] = 4;
            game[2, 7] = 2;
            game[2, 8] = 0;

            game[3, 0] = 0;
            game[3, 1] = 0;
            game[3, 2] = 4;
            game[3, 3] = 0;
            game[3, 4] = 3;
            game[3, 5] = 0;
            game[3, 6] = 0;
            game[3, 7] = 7;
            game[3, 8] = 8;

            game[4, 0] = 0;
            game[4, 1] = 8;
            game[4, 2] = 7;
            game[4, 3] = 0;
            game[4, 4] = 0;
            game[4, 5] = 0;
            game[4, 6] = 0;
            game[4, 7] = 1;
            game[4, 8] = 2;

            game[5, 0] = 3;
            game[5, 1] = 2;
            game[5, 2] = 1;
            game[5, 3] = 0;
            game[5, 4] = 0;
            game[5, 5] = 8;
            game[5, 6] = 0;
            game[5, 7] = 4;
            game[5, 8] = 0;

            game[6, 0] = 1;
            game[6, 1] = 3;
            game[6, 2] = 0;
            game[6, 3] = 9;
            game[6, 4] = 0;
            game[6, 5] = 0;
            game[6, 6] = 2;
            game[6, 7] = 6;
            game[6, 8] = 0;

            game[7, 0] = 0;
            game[7, 1] = 7;
            game[7, 2] = 0;
            game[7, 3] = 6;
            game[7, 4] = 0;
            game[7, 5] = 4;
            game[7, 6] = 0;
            game[7, 7] = 0;
            game[7, 8] = 3;

            game[8, 0] = 2;
            game[8, 1] = 4;
            game[8, 2] = 0;
            game[8, 3] = 0;
            game[8, 4] = 0;
            game[8, 5] = 0;
            game[8, 6] = 0;
            game[8, 7] = 9;
            game[8, 8] = 7;
        }
        public static int[,] game;
    }
}
