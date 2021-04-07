using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to Play?");

            char[,] TicTacToeBoard = new char[,] 
            { 
                { '-', '-', '-' }, 
                { '-', '-', '-' }, 
                { '-', '-', '-' } 
            };  //Board

            int i = 0;

            while (i <= 9)
            {



                for (int turns = 0; turns < 9; turns++)
                {
                    Console.Write("Player 'X' row: ");      //Player 'X'
                    int r = int.Parse(Console.ReadLine());

                    Console.Write("Player 'X' col: ");
                    int c = int.Parse(Console.ReadLine());

                    TicTacToeBoard[r, c] = 'X';

                    //if(TicTacToeBoard[r,c] != 'O' || TicTacToeBoard [r,c] != 'X')
                    //{
                        
                    //}

                    if(r >= 3 && c >= 3)
                    {
                        Console.WriteLine("Not a valid move. Please choose again.");
                        continue;
                    }

                    PrintBoard(TicTacToeBoard);

                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.Write(TicTacToeBoard[row, col]);
                        }

                        Console.WriteLine();
                    }

                    Console.Write("Player 'O' row: ");      //Player 'O'
                    int r2 = int.Parse(Console.ReadLine());

                    Console.Write("Player 'O' col: ");
                    int c2 = int.Parse(Console.ReadLine());

                    TicTacToeBoard[r2, c2] = 'O';
                    if (r2 >= 3 && c2 >= 3)
                    {
                        Console.WriteLine("Not a valid move. Please choose again.");
                        continue;
                    }


                    PrintBoard(TicTacToeBoard);

                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.Write(TicTacToeBoard[row, col]);
                        }

                        Console.WriteLine();
                    }





                } //End for each turn

                i++;
            }

        }//End Main()

        public static char[,] PrintBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }

            return board;
        }

        public static bool DidPlayerWin(int [,] board)
        {
            if (board [0,0] == 'X' && board [0,1] == 'X' && board [0,2] == 'X')
            {
                return true;
            }

            if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                return true;
            }

            if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            if (board[0, 0] == '0' && board[0, 1] == '0' && board[0, 2] == '0')
            {
                return true;
            }

            if (board[1, 0] == '0' && board[1, 1] == '0' && board[1, 2] == '0')
            {
                return true;
            }

            if (board[2, 0] == '0' && board[2, 1] == '0' && board[2, 2] == '0')
            {
                return true;
            }

            return false;
        }

        //public static char PlayerMove()
        //{

        //}

    }//End class
}
