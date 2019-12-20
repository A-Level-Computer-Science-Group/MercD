using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using main;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }
        public void Draw(Texture2D texture, Rectangle destinationRectangle, SpriteBatch spriteBatch, ScreenResolution screenResolution)
        {
            float screenScaleRatioX = screenResolution.width / camera.scope.X;
            float screenScaleRatioY = screenResolution.height / camera.scope.Y;
            Rectangle cameraRelativeRectangle = new Rectangle(
                camera.scope.X - destinationRectangle.X,
                camera.scope.Y - destinationRectangle.Y,
                destinationRectangle.Width,
                destinationRectangle.Height
            );
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, cameraRelativeRectangle, Color.Black);
            }
        }
    }
}
