using System;
using System.Collections;
using System.IO;
using System.Threading;
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game(BoardCreator.GenerateBoard());
            while (true)
            {
                game.NewGen();
                BoardPrinter.PrintBoard(game.Board);
                Thread.Sleep(300);
            }
    
        }
    }
}
