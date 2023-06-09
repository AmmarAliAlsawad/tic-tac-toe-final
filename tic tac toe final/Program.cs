using System;

namespace TicTacToe
{
    internal class Program
    {
        static int[] board = new int[9]; // initialize the game board

        static void Main(string[] args)
        {
            // clear the game board
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            // get player's symbol
            Console.WriteLine("Choose your symbol (X or O):");
            string playerSymbol = Console.ReadLine().ToUpper();

            // get player's turn preference
            Console.WriteLine("Do you want to go first? (Y/N):");
            bool playerFirst = (Console.ReadLine().ToUpper() == "Y");

            int userTurn = -1;
            int computerTurn = -1;
            Random rand = new Random();

            // start the game loop
            while (checkForWinner() == 0)
            {
                // player's turn
                if (playerFirst)
                {
                    // get user's turn
                    while (userTurn == -1 || board[userTurn] != 0)
                    {
                        Console.WriteLine("Please enter a number from 0 to 8");
                        userTurn = int.Parse(Console.ReadLine());
                        Console.WriteLine("You typed " + userTurn);
                    }
                    board[userTurn] = (playerSymbol == "X") ? 1 : 2;
                    printBoard(); // print the updated game board
                }

                // computer's turn
                while ((computerTurn == -1) || (board[computerTurn] != 0))
                {
                    computerTurn = rand.Next(9);
                }
                board[computerTurn] = (playerSymbol == "X") ? 2 : 1;
                Console.WriteLine("Computer chooses " + computerTurn);
                printBoard(); // print the updated game board

                // switch turn order
                playerFirst = true;
                userTurn = -1;
                computerTurn = -1;
            }

            // announce the winner
            string winner = (checkForWinner() == 1) ? playerSymbol : (playerSymbol == "X") ? "O" : "X";
            Console.WriteLine("Player " + winner + " won the game!");
        }

        // check for a winner and return the player number or 0 if no winner
        private static int checkForWinner()
        {
            // check rows
            for (int i = 0; i <= 6; i += 3)
            {
                if (board[i] != 0 && board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                {
                    return board[i];
                }
            }

            // check columns
            for (int i = 0; i <= 2; i++)
            {
                if (board[i] != 0 && board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                {
                    return board[i];
                }
            }

            // check diagonals
            if (board[0] != 0 && board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            if (board[2] != 0 && board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }

            return 0;
        }


        // print the game board
        private static void printBoard()
        {
            Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8] + " ");
        }
    }
}
