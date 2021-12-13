using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelProj
{
    class Board
    {
        Controls cont = new Controls();
        int[,] playingField = new int[,] { { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        public void ShowBoard()
        {
            Console.Clear();
            int row = 0;
            int col = 0;
            
            int rowLength = playingField.GetLength(0);
            int colLength = playingField.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", playingField[i, j]));
                    if (playingField[i, j] == 1)
                    {
                        row = i;
                        col = j;
                        playingField[i, j] = 0;
                    }

                }
                Console.Write(Environment.NewLine + Environment.NewLine);

            }

            ConsoleKeyInfo input = Console.ReadKey();
            
                switch (input.Key) //fel längd? riktning?
                {
                    case ConsoleKey.LeftArrow:
                        if (col > 0)
                        col = col - 1;                       
                        break;

                    case ConsoleKey.RightArrow:
                    if(col < colLength -1)
                        col = col + 1;                      
                        break;

                    case ConsoleKey.UpArrow:
                        if(row > 0)
                        row = row - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        if(row < rowLength -1)
                        row = row + 1;
                        break;

                    default:
                        break;
                }

            playingField[row, col] = 1;
        }


    }
}
