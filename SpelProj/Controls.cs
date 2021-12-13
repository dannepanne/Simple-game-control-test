using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelProj
{
    class Controls
    {
        public string PlayerInput()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    return "L";

                case ConsoleKey.RightArrow:
                    return "R";
                    

                case ConsoleKey.UpArrow:
                    return "U";
                    

                case ConsoleKey.DownArrow:
                    return "D";

                default:
                    return null;
            }
            
        }
    }
}
