using Caesar.Interfaces;
using Caesar.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class PlayerContext : IContext
    {
        public Vector2 Location { get; set; }
        public ISprite Sprite { get; set; }

        public PlayerContext(ContentManager content, Vector2 location)
        {
            Sprite = new CaesarSprite(content);
            Location = location;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Location);
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void MoveLeft()
        {
            Location = new Vector2(Location.X - 5, Location.Y);
        }

        public void MoveRight()
        {
            Location = new Vector2(Location.X + 5, Location.Y);
        }

        public void MoveUp()
        {
            Location = new Vector2(Location.X, Location.Y - 5);
        }

        public void MoveDown()
        {
            Location = new Vector2(Location.X, Location.Y + 5);
        }
    }
}
