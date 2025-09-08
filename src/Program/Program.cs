using System;

namespace Ucu.Poo.GameOfLife
{
    public class Motor
    {
        Cell[,] gameBoard = new Cell[,];/* contenido del tablero */;
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);

        Cell[,] cloneboard = new Cell[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j].Alive)
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y].Alive)
                {
                    aliveNeighbors--;
                }

                if (gameBoard[x, y].Alive && aliveNeighbors < 2)
                {
                    
                    cloneboard[x, y] = new Cell(false);
                }
                else if (gameBoard[x, y].Alive && aliveNeighbors > 3)
                {
                    
                    cloneboard[x, y] = new Cell(false);
                }
                else if (!gameBoard[x, y].Alive && aliveNeighbors == 3)
                {
                    
                    cloneboard[x, y] = new Cell(true);
                }
                else
                {
                    
                    cloneboard[x, y] = new Cell(gameBoard[x, y].Alive);
                }
            }
        }

        gameBoard = cloneboard; // reemplaza el tablero original con la nueva generación
    }
}
