using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    class StickMan
    {
        private Texture2D texture;
        public Vector2 Position;

        public StickMan(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
            // Gets the state of each key press
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) // If keypress is Up
            {
                //Speed
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down)) 
            {
                //Speed
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                //Speed
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                //Speed
            }
        }
    }
}
