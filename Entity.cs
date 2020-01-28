using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    // An `Entity` is a visible object.
    interface Entity
    {
        // TODO pass in keyboard info.
        void Update(double interval);
        void Draw(SpriteBatch spriteBatch);
    }

    // Simple Entity that other Entities can be composed of.
    class SimpleEntity : Entity
    {
        Rectangle scope;
        Texture2D texture;
        Color color;

        SimpleEntity(Rectangle scope, Texture2D texture, Color color)
        {
            this.scope = scope;
            this.texture = texture;
            this.color = color;
        }

        public void Update(double interval) { }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, color);
        }

    }
}