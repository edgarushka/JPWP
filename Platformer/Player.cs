using System.Drawing;

namespace Platformer
{
    public class Player
    {
        public Image spritesAnimation;
        public int x, y;
        public Size scale;
        private AnimationPosition currAnimation = AnimationPosition.Right;

        public AnimationPosition CurrAnimation
        {
            get => currAnimation;
            set
            {
                currAnimation = value;
            }
        }

        public Player(Size _scale,int x,int y,Image spriteAnimation)
        {
            this.scale = _scale;
            this.x = x;
            this.y = y;
            this.spritesAnimation = spriteAnimation;
        }
        public void Left()
        {
            x -= Game.Speed;
        }

        public void Right()
        {
            x += Game.Speed;            
        }

        public void Up()
        {
            y -= Game.Speed;
        }

        public void Down()
        {
            y += Game.Speed;
        }
    }
}
