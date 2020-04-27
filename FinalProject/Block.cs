using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Block
    {
        public int yCoordinate = 10;
        public int xCoordinate = 40;
        public int length;
        public int orientation;

        public void DisplayBlock()
        {
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(xCoordinate, yCoordinate);
            Console.Write("1");
            Console.SetCursorPosition(xCoordinate, yCoordinate + 1);
            Console.Write("1");
            Console.SetCursorPosition(xCoordinate, yCoordinate + 2);
            Console.Write("1");
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }

        public void MoveRight()
        {
            //will need code to make sure you are not colliding with a block or edge of the game
            xCoordinate++;
            DisplayBlock();
        }

        public void MoveLeft()
        {
            //will need code to make sure you are not colliding with a block or edge of the game
            xCoordinate--;
            DisplayBlock();
        }

        public void MoveUp()
        {
            //will need code to make sure you are not colliding with a block or edge of the game
            if (yCoordinate > 1)
                yCoordinate--;
            DisplayBlock();
        }

        public void MoveDown()
        {
            //will need code to make sure you are not colliding with a block or edge of the game
            if(yCoordinate < 11)
            yCoordinate++;
            DisplayBlock();
        }

    }
}
