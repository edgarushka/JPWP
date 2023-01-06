
using System.Drawing;

namespace Platformer
{
    public class Enemy
    {
        public int yEnemy;

        public Enemy(int yEnemy)
        {
            this.yEnemy = yEnemy;
        }

        public void enemyUp()
        {
            yEnemy -= Game.Speed;
        }
    }
}
