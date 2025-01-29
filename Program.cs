using Mission4_Assignment;

Gameplay gameplay = new Gameplay();

string[,] moves = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };// Create a game board array to store the players' choices.
string board = "";
int playerTurn = 1;
int playerNumber = 1;
bool validInput = false;
bool played = false;
bool gameOver = false;
bool gameWon = false;


// Welcome the user to the game.
Console.WriteLine("Welcome to Tic Tac Toe");

// Ask each player in turn for their choice and update the game board array.
do
{
    int row;
    int col;
    
    if (playerTurn % 2 == 1) //If turn # is odd, player 1s turn
    {
        Console.WriteLine("Player 1, your turn!");
        playerNumber = 1;
    }
    if (playerTurn % 2 == 0) //if turn # is even, player 2s turn
    {
        Console.WriteLine("Player 2, your turn");
        playerNumber = 2;
    }


    do
    {
        do
        {
            Console.WriteLine("Choose a row to play: 1, 2, or 3");
            row = int.Parse(Console.ReadLine());
            if (row < 1 || row > 3)
            {
                Console.WriteLine("Invalid row number!");
                validInput = false;
            }
            else
            {
                validInput = true;
            }
        } while (validInput == false);

        do
        {
            Console.WriteLine("Choose a column to play: 1, 2, or 3");
            col = int.Parse(Console.ReadLine());
            if (col < 1 || col > 3)
            {
                Console.WriteLine("Invalid column number!");
                validInput = false;
            }
            else
            {
                validInput = true;
            }
        }while (validInput == false);

        if (moves[row-1,col-1] == " ")
        {
            if (playerNumber == 1)
            {
                moves[row-1, col-1] = "O";
            }

            if (playerNumber == 2)
            {
                moves[row-1, col-1] = "X";
            }
            
            played = true;
        }
        else
        {
            Console.WriteLine("Invalid move, please try again.");
            played = false;
        }
        
        // Print the board by calling the method in the supporting (Gameplay) class.
        gameplay.PrintBoard(moves);
        
    } while (!played);

    // Check for a winner by calling the method in the supporting (Gameplay) class,
    if (gameplay.CheckForWinner(moves))
    {
        gameWon = true;
        // and notify the players when a win has occurred and which player one the game.
        Console.WriteLine($"Congratulations! Player {playerNumber} has won the game!");
        gameOver = true;
    }
    if ((playerTurn == 9))
    {
        // Bonus Note: should probably also have an option to account for a tie game.
        Console.WriteLine("You tied.");
        gameOver = true;
    }
    
    playerTurn++;
    
} while (!gameOver);

Console.WriteLine("Game over, thanks for playing!");