using System;

namespace TicTacToe
{
    /// <summary>
    /// Simulates a simple console 2-player tic-tac-toe game, with input
    /// from the players.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieve player information
            bool win = false;       // checks whether a player has one
            int currentPlayer = 1;  // tracks the current player
            string[] players = new string[] { "Player 1", "Player 2" }; // player identities
            char[] playerSymbols = new char[] { 'X', 'O' }; // corresponding player symbols

            // board matrix
            char[,] board = 
                { 
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'} }; 

            while (!win) 
            {
                
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Checks whether or a player, corresopnding to a symbol, has won the game.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        public static bool CheckWin(char symbol, char[,] board) 
        {
            bool horizontalWin = false;
            bool verticalWin = false;
            bool diagonalWin = false;

            // check horizontal
            for(int i = 0; i < board.GetLength(1); i++) 
            {
                int symbolLine = 0; // tracks the number of sequential symbol appearances

                for(int j = 0; j < board.GetLength(2); j++) 
                {
                    if (char.Equals(symbol, board[i, j])) symbolLine++;
                }

                if (symbolLine == 3) horizontalWin = true; break;
            }

            // check vertical
            if (!horizontalWin)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    int symbolLine = 0; // tracks the number of sequential symbol appearances

                    for (int j = 0; j < board.GetLength(2); j++)
                    {
                        if (char.Equals(symbol, board[j,i])) symbolLine++;
                    }

                    if (symbolLine == 3) verticalWin = true; break;
                }
            }

            //check diagonal
            if(!horizontalWin && !verticalWin) 
            {
                // bottom left to top right
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    int symbolLine = 0; // tracks the number of sequential symbol appearances

                    for (int j = 0; j < board.GetLength(2); j++)
                    {
                        if (char.Equals(symbol, board[i, j])) symbolLine++;
                    }

                    if (symbolLine == 3) horizontalWin = true; break;
                }
            }

            return horizontalWin || verticalWin || diagonalWin;
        }
    }
}
