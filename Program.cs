// Authors: Jakob Blosil, Ethan Hoopes, Oluchi Ochulo, Grace Ogden
// Description: tic tac toe game


// Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Create a game board array to store the players’ choices
string[] choices;

// Ask each player in turn for their choice and update the game board array
for (int i=0; i <=8; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Player 1, enter your move");
        Console.ReadLine();
    }
}

// Print the board by calling the method in the supporting class

// Check for a winner by calling the method in the supporting class,
// and notify the players when a win has occurred and which player won the game

// winning combos:
// [1,2,3], [4,5,6], [7,8,9], [1,4,7], [2,5,8], [3,6,9], [1,5,9], [3,8,7]
 
