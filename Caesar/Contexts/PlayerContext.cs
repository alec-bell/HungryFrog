using Caesar.Interfaces;
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

        public PlayerContext(ContentManager content, Vector2 loc)
        {
            Sprite = new CaesarSprite(content);
            Location = loc;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
