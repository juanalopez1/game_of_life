using System;
using System.Collections;
using System.Dynamic;
using System.IO;

namespace Ucu.Poo.GameOfLife;

/*clase encargada de crear nuevas generaciones y conocer el tablero inicial */
public class Game
{
    public bool [,] Board {get; set;}
    public Game(bool [,] board)
    {
       this.Board = board;
    }
    public void NewGen()
    {    
        int boardWidth = Board.GetLength(0);
        int boardHeight = Board.GetLength(1);

        bool[,] cloneBoard = new bool[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && Board[i,j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(Board[x,y])
                {
                    aliveNeighbors--;
                }
                if (Board[x,y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneBoard[x,y] = false;
                }
                else if (Board[x,y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneBoard[x,y] = false;
                }
                else if (!Board[x,y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneBoard[x,y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneBoard[x,y] = Board[x,y];
                }
            }
        }
        this.Board = cloneBoard;
    
        

    }

}