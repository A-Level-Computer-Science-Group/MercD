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
    public class Sprite
    {
        private Texture2D texture;
        public Vector2 position;

        public float Speed = 2f;

        public Sprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= Speed; //Position.Y = position.Y - 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += Speed; //PosY goes down 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += Speed; //PosX goes right 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= Speed; //PosX goes left 1
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.Black);
        }
    }
}