using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Operator
    {
        public int row;
        public int col;
        public int number;

        public Operator(int row, int col, int number)
        {
            this.row = row;
            this.col = col;
            this.number = number;
        }

        public bool IsAplicable(State state)
        {
            if (state.game[row,col] != 0)
            {
                return false;
            }

            // sor, oszlop
            for (int i = 0; i < 9; i++)
            {
                if (state.game[row, i] == number)
                {
                    return false;
                }
                if (state.game[i, col] == number)
                {
                    return false;
                }
            }

            int blockX = col / 3;
            int blockY = row / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (state.game[blockY * 3 + i, blockX * 3 + j] == number)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public State Apply(State state)
        {
            State newState = (State)state.Clone();
            newState.game[row, col] = number;
            return newState;
        }
    }
}
