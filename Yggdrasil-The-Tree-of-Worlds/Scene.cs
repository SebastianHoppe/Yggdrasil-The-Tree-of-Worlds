using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Yggdrasil_The_Tree_of_Worlds
{
  abstract  class Scene
    {
        public abstract LoadContent();
        public abstract Update(GameTime gametime);
        public abstract Draw(SpriteBatch spriteBatch);
    }
}
