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
    }
}
