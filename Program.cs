using Mission4_Assignment;

Gameplay gameplay = new Gameplay();

char[,] moves = new char[3, 3];// Create a game board array to store the players' choices.
string board = "";
int playerTurn = 1;
int playerNumber = 1;
bool played = false;
bool gameOver = false;


// Welcome the user to the game.
Console.WriteLine("Welcome to Tic Tac Toe");

// Ask each player in turn for their choice and update the game board array.
do
{
    int row;
    int col;
    
    if (playerTurn % 2 == 1) //If turn # is odd
    {
        Console.WriteLine("Player 1, your turn!");
        playerNumber = 1;
    }
    if (playerTurn % 2 == 0) //if turn # is even
    {
        Console.WriteLine("Player 2, your turn");
        playerNumber = 2;
    }

    do
    {
        Console.WriteLine("Choose a row to play: 1, 2, or 3");
        row = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a column to play: 1, 2, or 3");
        col = int.Parse(Console.ReadLine());
        if (string.IsNullOrEmpty(moves[row, col].ToString()))
        {
            if (playerNumber == 1)
            {
                moves[row, col] = 'O';
            }

            if (playerNumber == 2)
            {
                moves[row, col] = 'X';
            }
            // Print the board by calling the method in the supporting (Gameplay) class.
            board = gameplay.PrintBoard(moves, playerNumber);
            
            played = true;
        }
        else
        {
            Console.WriteLine("Invalid move, please try again.");
        }
        
        // Print the board by calling the method in the supporting (Gameplay) class.
        board = gameplay.PrintBoard(moves, playerNumber);
        
    } while (!played);

    // Check for a winner by calling the method in the supporting (Gameplay) class,
    if (gameplay.CheckForWinner(board))
    {
        // and notify the players when a win has occurred and which player one the game.
        Console.WriteLine($"Congratulations! Player {playerNumber} has won the game!");
        gameOver = true;
    }
    if ((playerTurn == 9))
    {
        // Bonus Note: should probably also have an option to account for a tie game.
        Console.WriteLine("Game Over! You tied.");
        gameOver = true;
    }
    
    playerTurn++;
    
} while (!gameOver);

Console.WriteLine("Game over, thanks for playing!");