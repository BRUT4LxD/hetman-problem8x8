using System;
using System.Diagnostics;
using System.Linq;

namespace HetmanProblem
{
    internal class Program
    {
        private static void Main()
        {
            Game game = new Game();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var solutions = game.Solve(13);
            
            stopwatch.Stop();

            Console.WriteLine("Execution time: " + stopwatch.ElapsedMilliseconds + "ms. ");
            Console.WriteLine("Found " + game.Solutions.Count + " solutions after rotation refinement");
            Console.ReadKey();
            BoardManager boardManager = new BoardManager(8);
            foreach (var item in solutions)
            {
                boardManager.PrintBoardWithHetmans(item.ToList());
            }
            Console.ReadKey();

        }
    }
}
