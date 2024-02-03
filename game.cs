using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mission4_tictactoe
{
    public class Game
    {
        // Receive the “board” array from the driver class

        // Contain a method that prints the board based on the information passed to it
        public static void DisplayTicTacToeBoard(char[] board)
        {

            Console.WriteLine("Tic Tac Toe Board:");
            Console.WriteLine( board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine("-----------");
            Console.WriteLine( board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);

            if (board.Length != 9)
            {
                Console.WriteLine("Error: Board does not contain 9 elements.");
                return;
            }
        }


        // Contain a method that receives the game board array as input
        // and returns if there is a winner and who it was
        public static string CheckWinner(char[] board)
        {
            //use board indices to determine winning combinations 
            int[,] winCombinations = new int[,]
            {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // rows
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // columns
                {0, 4, 8}, {2, 4, 6}             // diagonals
            };

            for (int i=0; i< winCombinations.GetLength(0); i++)
            {
                //check if any winning combination is met 
                if (board[winCombinations[i, 0]] == board[winCombinations[i, 1]] &&
                    board[winCombinations[i, 1]] == board[winCombinations[i, 2]] &&
                    board[winCombinations[i, 0]] != ' ')
                {
                    //return player1 or player2 based on the winner 
                    return board[winCombinations[i, 0]] == 'X' ? "Player 1 wins!" : "Player 2 wins";    
                }
            }

            //check for a draw
            bool isBoardFull = true;
            foreach (char spot in board)
            {
                if (spot != 'X' && spot != 'O')
                {
                    isBoardFull = false;
                    break;
                }
            }
            return isBoardFull ? "It's a tie!" : "No winner"; 
        }
    }
}
