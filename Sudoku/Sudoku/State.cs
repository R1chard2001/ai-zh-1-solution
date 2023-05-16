using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class State:ICloneable
    {
        public int[,] game;
        public State()
        {
            game = (int[,])Settings.game.Clone();
        }

        public object Clone()
        {
            State newState = new State();
            newState.game = (int[,])game.Clone();
            return newState;
        }
        public bool IsTargetState()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (game[i,j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(game[i, j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is State))
                return false;

            State other = obj as State;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (game[i, j] != other.game[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
