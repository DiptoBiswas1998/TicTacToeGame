using System;
namespace TicTacToeGame
{
    public class TicTacToe_Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TicTacToe Game!");
            char[] board = CreateBoard();
            Console.WriteLine("Board created.");
            char letter = ChooseLetter();
            Console.WriteLine("Your move: " + letter);
            Console.WriteLine("Showing Board: ");
            Showboard(board);
        }
        static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int spaceIndex = 1; spaceIndex < board.Length; spaceIndex++)
            {
                board[spaceIndex] = ' ';
            }
            return board;
        }
        static char ChooseLetter()
        {
            Console.WriteLine("Choose your move(O/X): ");
            char letter = Console.ReadLine()[0];
            while (letter != 'X' && letter != 'O' && letter != 'x' && letter != 'o')
            {
                Console.WriteLine("Invalid move. Choose again(O/X): ");
                letter = Console.ReadLine()[0];
            } 
            return letter;
        }
        static void Showboard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("__________");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("__________");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}
