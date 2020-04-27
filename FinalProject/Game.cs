using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Game
    {
        public GoldBlock playerBlock;
        public Block Block1;
        public Enemy enemy1;
        private bool isPlaying = true;

        private void InitializeGame()
        {
            playerBlock = new GoldBlock();
            Block1 = new Block();
            enemy1 = new Enemy();
        }

        public void Run()
        {
            InitializeGame();
            do
            {
                ProcessInput();
                UpdateGame();
                RenderOutput();
            } while (isPlaying);
        }



        public void RenderOutput()
        {
            if (invalidated)
            {
                Console.Clear();
                DrawBoard(50, 15);
                playerBlock.DisplayGoldBlock();
                Block1.DisplayBlock();
                enemy1.DisplayEnemy();
                
                invalidated = false;
            }
        }

        private DateTime gameTime = DateTime.Now;
        private void UpdateGame()
        {
            int updateInterval = 2000; // 1/2 a second
            if (DateTime.Now.Subtract(gameTime) >
                TimeSpan.FromMilliseconds(updateInterval))
            {
                invalidated = true;
                gameTime = DateTime.Now;
            }
        }

        
        private bool invalidated = true;
        private void ProcessInput()
        {
            ConsoleKeyInfo keyInfo;
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        playerBlock.MoveRight();
                        invalidated = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerBlock.MoveLeft();
                        invalidated = true;
                        break;
                    case ConsoleKey.Q:
                        Block1.MoveUp();
                        invalidated = true;
                        break;
                    case ConsoleKey.A:
                        Block1.MoveDown();
                        invalidated = true;
                        break;
                }
            }
        }

        public void DrawBoard(int width, int height)
                {
            
                    for (int a = 0; a < height; a++)
                    {
                        for (int b = 0; b < width; b++)
                        {
                            if (a == 7  && b == width - 1)
                                Console.Write("[");
                            else if (a == 0 || b == 0 || a == height - 1 || b == width - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine("");
                    }
                }


    }
}
