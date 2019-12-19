using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }

        public void Draw(Texture2D texture, Rectangle destinationRectangle, SpriteBatch spriteBatch)
        {
            Rectangle cameraRelativePosition = destinationRectangle;
            cameraRelativePosition.X = camera.scope.X - destinationRectangle.X;
            cameraRelativePosition.Y = camera.scope.Y - destinationRectangle.Y;
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, cameraRelativePosition, Color.Black);
            }
        }
    }
}
