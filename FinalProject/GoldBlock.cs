using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class GoldBlock
    {
        public int yCoordinate = 7;
        public int xCoordinate = 8;
        public int GoldenBlockLength = 3;

        public void DisplayGoldBlock()
        {
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(xCoordinate, yCoordinate);
            Console.Write("GGG");
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
        
        public void MoveLeft()
        {
            if(xCoordinate > 1)
            xCoordinate--;
            DisplayGoldBlock();
        }

        public void MoveRight()
        {
            //will need code to make sure you are not colliding with a block or edge of the game
            if(xCoordinate < 46)
            xCoordinate++;
            DisplayGoldBlock();
        }
    }
}
