using HungryFrog.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryFrog.Sprites
{
    class FrogSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public Rectangle CurrentFrame;
        private Boolean FacingRight = true;

        public FrogSprite(ContentManager content)
        {
            Texture = content.Load<Texture2D>("frog");
            CurrentFrame = new Rectangle(36, 0, 49, 33);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Draw(
                Texture, 
                new Rectangle((int)location.X, (int)location.Y, 49, 33),
                CurrentFrame,
                Color.White
            );
        }

        public void FaceRight()
        {
            if (!FacingRight)
                CurrentFrame.X = 971 - CurrentFrame.X - CurrentFrame.Width;
            FacingRight = true;
        }

        public void FaceLeft()
        {
            if (FacingRight)
                CurrentFrame.X = 971 - CurrentFrame.X - CurrentFrame.Width;
            FacingRight = false;
        }
    }
}
