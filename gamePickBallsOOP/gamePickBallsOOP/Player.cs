using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamePickBallsOOP
{
    class Player
    {
       private string Name;
        public Player(string name)
        {
            this.Name = name;
        }
        public void PickBalls(Board game)
        {
            Console.Write("Which group do you choose: ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do you pick: ");
            int ball = int.Parse(Console.ReadLine());
            game.PickBalls(group,ball);
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
