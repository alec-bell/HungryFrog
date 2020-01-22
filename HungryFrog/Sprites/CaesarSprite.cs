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
    class CaesarSprite : ISprite
    {
        public Texture2D Texture { get; set; }

        public CaesarSprite(ContentManager content)
        {
            Texture = content.Load<Texture2D>("caesar");
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Draw(Texture, location, Color.White);
        }
    }
}
