using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Enemy
    {
       
        public int yCoordinate = 7;
        public int speed = 1;
        public int down = 1;
        public void DisplayEnemy()
        {
            if (yCoordinate < 14 && down == 1)
                yCoordinate++;
            if (yCoordinate == 14)
                down = 0;
            if (yCoordinate > 2 && down == 0)
                yCoordinate--;
            if (yCoordinate == 2)
                down = 1;
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(48, yCoordinate);
            Console.Write("X");
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
    }
}
