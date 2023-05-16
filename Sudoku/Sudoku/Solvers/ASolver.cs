using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal abstract class ASolver
    {
        protected List<Operator> Operators = new List<Operator>();
        private void GenerateOperators()
        {
            // restartos próbahiba teszteléséhez, ha zsákutcába ér, akkor újraindul
            //Operators.Add(new Operator(0, 1));
            //Operators.Add(new Operator(0, 2));

            // előző sorokhoz belerakva a végtelenségig megy, nem indul újra
            //Operators.Add(new Operator(1, 0));
            //Operators.Add(new Operator(1, 2));

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    for (int num = 1; num <= 9; num++)
                    {
                        Operators.Add(new Operator(row, col, num));
                    }
                }
            }
        }
        public ASolver()
        {
            GenerateOperators();
        }
        public abstract Operator SelectOperator();
        public abstract void Solve();
    }
}
