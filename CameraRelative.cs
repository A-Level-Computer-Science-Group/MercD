using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        private SpriteBatch spriteBatch;
        private Vector2 positionDifference;

        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }

        public void Draw(Texture2D texture, Rectangle destinationRectangle)
        {
            positionDifference.X = camera.scope.X - destinationRectangle.X;
            positionDifference.Y = camera.scope.Y - destinationRectangle.Y;
            spriteBatch.Begin();
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, destinationRectangle, Color.Black);
            }
            spriteBatch.End();
        }
    }
}
