using System.Text;
using System;
using Ucu.Poo.GameOfLife;
using System.Data;

namespace Ucu.Poo.GameOfLife;
/* clase encargada de imprimir el tablero */
public class BoardPrinter
{
    public static void PrintBoard(bool[,] board)
    {   
        int boardWidth = board.GetLength(0);
        int boardHeight = board.GetLength(1);
        Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<boardHeight;y++)
            {
                for (int x = 0; x<boardWidth; x++)
                {
                    if(board[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            
    }
}
