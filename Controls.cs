using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace main
{
    class Controls
    {
        private const float speed = 3f;
        private Texture2D texture;
        GameTime gameTime;
        private TimeSpan lastTime;
        private Vector2 _position;

        public Controls(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this._position = position;
        }

        public void Update(float interval)
        {
            lastTime = gameTime.TotalGameTime;
            interval = (float)((gameTime.TotalGameTime - lastTime).TotalSeconds);
            // Gets the state of each key press
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) {_position.Y += (speed * interval);}
            if (Keyboard.GetState().IsKeyDown(Keys.Down)) {_position.Y -= (speed * interval);}
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) {_position.X -= (speed * interval);}
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) {_position.X += (speed * interval);}
            Console.WriteLine("Hello World");
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, _position, Color.Black);
        }
        
    }
}