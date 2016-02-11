using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Yggdrasil_The_Tree_of_Worlds
{
   static class SceneManager
    {
        public static Scene CurrentScene { get; private set; }

        public static void LoadScene<T>() where T : Scene, new()
        {
            CurrentScene = new T();
            CurrentScene.LoadContent();
        }

        public static void UpdateScene(GameTime gameTime)
        {
            CurrentScene.Update(gameTime);
        }

        public static void DrawScene(SpriteBatch spriteBatch)
        {
            CurrentScene.Draw(spriteBatch);
        }
    }
}
