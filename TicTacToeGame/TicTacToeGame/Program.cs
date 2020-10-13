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
    }
}
