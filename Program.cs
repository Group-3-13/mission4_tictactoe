// Authors: Jakob Blosil, Ethan Hoopes, Oluchi Ochulo, Grace Ogden
// Description: tic tac toe game
using System;
using mission4_tictactoe;

public partial class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        //initialize tracker for number of moves
        int totalMoves = 0;

        for (int i = 0; i <= 8; i++)
        {
            Game.DisplayTicTacToeBoard(board);

            if (i % 2 == 0)
            {
                Console.WriteLine("Player 1, where would you like to go?");
            }
            else
            {
                Console.WriteLine("Player 2, where would you like to go?");
            }

            int choice = int.Parse(Console.ReadLine()) - 1;

            //check if spot is already taken
            if (board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = (i % 2 == 0) ? 'X' : 'O';
                totalMoves++; //incrememnt if valid move was made
            }
            else
            {
                Console.WriteLine("This spot is already taken.Please choose another spot.");
                i--; //decrement to redo the player's turn
                continue;
            }

            string result = Game.CheckWinner(board);
            if(result != "No winner")
            {
                //display final board 
                Game.DisplayTicTacToeBoard(board);
                //display results
                Console.WriteLine(result);
                //exit loop if theres a winner
                break; 
            }
            
            if (totalMoves == 9 && result == "No winner") 
            {
                Console.WriteLine("The game is a draw!");
                break;
            }
        }
    }
}