using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_Assignment
{
    internal class Gameplay
    {
        //Receives the array of moves and returns nothing because it just prints the whole board in the method.
        public void PrintBoard(string[,] board)
        {
            //Prints the board in a grid based on the contents of the moves array.
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
        }

        //Receives the array of moves and checks for a winner, then returns a bool regarding whether the game is over.
        public bool CheckForWinner(string[,] board)
        {
            bool gameOver = false;

            //Checks rows and columns for a win and switches gameOver to true if there is one.
            for (int i = 0; i < 3; i++)
            {
                //Checks each row for a win.
                if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) && board[i,0] != " ")
                {
                    gameOver = true;
                    return gameOver;
                }
                //Checks each column for a win.
                else if ((board[0, i] == board[1, i] && board[1, i] == board[2, i]) && board[0, i] != " ")
                {
                    gameOver = true;
                    return gameOver;
                }
            }

            //Checks each diagonal for a win and switches gameOver to true if there is one.
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) && board[0, 0] != " ")
            {
                gameOver = true;
                return gameOver;
            }
            else if ((board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) && board[0, 2] != " ")
            {
                gameOver = true;
                return gameOver;
            }

            //If there was no win, gameOver will continue to be false.
            return gameOver;
        }
    }
}
