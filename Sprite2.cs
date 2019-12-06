using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Sprite2
    {
        private Texture2D texture;
        public Vector2 position;

        public Sprite2(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update(double interval, float Speed)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                position.Y -= Speed * (float)interval; //Position.Y = position.Y - 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                position.Y += Speed * (float)interval; //PosY goes down 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += Speed * (float)interval; //PosX goes right 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= Speed * (float)interval; //PosX goes left 1
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.Black);
        }
    }
}