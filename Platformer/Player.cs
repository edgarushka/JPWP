using System.Drawing;

namespace Platformer
{
    public class Player
    {
        public Image spritesAnimation;
        public int x, y;
        public Size scale;
        private AnimationPosition currAnimation = AnimationPosition.Right;

        /// <summary>
        /// Properties
        /// </summary>
        public AnimationPosition CurrAnimation
        {
            get => currAnimation;
            set
            {
                currAnimation = value;
            }
        }
        /// <summary>
        /// Player parametres constructor
        /// </summary>
        /// <param name="_scale"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spriteAnimation"></param>
        public Player(Size _scale,int x,int y,Image spriteAnimation)
        {
            this.scale = _scale;
            this.x = x;
            this.y = y;
            this.spritesAnimation = spriteAnimation;
        }
        /// <summary>
        /// Moving to the left
        /// </summary>
        public void Left()
        {
            x -= Game.Speed;
        }
        /// <summary>
        /// Moving to the right
        /// </summary>
        public void Right()
        {
            x += Game.Speed;            
        }
        /// <summary>
        /// Moving up
        /// </summary>
        public void Up()
        {
            y -= Game.Speed;
        }
        /// <summary>
        /// Moving down
        /// </summary>
        public void Down()
        {
            y += Game.Speed;
        }
    }
}
