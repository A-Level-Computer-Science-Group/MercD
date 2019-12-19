using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        private SpriteBatch spriteBatch;

        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }

        public void Draw(Texture2D texture, Rectangle destinationRectangle)
        {
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Begin();
                spriteBatch.Draw(texture, destinationRectangle, Color.Black);
                spriteBatch.End();
            }
        }
    }
}
