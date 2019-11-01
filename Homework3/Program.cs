using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Game
    {
        public bool gameOver = false;
        private int currentTime;
        public int AmountOfEnemies = 5;

        public void ArenaGen()
        {
            int[,] arena = new int[6, 6];
            for (int i = 0; i < arena.GetLength(0); i++)
            {
                for (int t = 0; t < arena.GetLength(1); t++)
                {
                    arena[i, t] = i + t;
                }
            }
           
        }

    }

    class Controller
    {
        public double x, y;
        private int velocity;

        public Controller()
        {
            x = 0;
            y = 0;
            velocity = 5;
        }

        public int Velocity { get => velocity; set => velocity = value; }
    }

    class Player: Controller
    {
        int health;
        bool isDead = false;  
        public Player()
        {
            x = 0;
            y = 0;
            this.Velocity = 8;
        }
        public Player(int x, int y, int velocity)
        {
            this.x = x;
            this.y = y;
            this.Velocity = 8;
        }
    }

    class Enemy : Controller
    {
        int health;
        bool isDead = false;
        public string Name;
        public Enemy()
        {
            x = 10;
            y = 10;
            Velocity = 5;
        }

        public void Spawned()
        {
            Console.WriteLine(Name +" has Spawned");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.gameOver = true;
            
            for (int i = 0; i < game.AmountOfEnemies; i++)
            {
                Enemy[] enemies = new Enemy[i];

            }
            
            
            //enemies[0].Name = "Bob";
            //enemies[0].Name = "Fred";
            //enemies[0].Name = "Mikyta";
            //enemies[0].Name = "Ryan";
            //enemies[0].Name = "Suarez";

            //enemies[0].Spawned();


            Player player = new Player(1, 1, 4);

            
            Console.ReadLine();
        }
    }
}
