using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.init();
            Console.WriteLine(new State()); ;
            ASolver solver = new BacktrackWithDepthLimit(int.MaxValue);
            solver.Solve();
            Console.ReadLine();
        }
    }
}
