// Authors: Jakob Blosil, Ethan Hoopes, Oluchi Ochulo, Grace Ogden
// Description: tic tac toe game
using System;
using System.Xml.Serialization;
using mission4_tictactoe;

public partial class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    static void Main(string[] args)
    {
        //welcome user to the game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        //initialize tracker for number of moves
        int totalMoves = 0;

        //gameplay loop iterating for 9 turns 
        for (int i = 0; i <= 8; i++)
        {

            Game.DisplayTicTacToeBoard(board);

            //alternate between player 1 and player 2
            if (i % 2 == 0)
            {
                Console.WriteLine("Player 1, where would you like to go?");
            }
            else
            {
                Console.WriteLine("Player 2, where would you like to go?");
            }

            int choice = -1;
            bool validInput = false;
            while(!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9)
                {
                    // adjust for zero based indexing
                    choice -= 1;

                    //check if spot is already taken
                    if (board[choice] != 'X' && board[choice] != 'O')
                    {
                        validInput = true;
                        board[choice] = (i % 2 == 0) ? 'X' : 'O';
                        totalMoves++; //incrememnt if valid move was made
                    }
                    else
                    {
                        Console.WriteLine("This spot is already taken.Please choose another spot.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9");
                }
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
        }

    }
}