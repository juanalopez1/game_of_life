using System;
using System.Collections;
using System.IO;

namespace Ucu.Poo.GameOfLife;
/* clase responsable de crear tablero nuevo a partir del archivo y convertir los 1 y 0 de este 
en true o false */
public class BoardCreator
{
    
    public static bool[,] GenerateBoard()
    {
        string url = "board.txt";
        string urlContent = File.ReadAllText(url);
        string[] contentLines = urlContent.Split('\n');
        bool[,] Board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    Board[x,y]=true;
                }
            }
        }
        return Board;

    }
}

