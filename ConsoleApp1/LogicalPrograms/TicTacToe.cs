using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TicTacToe
    {
        
        public TicTacToe()
        {
            char[,] ch = new char[4, 4];
            setBoard(ch);
            displayBoard(ch);
            int[] fills = new int[10];
            char Player = 'X';
            while(true)
            {
                if(Player=='X')
                {
                    Console.Write("Player X turn...: ");
                }
                else
                {
                    Console.Write("Player O turn...: ");
                }
                Console.Write("enter the box number: ");
                int number = (Convert.ToInt32(Console.ReadLine()));
                while (true)
                {
                   
                    if (number >= 10 || number <= 0 || SaveAndValidate(fills,number))
                    {
                        Console.Write("enter the valid box number:");
                         number = (Convert.ToInt32(Console.ReadLine()));
                    }
                    else
                    { break; }
                } 
                takeBox(number,ch,Player);
                if(Player=='X')
                {
                    Player = 'O';
                }
                else
                {
                    Player = 'X';
                }
                Console.Clear();
                displayBoard(ch);
                CheckForWin(ch);
                CheckForTie(ch);
            }



        }

        public void takeBox(int n, char[,] ch, char p)
        {
            int[,] box = { { 0, 0 }, { 1, 1 }, { 1, 2 }, { 1, 3 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 3, 1 }, { 3, 2 }, { 3, 3 } };
            int row = box[n, 0];
            int col = box[n, 1];
            ch[row, col] = p;
        }
        public bool SaveAndValidate(int[] fills, int n)
        {
            for (int i = 1; i < fills.Length; i++)
            {
                if (n == fills[i])
                {
                    return true;
                }

            }
            fills[n] = n;
            return false;
        }
        public void setBoard(char[,] ch)
        {
            for (int i = 1; i < ch.GetLength(0); i++)
            {
                for (int j = 1; j < ch.GetLength(1); j++)
                {
                    ch[i, j] = ' ';
                }
            }
        }
        public void CheckForTie(char[,] ch)
        {
            int inc = 0;
            for (int i = 1; i < ch.GetLength(0); i++)
            {
                for (int j = 1; j < ch.GetLength(1); j++)
                {
                    if (ch[i, j] == ' ')
                    {
                        inc++;
                    }
                }
            }
            if (inc == 0)
            {
                Console.WriteLine("its tie play again...");
                System.Environment.Exit(0);
            }
        }
        public void CheckForWin(char[,] ch)
        {

            string row1 = "" + ch[1, 1] + ch[1, 2] + ch[1, 3]
            , row2 = "" + ch[2, 1] + ch[2, 2] + ch[2, 3]
                , row3 = "" + ch[3, 1] + ch[3, 2] + ch[3, 3]
                , col1 = "" + ch[1, 1] + ch[2, 1] + ch[3, 1]
                , col2 = "" + ch[1, 2] + ch[2, 2] + ch[3, 2]
                , col3 = "" + ch[1, 3] + ch[2, 3] + ch[3, 3]
                , dia1 = "" + ch[1, 1] + ch[2, 2] + ch[3, 3]
                , dia2 = "" + ch[1, 3] + ch[2, 2] + ch[3, 1],
                X = "XXX", O = "OOO";
            
            if (row1 == X || row2 == X || row3 == X || col1 == X || col2 == X || col3 == X || dia1 == X||dia2==X)
            {
                Console.WriteLine("Player X won....!");
                System.Environment.Exit(0);
            }
            if (row1 == O || row2 == O || row3 == O || col1 == O || col2 == O || col3 == O || dia1 == O || dia2 == O)
            {
                Console.WriteLine("Player O won....!");
                System.Environment.Exit(0);
            }

        }
        public void displayBoard(char[,] ch)
        {
            for (int i = 1; i < ch.GetLength(0); i++)
            {
                for (int j = 1; j < ch.GetLength(1); j++)
                {
                    Console.Write(ch[i, j] + " | ");
                    
                }
                Console.WriteLine();
                Console.WriteLine("_ _ _ _ _ _");
            }

        }
    }
}
