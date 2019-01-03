using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar.Interfaces
{
    interface IContext
    {
        Vector2 Location { get; set; }
        ISprite Sprite { get; set; }

        void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime);
    }
}
