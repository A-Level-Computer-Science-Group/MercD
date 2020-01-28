using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    interface Entity
    {
        void Update(double interval);
        void Draw(SpriteBatch spriteBatch);
    }

    class SimpleEntity : Entity
    {
        Rectangle scope;
        Texture2D texture;

        SimpleEntity(Rectangle scope, Texture2D texture, Color color)
        {
            this.scope = scope;
            this.texture = texture;
        }

        public void Update(double interval) { }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, color);
        }

    }
}