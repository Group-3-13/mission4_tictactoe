// Authors: Jakob Blosil, Ethan Hoopes, Oluchi Ochulo, Grace Ogden
// Description: tic tac toe game


// Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");

class Program
{
    // Create a game board array to store the players’ choices
    static char[] board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
    
    static void Main(string[] args)
    {
        int choice;
        // Call the function to display the Tic Tac Toe board
        DisplayTicTacToeBoard();

        // Ask each player in turn for their choice and update the game board array
        for (int i = 0; i <= 8; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Player 1, where would you like to go?");
                choice = int.Parse(Console.ReadLine()) - 1;
                board[choice] = 'X';
            }
            else
            {
                Console.WriteLine("Player 2, where would you like to go?");
                choice = int.Parse(Console.ReadLine()) - 1;
                board[choice] = 'O';
            }
                
        }
    }

    
    // this might belong in the game class
    static void DisplayTicTacToeBoard()
    {
        
        Console.WriteLine("Tic Tac Toe Board:");
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {3} | {4} | {5} ", board[3], board[4], board[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {6} | {7} | {8} ", board[6], board[7], board[8]);
    }
}





// Print the board by calling the method in the supporting class

// Check for a winner by calling the method in the supporting class,
// and notify the players when a win has occurred and which player won the game

// winning combos:
// [1,2,3], [4,5,6], [7,8,9], [1,4,7], [2,5,8], [3,6,9], [1,5,9], [3,8,7]
 
