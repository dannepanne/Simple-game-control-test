using System;

namespace SpelProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            bool playing = true;
            while (playing)
            {
                board.ShowBoard();
            }
            
            Console.ReadKey();
        }
    }
}
