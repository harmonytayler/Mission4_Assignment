using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_Assignment
{
    internal class Gameplay
    {
        // Receive the "board" array from the driver (Program) class.

        // Contain a method that prints the board based on the information passed to it.
        public void PrintBoard(string[,] board)
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
        }

        public bool CheckForWinner(string[,] board)
        {
            bool gameOver = false;
            int spacesFilled = 0;

            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) && board[i,0] != " ")
                {
                    if (board[i, 0] == "O")
                    {
                        Console.Write("Player 1 is the winner!");
                        gameOver = true;
                        return gameOver;
                    }
                    else
                    {
                        Console.Write("Player 2 is the winner! >:)");
                        gameOver = true;
                        return gameOver;
                    }
                }
                else if ((board[0, i] == board[1, i] && board[1, i] == board[2, i]) && board[0, i] != " ")
                {
                    if (board[0, i] == "O")
                    {
                        Console.Write("Player 1 is the winner!");
                        gameOver = true;
                        return gameOver;
                    }
                    else
                    {
                        Console.Write("Player 2 is the winner! >:)");
                        gameOver = true;
                        return gameOver;
                    }
                }
            }

            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) && board[0, 0] != " ")
            {
                if (board[0, 0] == "O")
                {
                    Console.Write("Player 1 is the winner! >:)");
                    gameOver = true;
                    return gameOver;
                }
                else
                {
                    Console.Write("Player 2 is the winner! >:)");
                    gameOver = true;
                    return gameOver;
                }
            }
            else if ((board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) && board[0, 2] != " ")
            {
                if (board[0, 2] == "O")
                {
                    Console.Write("Player 1 is the winner! >:)");
                    gameOver = true;
                    return gameOver;
                }
                else
                {
                    Console.Write("Player 2 is the winner! >:)");
                    gameOver = true;
                    return gameOver;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "O" || board[i, j] == "X")
                    {
                        spacesFilled++;
                    }
                }
            }

            if (spacesFilled >= 9)
            {
                Console.WriteLine("It's a tie?! :|");
                gameOver = true;
            }

            return gameOver;
        }
    }
}
