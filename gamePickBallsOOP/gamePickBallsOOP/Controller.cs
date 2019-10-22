using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamePickBallsOOP
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;
      public Controller()
        {
            this.Game = new Board(3, 4, 6);
            this.P1 = new Player("Tam");
            this.P2 = new Player("Thai");
        }

        public void Playgame()
        {
            Game.PrintGame();
            while(true){
                Console.WriteLine("{0} plays...",P1.GetName());
                P1.PickBalls(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " win");
                    break;
                }
                Console.WriteLine("{0} plays...",P2.GetName());
                P2.PickBalls(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " win");
                    break;
                }
            }
        }
    }
}
