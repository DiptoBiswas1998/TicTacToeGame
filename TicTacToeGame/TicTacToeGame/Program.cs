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
            bool toss = Toss();
            if(toss == true)
            {
                char letter = ChooseLetter();
                Console.WriteLine("Your move: " + letter);
                int moveIndex = MakeMove(board);
                Console.WriteLine("Showing Board: ");
                Showboard(board, moveIndex, letter);
            }
        }
        static bool Toss()
        {
            int chooseToss;
            Random random = new Random();
            do
            {
                Console.WriteLine("Enter 0 or 1: ");
                chooseToss = Convert.ToInt32(Console.ReadLine());
            } while (chooseToss != 1 && chooseToss != 0);
            int toss = random.Next(0, 2);
            if(toss == chooseToss)
            {
                Console.WriteLine("You Win.");
                return true;
            }
            else
            {
                Console.WriteLine("Computer Won.");
                return false;
            }
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
            char letter = Char.ToUpper(Console.ReadLine()[0]);
            while (letter != 'X' && letter != 'O')
            {
                Console.WriteLine("Invalid move. Choose again(O/X): ");
                letter = Char.ToUpper(Console.ReadLine()[0]);
            }
            return letter;
        }
        static int MakeMove(char[] board)
        {
            int moveIndex;
            Console.WriteLine("Enter index where to make move(1-9): ");
            moveIndex = Convert.ToInt32(Console.ReadLine());
            while (moveIndex < 1 | moveIndex > 9)
            {
                Console.WriteLine("Invalid index. Choose again(1-9): ");
                moveIndex = Convert.ToInt32(Console.ReadLine());
            }
            while (board[moveIndex] != ' ')
            {
                Console.WriteLine("Space not empty.\nEnter index where to make move(1-9): ");
                moveIndex = Convert.ToInt32(Console.ReadLine());
            }
            return moveIndex;
        }
        static void Showboard(char[] board, int moveIndex, char letter)
        {
            board[moveIndex] = letter;
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("__________");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("__________");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}