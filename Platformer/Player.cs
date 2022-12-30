using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    class Player
    {
        public Image spritesAnimation;
        public int x, y;
        public Size scale;
        private AnimationPosition currAnimation = AnimationPosition.Right;
        private AnimationPosition prevAnimation = AnimationPosition.Right;
        public int speed = 10;

        // Properties c#
        public AnimationPosition CurrAnimation { 
            get => currAnimation;
            set{
                prevAnimation = currAnimation;
                currAnimation = value;
            }
        }

        public AnimationPosition PrevAnimation {
            get => prevAnimation;
            private set => prevAnimation = value;
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
           
            x -= speed;
            //playerPic.Location = new Point(playerPic.Location.X - 1, playerPic.Location.Y);
        }

        public void Right()
        {
            x += speed;            
            //playerPic.Location = new Point(playerPic.Location.X + 1, playerPic.Location.Y);
        }

        public void Up()
        {
            y -= speed;
            //playerPic.Location = new Point(playerPic.Location.X , playerPic.Location.Y-1);
        }

        public void Down()
        {
            y += speed;
            //playerPic.Location = new Point(playerPic.Location.X, playerPic.Location.Y+1);
        }
    }
}
