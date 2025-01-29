using Mission4_Assignment;

Gameplay gameplay = new Gameplay();

//Sets up game board array and other variables to be used throughout.
string[,] moves = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
int playerTurn = 1;
int playerNumber = 1;
bool validInput = false;
bool played = false;
bool gameOver = false;
bool gameWon = false;


// Welcome the user to the game.
Console.WriteLine("Welcome to Tic Tac Toe");

//Continues until someone wins the game or it ends in a tie.
do
{
    //Sets up variables to store move position choices.
    int row;
    int col;
    
    //Checks turn number to make sure the turn switches between players each time.
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

    //Continues until the player has successfully made a move.
    do
    {
        // Continues until a valid row is chosen.
        do
        {
            Console.WriteLine("Choose a row to play: 1, 2, or 3");
            string input = Console.ReadLine();
            if (int.TryParse(input, out row) && (row >= 1 && row <= 3))
            {
                validInput = true; //Row must be an integer between 1 and 3.
            }
            else
            {
                Console.WriteLine("Invalid row number! Please enter 1, 2, or 3.");
                validInput = false; 
            }
        } while (!validInput);

        // Continues until a valid column is chosen.
        do
        {
            Console.WriteLine("Choose a column to play: 1, 2, or 3");
            string input = Console.ReadLine();

            if (int.TryParse(input, out col) && (col >= 1 && col <= 3))
            {
                validInput = true; //Column must be an integer between 1 and 3.
            }
            else
            {
                Console.WriteLine("Invalid column number! Please enter 1, 2, or 3.");
                validInput = false;
            }
        } while (!validInput);

        //Checks whether the selected position is currently empty.
        if (moves[row-1,col-1] == " ")
        {
            //If it's player 1's turn, fills the spot with an O.
            if (playerNumber == 1)
            {
                moves[row-1, col-1] = "O";
            }
            //If it's player 2's turn, fills the spot with an X.
            if (playerNumber == 2)
            {
                moves[row-1, col-1] = "X";
            }
            
            //Switches the played variable to true once a move has been made.
            played = true;
        }
        //If the spot has already been filled, asks for a new position to be selected.
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
        //Tells the players who won the game based on who made the winning move.
        Console.WriteLine($"Congratulations! Player {playerNumber} has won the game!");
        gameOver = true;
    }
    if ((playerTurn == 9))
    {
        //If the game board is full, ends the game with a "tie" message.
        Console.WriteLine("You tied.");
        gameOver = true;
    }
    
    //Increments the player turn variable so that it'll be the next players turn on the next round.
    playerTurn++;
    
} while (!gameOver);

//Message to close out the game.
Console.WriteLine("Game over, thanks for playing!");